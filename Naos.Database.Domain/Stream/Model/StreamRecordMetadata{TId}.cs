﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StreamRecordMetadata{TId}.cs" company="Naos Project">
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
    /// Metadata of a stream entry.
    /// </summary>
    /// <typeparam name="TId">The type of the identifier.</typeparam>
    public partial class StreamRecordMetadata<TId> : IHaveTags, IModelViaCodeGen, IHaveTimestampUtc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamRecordMetadata{TId}"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="serializerRepresentation">The representation of the serializer used.</param>
        /// <param name="typeRepresentationOfId">The type representation of the identifier.</param>
        /// <param name="typeRepresentationOfObject">The type representation of the object.</param>
        /// <param name="tags">The tags.</param>
        /// <param name="timestampUtc">The timestamp of the record in UTC.</param>
        /// <param name="objectTimestampUtc">The object's timestamp in UTC (if applicable).</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string", Justification = NaosSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddsClarityToIdentifierAndAlternativesDegradeClarity)]
        public StreamRecordMetadata(
            TId id,
            SerializerRepresentation serializerRepresentation,
            TypeRepresentationWithAndWithoutVersion typeRepresentationOfId,
            TypeRepresentationWithAndWithoutVersion typeRepresentationOfObject,
            IReadOnlyCollection<NamedValue<string>> tags,
            DateTime timestampUtc,
            DateTime? objectTimestampUtc)
        {
            serializerRepresentation.MustForArg(nameof(serializerRepresentation)).NotBeNull();
            typeRepresentationOfId.MustForArg(nameof(typeRepresentationOfId)).NotBeNull();
            typeRepresentationOfObject.MustForArg(nameof(typeRepresentationOfObject)).NotBeNull();

            this.Id = id;
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

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        public TId Id { get; private set; }

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
