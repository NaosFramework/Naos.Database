﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReadOnlyStreamExtensions.GetAllRecordsMetadataOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Representation.System;
    using OBeautifulCode.Type;

    public static partial class ReadOnlyStreamExtensions
    {
        /// <summary>
        /// Gets all record metadata with provided identifier.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <param name="identifierType">OPTIONAL type of the identifier to filter on.  DEFAULT is no filter.</param>
        /// <param name="objectType">OPTIONAL type of the object to filter on.  DEFAULT is no filter.</param>
        /// <param name="versionMatchStrategy">OPTIONAL strategy to use to filter on the version of the queried types that are applicable to this operation (e.g. object type, object's identifier type).  DEFAULT is no filter (any version is acceptable).</param>
        /// <param name="tagsToMatch">OPTIONAL tags to match.  DEFAULT is no matching on tags.</param>
        /// <param name="tagMatchStrategy">OPTIONAL strategy to use for comparing tags.  DEFAULT is to match when a record contains all of the queried tags (with extra tags on the record ignored), when <paramref name="tagsToMatch"/> is specified.</param>
        /// <param name="recordNotFoundStrategy">OPTIONAL strategy to use when no record(s) are found.  DEFAULT is to return an empty collection.</param>
        /// <param name="orderRecordsBy">OPTIONAL value that specifies how to order the resulting records.  DEFAULT is ascending by internal record identifier.</param>
        /// <param name="deprecatedIdTypes">OPTIONAL object types used in a record that indicates an identifier deprecation.  DEFAULT is no deprecated types specified.  Please see notes in the constructor of <see cref="RecordFilter"/> for <see cref="RecordFilter.DeprecatedIdTypes"/> for how deprecation works.</param>
        /// <returns>The matching stream record(s) metadata.</returns>
        public static IReadOnlyList<StreamRecordMetadata> GetAllRecordsMetadata(
            this IReadOnlyStream stream,
            TypeRepresentation identifierType = null,
            TypeRepresentation objectType = null,
            VersionMatchStrategy versionMatchStrategy = VersionMatchStrategy.Any,
            IReadOnlyCollection<NamedValue<string>> tagsToMatch = null,
            TagMatchStrategy tagMatchStrategy = TagMatchStrategy.RecordContainsAllQueryTags,
            RecordNotFoundStrategy recordNotFoundStrategy = RecordNotFoundStrategy.ReturnDefault,
            OrderRecordsBy orderRecordsBy = OrderRecordsBy.InternalRecordIdAscending,
            IReadOnlyCollection<TypeRepresentation> deprecatedIdTypes = null)
        {
            stream.MustForArg(nameof(stream)).NotBeNull();

            var operation = new GetAllRecordsMetadataOp(identifierType, objectType, versionMatchStrategy, tagsToMatch, tagMatchStrategy, recordNotFoundStrategy, orderRecordsBy, deprecatedIdTypes);
            var protocol = stream.GetStreamReadingProtocols();
            var result = protocol.Execute(operation);
            return result;
        }

        /// <summary>
        /// Gets all record metadata with provided identifier.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <param name="identifierType">OPTIONAL type of the identifier to filter on.  DEFAULT is no filter.</param>
        /// <param name="objectType">OPTIONAL type of the object to filter on.  DEFAULT is no filter.</param>
        /// <param name="versionMatchStrategy">OPTIONAL strategy to use to filter on the version of the queried types that are applicable to this operation (e.g. object type, object's identifier type).  DEFAULT is no filter (any version is acceptable).</param>
        /// <param name="tagsToMatch">OPTIONAL tags to match.  DEFAULT is no matching on tags.</param>
        /// <param name="tagMatchStrategy">OPTIONAL strategy to use for comparing tags.  DEFAULT is to match when a record contains all of the queried tags (with extra tags on the record ignored), when <paramref name="tagsToMatch"/> is specified.</param>
        /// <param name="recordNotFoundStrategy">OPTIONAL strategy to use when no record(s) are found.  DEFAULT is to return an empty collection.</param>
        /// <param name="orderRecordsBy">OPTIONAL value that specifies how to order the resulting records.  DEFAULT is ascending by internal record identifier.</param>
        /// <param name="deprecatedIdTypes">OPTIONAL object types used in a record that indicates an identifier deprecation.  DEFAULT is no deprecated types specified.  Please see notes in the constructor of <see cref="RecordFilter"/> for <see cref="RecordFilter.DeprecatedIdTypes"/> for how deprecation works.</param>
        /// <returns>The matching stream record(s) metadata.</returns>
        public static async Task<IReadOnlyList<StreamRecordMetadata>> GetAllRecordsMetadataAsync(
            this IReadOnlyStream stream,
            TypeRepresentation identifierType = null,
            TypeRepresentation objectType = null,
            VersionMatchStrategy versionMatchStrategy = VersionMatchStrategy.Any,
            IReadOnlyCollection<NamedValue<string>> tagsToMatch = null,
            TagMatchStrategy tagMatchStrategy = TagMatchStrategy.RecordContainsAllQueryTags,
            RecordNotFoundStrategy recordNotFoundStrategy = RecordNotFoundStrategy.ReturnDefault,
            OrderRecordsBy orderRecordsBy = OrderRecordsBy.InternalRecordIdAscending,
            IReadOnlyCollection<TypeRepresentation> deprecatedIdTypes = null)
        {
            stream.MustForArg(nameof(stream)).NotBeNull();

            var operation = new GetAllRecordsMetadataOp(identifierType, objectType, versionMatchStrategy, tagsToMatch, tagMatchStrategy, recordNotFoundStrategy, orderRecordsBy, deprecatedIdTypes);
            var protocol = stream.GetStreamReadingProtocols();
            var result = await protocol.ExecuteAsync(operation);
            return result;
        }

        /// <summary>
        /// Gets all record metadata with provided identifier.
        /// </summary>
        /// <param name="protocol">The protocol.</param>
        /// <param name="identifierType">OPTIONAL type of the identifier to filter on.  DEFAULT is no filter.</param>
        /// <param name="objectType">OPTIONAL type of the object to filter on.  DEFAULT is no filter.</param>
        /// <param name="versionMatchStrategy">OPTIONAL strategy to use to filter on the version of the queried types that are applicable to this operation (e.g. object type, object's identifier type).  DEFAULT is no filter (any version is acceptable).</param>
        /// <param name="tagsToMatch">OPTIONAL tags to match.  DEFAULT is no matching on tags.</param>
        /// <param name="tagMatchStrategy">OPTIONAL strategy to use for comparing tags.  DEFAULT is to match when a record contains all of the queried tags (with extra tags on the record ignored), when <paramref name="tagsToMatch"/> is specified.</param>
        /// <param name="recordNotFoundStrategy">OPTIONAL strategy to use when no record(s) are found.  DEFAULT is to return an empty collection.</param>
        /// <param name="orderRecordsBy">OPTIONAL value that specifies how to order the resulting records.  DEFAULT is ascending by internal record identifier.</param>
        /// <param name="deprecatedIdTypes">OPTIONAL object types used in a record that indicates an identifier deprecation.  DEFAULT is no deprecated types specified.  Please see notes in the constructor of <see cref="RecordFilter"/> for <see cref="RecordFilter.DeprecatedIdTypes"/> for how deprecation works.</param>
        /// <returns>The matching stream record(s) metadata.</returns>
        public static IReadOnlyList<StreamRecordMetadata> GetAllRecordsMetadata(
            this IStreamReadProtocols protocol,
            TypeRepresentation identifierType = null,
            TypeRepresentation objectType = null,
            VersionMatchStrategy versionMatchStrategy = VersionMatchStrategy.Any,
            IReadOnlyCollection<NamedValue<string>> tagsToMatch = null,
            TagMatchStrategy tagMatchStrategy = TagMatchStrategy.RecordContainsAllQueryTags,
            RecordNotFoundStrategy recordNotFoundStrategy = RecordNotFoundStrategy.ReturnDefault,
            OrderRecordsBy orderRecordsBy = OrderRecordsBy.InternalRecordIdAscending,
            IReadOnlyCollection<TypeRepresentation> deprecatedIdTypes = null)
        {
            protocol.MustForArg(nameof(protocol)).NotBeNull();

            var operation = new GetAllRecordsMetadataOp(identifierType, objectType, versionMatchStrategy, tagsToMatch, tagMatchStrategy, recordNotFoundStrategy, orderRecordsBy, deprecatedIdTypes);
            var result = protocol.Execute(operation);
            return result;
        }

        /// <summary>
        /// Gets all record metadata with provided identifier.
        /// </summary>
        /// <param name="protocol">The protocol.</param>
        /// <param name="identifierType">OPTIONAL type of the identifier to filter on.  DEFAULT is no filter.</param>
        /// <param name="objectType">OPTIONAL type of the object to filter on.  DEFAULT is no filter.</param>
        /// <param name="versionMatchStrategy">OPTIONAL strategy to use to filter on the version of the queried types that are applicable to this operation (e.g. object type, object's identifier type).  DEFAULT is no filter (any version is acceptable).</param>
        /// <param name="tagsToMatch">OPTIONAL tags to match.  DEFAULT is no matching on tags.</param>
        /// <param name="tagMatchStrategy">OPTIONAL strategy to use for comparing tags.  DEFAULT is to match when a record contains all of the queried tags (with extra tags on the record ignored), when <paramref name="tagsToMatch"/> is specified.</param>
        /// <param name="recordNotFoundStrategy">OPTIONAL strategy to use when no record(s) are found.  DEFAULT is to return an empty collection.</param>
        /// <param name="orderRecordsBy">OPTIONAL value that specifies how to order the resulting records.  DEFAULT is ascending by internal record identifier.</param>
        /// <param name="deprecatedIdTypes">OPTIONAL object types used in a record that indicates an identifier deprecation.  DEFAULT is no deprecated types specified.  Please see notes in the constructor of <see cref="RecordFilter"/> for <see cref="RecordFilter.DeprecatedIdTypes"/> for how deprecation works.</param>
        /// <returns>The matching stream record(s) metadata.</returns>
        public static async Task<IReadOnlyList<StreamRecordMetadata>> GetAllRecordsMetadataAsync(
            this IStreamReadProtocols protocol,
            TypeRepresentation identifierType = null,
            TypeRepresentation objectType = null,
            VersionMatchStrategy versionMatchStrategy = VersionMatchStrategy.Any,
            IReadOnlyCollection<NamedValue<string>> tagsToMatch = null,
            TagMatchStrategy tagMatchStrategy = TagMatchStrategy.RecordContainsAllQueryTags,
            RecordNotFoundStrategy recordNotFoundStrategy = RecordNotFoundStrategy.ReturnDefault,
            OrderRecordsBy orderRecordsBy = OrderRecordsBy.InternalRecordIdAscending,
            IReadOnlyCollection<TypeRepresentation> deprecatedIdTypes = null)
        {
            protocol.MustForArg(nameof(protocol)).NotBeNull();

            var operation = new GetAllRecordsMetadataOp(identifierType, objectType, versionMatchStrategy, tagsToMatch, tagMatchStrategy, recordNotFoundStrategy, orderRecordsBy, deprecatedIdTypes);
            var result = await protocol.ExecuteAsync(operation);
            return result;
        }

        /// <summary>
        /// Gets all record metadata with provided identifier.
        /// </summary>
        /// <param name="protocol">The protocol.</param>
        /// <param name="identifierType">OPTIONAL type of the identifier to filter on.  DEFAULT is no filter.</param>
        /// <param name="objectType">OPTIONAL type of the object to filter on.  DEFAULT is no filter.</param>
        /// <param name="versionMatchStrategy">OPTIONAL strategy to use to filter on the version of the queried types that are applicable to this operation (e.g. object type, object's identifier type).  DEFAULT is no filter (any version is acceptable).</param>
        /// <param name="tagsToMatch">OPTIONAL tags to match.  DEFAULT is no matching on tags.</param>
        /// <param name="tagMatchStrategy">OPTIONAL strategy to use for comparing tags.  DEFAULT is to match when a record contains all of the queried tags (with extra tags on the record ignored), when <paramref name="tagsToMatch"/> is specified.</param>
        /// <param name="recordNotFoundStrategy">OPTIONAL strategy to use when no record(s) are found.  DEFAULT is to return an empty collection.</param>
        /// <param name="orderRecordsBy">OPTIONAL value that specifies how to order the resulting records.  DEFAULT is ascending by internal record identifier.</param>
        /// <param name="deprecatedIdTypes">OPTIONAL object types used in a record that indicates an identifier deprecation.  DEFAULT is no deprecated types specified.  Please see notes in the constructor of <see cref="RecordFilter"/> for <see cref="RecordFilter.DeprecatedIdTypes"/> for how deprecation works.</param>
        /// <returns>The matching stream record(s) metadata.</returns>
        public static IReadOnlyList<StreamRecordMetadata> GetAllRecordsMetadata(
            this ISyncAndAsyncReturningProtocol<GetAllRecordsMetadataOp, IReadOnlyList<StreamRecordMetadata>> protocol,
            TypeRepresentation identifierType = null,
            TypeRepresentation objectType = null,
            VersionMatchStrategy versionMatchStrategy = VersionMatchStrategy.Any,
            IReadOnlyCollection<NamedValue<string>> tagsToMatch = null,
            TagMatchStrategy tagMatchStrategy = TagMatchStrategy.RecordContainsAllQueryTags,
            RecordNotFoundStrategy recordNotFoundStrategy = RecordNotFoundStrategy.ReturnDefault,
            OrderRecordsBy orderRecordsBy = OrderRecordsBy.InternalRecordIdAscending,
            IReadOnlyCollection<TypeRepresentation> deprecatedIdTypes = null)
        {
            protocol.MustForArg(nameof(protocol)).NotBeNull();

            var operation = new GetAllRecordsMetadataOp(identifierType, objectType, versionMatchStrategy, tagsToMatch, tagMatchStrategy, recordNotFoundStrategy, orderRecordsBy, deprecatedIdTypes);
            var result = protocol.Execute(operation);
            return result;
        }

        /// <summary>
        /// Gets all record metadata with provided identifier.
        /// </summary>
        /// <param name="protocol">The protocol.</param>
        /// <param name="identifierType">OPTIONAL type of the identifier to filter on.  DEFAULT is no filter.</param>
        /// <param name="objectType">OPTIONAL type of the object to filter on.  DEFAULT is no filter.</param>
        /// <param name="versionMatchStrategy">OPTIONAL strategy to use to filter on the version of the queried types that are applicable to this operation (e.g. object type, object's identifier type).  DEFAULT is no filter (any version is acceptable).</param>
        /// <param name="tagsToMatch">OPTIONAL tags to match.  DEFAULT is no matching on tags.</param>
        /// <param name="tagMatchStrategy">OPTIONAL strategy to use for comparing tags.  DEFAULT is to match when a record contains all of the queried tags (with extra tags on the record ignored), when <paramref name="tagsToMatch"/> is specified.</param>
        /// <param name="recordNotFoundStrategy">OPTIONAL strategy to use when no record(s) are found.  DEFAULT is to return an empty collection.</param>
        /// <param name="orderRecordsBy">OPTIONAL value that specifies how to order the resulting records.  DEFAULT is ascending by internal record identifier.</param>
        /// <param name="deprecatedIdTypes">OPTIONAL object types used in a record that indicates an identifier deprecation.  DEFAULT is no deprecated types specified.  Please see notes in the constructor of <see cref="RecordFilter"/> for <see cref="RecordFilter.DeprecatedIdTypes"/> for how deprecation works.</param>
        /// <returns>The matching stream record(s) metadata.</returns>
        public static async Task<IReadOnlyList<StreamRecordMetadata>> GetAllRecordsMetadataAsync(
            this ISyncAndAsyncReturningProtocol<GetAllRecordsMetadataOp, IReadOnlyList<StreamRecordMetadata>> protocol,
            TypeRepresentation identifierType = null,
            TypeRepresentation objectType = null,
            VersionMatchStrategy versionMatchStrategy = VersionMatchStrategy.Any,
            IReadOnlyCollection<NamedValue<string>> tagsToMatch = null,
            TagMatchStrategy tagMatchStrategy = TagMatchStrategy.RecordContainsAllQueryTags,
            RecordNotFoundStrategy recordNotFoundStrategy = RecordNotFoundStrategy.ReturnDefault,
            OrderRecordsBy orderRecordsBy = OrderRecordsBy.InternalRecordIdAscending,
            IReadOnlyCollection<TypeRepresentation> deprecatedIdTypes = null)
        {
            protocol.MustForArg(nameof(protocol)).NotBeNull();

            var operation = new GetAllRecordsMetadataOp(identifierType, objectType, versionMatchStrategy, tagsToMatch, tagMatchStrategy, recordNotFoundStrategy, orderRecordsBy, deprecatedIdTypes);
            var result = await protocol.ExecuteAsync(operation);
            return result;
        }

        /// <summary>
        /// Gets all record metadata with provided identifier.
        /// </summary>
        /// <param name="protocol">The protocol.</param>
        /// <param name="identifierType">OPTIONAL type of the identifier to filter on.  DEFAULT is no filter.</param>
        /// <param name="objectType">OPTIONAL type of the object to filter on.  DEFAULT is no filter.</param>
        /// <param name="versionMatchStrategy">OPTIONAL strategy to use to filter on the version of the queried types that are applicable to this operation (e.g. object type, object's identifier type).  DEFAULT is no filter (any version is acceptable).</param>
        /// <param name="tagsToMatch">OPTIONAL tags to match.  DEFAULT is no matching on tags.</param>
        /// <param name="tagMatchStrategy">OPTIONAL strategy to use for comparing tags.  DEFAULT is to match when a record contains all of the queried tags (with extra tags on the record ignored), when <paramref name="tagsToMatch"/> is specified.</param>
        /// <param name="recordNotFoundStrategy">OPTIONAL strategy to use when no record(s) are found.  DEFAULT is to return an empty collection.</param>
        /// <param name="orderRecordsBy">OPTIONAL value that specifies how to order the resulting records.  DEFAULT is ascending by internal record identifier.</param>
        /// <param name="deprecatedIdTypes">OPTIONAL object types used in a record that indicates an identifier deprecation.  DEFAULT is no deprecated types specified.  Please see notes in the constructor of <see cref="RecordFilter"/> for <see cref="RecordFilter.DeprecatedIdTypes"/> for how deprecation works.</param>
        /// <returns>The matching stream record(s) metadata.</returns>
        public static IReadOnlyList<StreamRecordMetadata> GetAllRecordsMetadata(
            this IGetAllRecordsMetadata protocol,
            TypeRepresentation identifierType = null,
            TypeRepresentation objectType = null,
            VersionMatchStrategy versionMatchStrategy = VersionMatchStrategy.Any,
            IReadOnlyCollection<NamedValue<string>> tagsToMatch = null,
            TagMatchStrategy tagMatchStrategy = TagMatchStrategy.RecordContainsAllQueryTags,
            RecordNotFoundStrategy recordNotFoundStrategy = RecordNotFoundStrategy.ReturnDefault,
            OrderRecordsBy orderRecordsBy = OrderRecordsBy.InternalRecordIdAscending,
            IReadOnlyCollection<TypeRepresentation> deprecatedIdTypes = null)
        {
            protocol.MustForArg(nameof(protocol)).NotBeNull();

            var operation = new GetAllRecordsMetadataOp(identifierType, objectType, versionMatchStrategy, tagsToMatch, tagMatchStrategy, recordNotFoundStrategy, orderRecordsBy, deprecatedIdTypes);
            var result = protocol.Execute(operation);
            return result;
        }

        /// <summary>
        /// Gets all record metadata with provided identifier.
        /// </summary>
        /// <param name="protocol">The protocol.</param>
        /// <param name="identifierType">OPTIONAL type of the identifier to filter on.  DEFAULT is no filter.</param>
        /// <param name="objectType">OPTIONAL type of the object to filter on.  DEFAULT is no filter.</param>
        /// <param name="versionMatchStrategy">OPTIONAL strategy to use to filter on the version of the queried types that are applicable to this operation (e.g. object type, object's identifier type).  DEFAULT is no filter (any version is acceptable).</param>
        /// <param name="tagsToMatch">OPTIONAL tags to match.  DEFAULT is no matching on tags.</param>
        /// <param name="tagMatchStrategy">OPTIONAL strategy to use for comparing tags.  DEFAULT is to match when a record contains all of the queried tags (with extra tags on the record ignored), when <paramref name="tagsToMatch"/> is specified.</param>
        /// <param name="recordNotFoundStrategy">OPTIONAL strategy to use when no record(s) are found.  DEFAULT is to return an empty collection.</param>
        /// <param name="orderRecordsBy">OPTIONAL value that specifies how to order the resulting records.  DEFAULT is ascending by internal record identifier.</param>
        /// <param name="deprecatedIdTypes">OPTIONAL object types used in a record that indicates an identifier deprecation.  DEFAULT is no deprecated types specified.  Please see notes in the constructor of <see cref="RecordFilter"/> for <see cref="RecordFilter.DeprecatedIdTypes"/> for how deprecation works.</param>
        /// <returns>The matching stream record(s) metadata.</returns>
        public static async Task<IReadOnlyList<StreamRecordMetadata>> GetAllRecordsMetadataAsync(
            this IGetAllRecordsMetadata protocol,
            TypeRepresentation identifierType = null,
            TypeRepresentation objectType = null,
            VersionMatchStrategy versionMatchStrategy = VersionMatchStrategy.Any,
            IReadOnlyCollection<NamedValue<string>> tagsToMatch = null,
            TagMatchStrategy tagMatchStrategy = TagMatchStrategy.RecordContainsAllQueryTags,
            RecordNotFoundStrategy recordNotFoundStrategy = RecordNotFoundStrategy.ReturnDefault,
            OrderRecordsBy orderRecordsBy = OrderRecordsBy.InternalRecordIdAscending,
            IReadOnlyCollection<TypeRepresentation> deprecatedIdTypes = null)
        {
            protocol.MustForArg(nameof(protocol)).NotBeNull();

            var operation = new GetAllRecordsMetadataOp(identifierType, objectType, versionMatchStrategy, tagsToMatch, tagMatchStrategy, recordNotFoundStrategy, orderRecordsBy, deprecatedIdTypes);
            var result = await protocol.ExecuteAsync(operation);
            return result;
        }
    }
}
