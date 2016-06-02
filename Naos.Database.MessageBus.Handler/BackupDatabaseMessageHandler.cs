﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BackupDatabaseMessageHandler.cs" company="Naos">
//   Copyright 2015 Naos
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.MessageBus.Handler
{
    using System;
    using System.IO;
    using System.Threading.Tasks;

    using Its.Configuration;
    using Its.Log.Instrumentation;

    using Naos.Database.Contract;
    using Naos.Database.MessageBus.Contract;
    using Naos.Database.Tools;
    using Naos.FileJanitor.MessageBus.Contract;
    using Naos.MessageBus.Domain;

    /// <summary>
    /// Naos.MessageBus handler for BackupMessages.
    /// </summary>
    public class BackupDatabaseMessageHandler : IHandleMessages<BackupDatabaseMessage>, IShareFilePath, IShareDatabaseName
    {
        /// <inheritdoc />
        public async Task HandleAsync(BackupDatabaseMessage message)
        {
            var settings = Settings.Get<DatabaseMessageHandlerSettings>();
            await this.HandleAsync(message, settings);
        }

        /// <summary>
        /// Handles a BackupDatabaseMessage.
        /// </summary>
        /// <param name="message">Message to handle.</param>
        /// <param name="settings">Needed settings to handle messages.</param>
        /// <returns>Task to support async await calling.</returns>
        public async Task HandleAsync(BackupDatabaseMessage message, DatabaseMessageHandlerSettings settings)
        {
            using (var activity = Log.Enter(() => new { Message = message, DatabaseName = message.DatabaseName }))
            {
                // must have a date that is strictly alphanumeric...
                var datePart =
                    DateTime.UtcNow.ToString("u")
                        .Replace("-", string.Empty)
                        .Replace(":", string.Empty)
                        .Replace(" ", string.Empty);
                var backupFilePath = Path.Combine(settings.BackupDirectory, message.BackupName) + "TakenOn" + datePart + ".bak";

                this.FilePath = backupFilePath;
                this.DatabaseName = message.DatabaseName;

                var backupFilePathUri = new Uri(this.FilePath);
                var backupDetails = new BackupDetails()
                                        {
                                            Name = message.BackupName,
                                            BackupTo = backupFilePathUri,
                                            ChecksumOption = message.ChecksumOption,
                                            Cipher = message.Cipher,
                                            CompressionOption = message.CompressionOption,
                                            Description = message.BackupDescription,
                                            Device = Device.Disk,
                                            ErrorHandling = message.ErrorHandling,
                                        };

                activity.Trace(
                    () => $"Backing up database {this.DatabaseName} to {backupFilePath}");

                await DatabaseManager.BackupFullAsync(
                    settings.LocalhostConnectionString,
                    this.DatabaseName,
                    backupDetails,
                    settings.DefaultTimeout);

                activity.Trace(() => "Completed successfully.");
            }
        }

        /// <inheritdoc />
        public string FilePath { get; set; }

        /// <inheritdoc />
        public string DatabaseName { get; set; }
    }
}
