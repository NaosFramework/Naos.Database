﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StreamRecord{TObject}.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Protocol.Memory
{
    using Naos.Database.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// The record in a <see cref="IStream"/>; metadata and the actual object.
    /// </summary>
    /// <typeparam name="TObject">Payload type.</typeparam>
    public class StreamRecord<TObject> : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamRecord{TObject}"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="metadata">The metadata.</param>
        /// <param name="payload">The payload.</param>
        public StreamRecord(
            long id,
            StreamRecordMetadata metadata,
            TObject payload)
        {
            metadata.MustForArg(nameof(metadata)).NotBeNull();
            payload.MustForArg(nameof(payload)).NotBeNull();

            this.Id = id;
            this.Metadata = metadata;
            this.Payload = payload;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public long Id { get; private set; }

        /// <summary>
        /// Gets the metadata.
        /// </summary>
        /// <value>The metadata.</value>
        public StreamRecordMetadata Metadata { get; private set; }

        /// <summary>
        /// Gets the payload.
        /// </summary>
        /// <value>The payload.</value>
        public TObject Payload { get; private set; }
    }
}
