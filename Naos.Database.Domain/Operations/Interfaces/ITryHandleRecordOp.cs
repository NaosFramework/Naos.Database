﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITryHandleRecordOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using System.Collections.Generic;
    using OBeautifulCode.Type;

    /// <summary>
    /// Interface to manage common aspects of the Try Handle operation family which cannot have a base class because they are all based on different operation types.
    /// </summary>
    public interface ITryHandleRecordOp : IOperation, IHaveDetails, IHaveTags, IHaveHandleRecordConcern
    {
        /// <summary>
        /// Gets the strategy to use to filter on the version of the queried types that are applicable to this operation.
        /// </summary>
        VersionMatchStrategy VersionMatchStrategy { get; }

        /// <summary>
        /// Gets the tags to match or null when not matching on tags.
        /// </summary>
        IReadOnlyCollection<NamedValue<string>> TagsToMatch { get; }

        /// <summary>
        /// Gets the strategy to use for comparing tags when <see cref="TagsToMatch"/> is specified.
        /// </summary>
        TagMatchStrategy TagMatchStrategy { get; }

        /// <summary>
        /// Gets a value that specifies how to order the resulting records.
        /// </summary>
        OrderRecordsBy OrderRecordsBy { get; }

        /// <summary>
        /// Gets the minimum internal record identifier to consider for handling or null for no minimum identifier.
        /// </summary>
        /// <remarks>
        /// This will allow for ordinal traversal and handle each record once before starting over which can be a desired behavior on protocols that self-cancel and are long running.
        /// </remarks>
        long? MinimumInternalRecordId { get; }

        /// <summary>
        /// Gets a value indicating whether the resulting <see cref="IHandlingEvent"/> should inherit tags from the record being handled.
        /// </summary>
        bool InheritRecordTags { get; }
    }
}
