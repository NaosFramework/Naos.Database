﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TryHandleRecordWithIdOp{TId,TObject}.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Handles a record.
    /// </summary>
    /// <typeparam name="TId">Type of the identifier of the record.</typeparam>
    /// <typeparam name="TObject">Type of the object in the record.</typeparam>
    public partial class TryHandleRecordWithIdOp<TId, TObject> : ReturningOperationBase<StreamRecordWithId<TId, TObject>>, ITryHandleRecordOpBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TryHandleRecordWithIdOp{TId, TObject}"/> class.
        /// </summary>
        /// <param name="concern">The concern.</param>
        /// <param name="typeVersionMatchStrategy">The optional type version match strategy; DEFAULT is Any.</param>
        /// <param name="orderRecordsStrategy">The optional ordering for the records; DEFAULT is ascending by internal record identifier.</param>
        /// <param name="specifiedResourceLocator">The optional locator to use; DEFAULT will assume single locator on stream or throw.</param>
        /// <param name="tags">The optional tags to write with produced events.</param>
        /// <param name="details">The optional details to write with produced events.</param>
        /// <param name="minimumInternalRecordId">The optional minimum record identifier to consider for handling (this will allow for ordinal traversal and handle each record once before starting over which can be desired behavior on things that self-cancel and are long running).</param>
        /// <param name="inheritRecordTags">The optional value indicating whether handling entries should include any tags on the record being handled; DEFAULT is 'false'.</param>
        public TryHandleRecordWithIdOp(
            string concern,
            TypeVersionMatchStrategy typeVersionMatchStrategy = TypeVersionMatchStrategy.Any,
            OrderRecordsStrategy orderRecordsStrategy = OrderRecordsStrategy.ByInternalRecordIdAscending,
            IResourceLocator specifiedResourceLocator = null,
            IReadOnlyDictionary<string, string> tags = null,
            string details = null,
            long? minimumInternalRecordId = null,
            bool inheritRecordTags = false)
        {
            concern.ThrowIfInvalidOrReservedConcern();

            this.Concern = concern;
            this.TypeVersionMatchStrategy = typeVersionMatchStrategy;
            this.OrderRecordsStrategy = orderRecordsStrategy;
            this.SpecifiedResourceLocator = specifiedResourceLocator;
            this.Tags = tags;
            this.Details = details;
            this.MinimumInternalRecordId = minimumInternalRecordId;
            this.InheritRecordTags = inheritRecordTags;
        }

        /// <inheritdoc />
        public string Concern { get; private set; }

        /// <inheritdoc />
        public TypeVersionMatchStrategy TypeVersionMatchStrategy { get; private set; }

        /// <inheritdoc />
        public OrderRecordsStrategy OrderRecordsStrategy { get; private set; }

        /// <inheritdoc />
        public IResourceLocator SpecifiedResourceLocator { get; private set; }

        /// <inheritdoc />
        public IReadOnlyDictionary<string, string> Tags { get; private set; }

        /// <inheritdoc />
        public string Details { get; private set; }

        /// <inheritdoc />
        public long? MinimumInternalRecordId { get; private set; }

        /// <inheritdoc />
        public bool InheritRecordTags { get; private set; }
    }
}
