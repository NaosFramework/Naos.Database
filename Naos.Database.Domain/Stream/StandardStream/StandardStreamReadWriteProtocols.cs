﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StandardStreamReadWriteProtocols.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using System.Threading.Tasks;
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Set of protocols to work with known identifier and/or object type.
    /// Implements the <see cref="IStandardStreamReadProtocols" />
    /// Implements the <see cref="IStandardStreamWriteProtocols" />.
    /// </summary>
    public class StandardStreamReadWriteProtocols :
        IStreamReadProtocols,
        IStreamWriteProtocols
    {
        private readonly IStandardReadWriteStream stream;

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardStreamReadWriteProtocols"/> class.
        /// </summary>
        /// <param name="stream">The stream.</param>
        public StandardStreamReadWriteProtocols(
            IStandardReadWriteStream stream)
        {
            stream.MustForArg(nameof(stream)).NotBeNull();

            this.stream = stream;
        }

        /// <inheritdoc />
        public long Execute(
            GetNextUniqueLongOp operation)
        {
            return this.stream.Execute(operation.Standardize());
        }

        /// <inheritdoc />
        public async Task<long> ExecuteAsync(
            GetNextUniqueLongOp operation)
        {
            var syncResult = this.Execute(operation);

            var result = await Task.FromResult(syncResult);

            return result;
        }
    }
}
