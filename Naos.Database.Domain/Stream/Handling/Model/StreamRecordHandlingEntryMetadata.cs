﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StreamRecordHandlingEntryMetadata.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using System;
    using System.Collections.Generic;
    using Naos.CodeAnalysis.Recipes;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Serialization;
    using OBeautifulCode.Type;

    /// <summary>
    /// Metadata of a stream handling entry.
    /// </summary>
    public partial class StreamRecordHandlingEntryMetadata : IHaveTags, IModelViaCodeGen, IHaveTimestampUtc, IHaveInternalRecordId, IHaveHandleRecordConcern
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamRecordHandlingEntryMetadata"/> class.
        /// </summary>
        /// <param name="internalRecordId">The internal record identifier of the record that originated the handling.</param>
        /// <param name="concern">The concern.</param>
        /// <param name="status">The status of the entry.</param>
        /// <param name="stringSerializedId">The identifier serialized as a string.</param>
        /// <param name="serializerRepresentation">The representation of the serializer used.</param>
        /// <param name="typeRepresentationOfId">The type representation of the identifier.</param>
        /// <param name="typeRepresentationOfObject">The type representation of the object.</param>
        /// <param name="tags">The tags.</param>
        /// <param name="timestampUtc">The timestamp of the record in UTC.</param>
        /// <param name="objectTimestampUtc">The object's timestamp in UTC (if applicable).</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string", Justification = NaosSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddsClarityToIdentifierAndAlternativesDegradeClarity)]
        public StreamRecordHandlingEntryMetadata(
            long internalRecordId,
            string concern,
            HandlingStatus status,
            string stringSerializedId,
            SerializerRepresentation serializerRepresentation,
            TypeRepresentationWithAndWithoutVersion typeRepresentationOfId,
            TypeRepresentationWithAndWithoutVersion typeRepresentationOfObject,
            IReadOnlyCollection<NamedValue<string>> tags,
            DateTime timestampUtc,
            DateTime? objectTimestampUtc)
        {
            concern.MustForArg(nameof(concern)).NotBeNullNorWhiteSpace();
            serializerRepresentation.MustForArg(nameof(serializerRepresentation)).NotBeNull();
            typeRepresentationOfId.MustForArg(nameof(typeRepresentationOfId)).NotBeNull();
            typeRepresentationOfObject.MustForArg(nameof(typeRepresentationOfObject)).NotBeNull();

            this.InternalRecordId = internalRecordId;
            this.Concern = concern;
            this.Status = status;
            this.StringSerializedId = stringSerializedId;
            this.SerializerRepresentation = serializerRepresentation;
            this.Tags = tags;
            this.TypeRepresentationOfId = typeRepresentationOfId;
            this.TypeRepresentationOfObject = typeRepresentationOfObject;

            if (timestampUtc.Kind != DateTimeKind.Utc)
            {
                throw new ArgumentException("The timestamp must be in UTC format; it is: " + timestampUtc.Kind, nameof(timestampUtc));
            }

            if (objectTimestampUtc != null && objectTimestampUtc?.Kind != DateTimeKind.Utc)
            {
                throw new ArgumentException("The timestamp must be in UTC format; it is: " + timestampUtc.Kind, nameof(timestampUtc));
            }

            this.TimestampUtc = timestampUtc;
            this.ObjectTimestampUtc = objectTimestampUtc;
        }

        /// <inheritdoc />
        public long InternalRecordId { get; private set; }

        /// <inheritdoc />
        public string Concern { get; private set; }

        /// <summary>
        /// Gets the status.
        /// </summary>
        public HandlingStatus Status { get; private set; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        public string StringSerializedId { get; private set; }

        /// <summary>
        /// Gets the serializer representation.
        /// </summary>
        public SerializerRepresentation SerializerRepresentation { get; private set; }

        /// <inheritdoc />
        public IReadOnlyCollection<NamedValue<string>> Tags { get; private set; }

        /// <summary>
        /// Gets the type representation of identifier.
        /// </summary>
        public TypeRepresentationWithAndWithoutVersion TypeRepresentationOfId { get; private set; }

        /// <summary>
        /// Gets the type representation of object.
        /// </summary>
        public TypeRepresentationWithAndWithoutVersion TypeRepresentationOfObject { get; private set; }

        /// <inheritdoc />
        public DateTime TimestampUtc { get; private set; }

        /// <summary>
        /// Gets the object timestamp in UTC (if applicable).
        /// </summary>
        public DateTime? ObjectTimestampUtc { get; private set; }
    }
}
