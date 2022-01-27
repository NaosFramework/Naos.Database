﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RecordStandardizeExtensions.Read.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Representation.System;
    using OBeautifulCode.Serialization;

    public static partial class RecordStandardizeExtensions
    {
        /// <summary>
        /// Converts the operation to it's standardized form.
        /// </summary>
        /// <typeparam name="TId">The type of the identifier of the object.</typeparam>
        /// <param name="operation">The operation.</param>
        /// <param name="serializer">The serializer for the identifier.</param>
        /// <param name="specifiedResourceLocator">OPTIONAL locator to use. DEFAULT will assume single locator on stream or throw.</param>
        /// <returns>
        /// The standardized operation.
        /// </returns>
        public static StandardGetInternalRecordIdsOp Standardize<TId>(
            this DoesAnyExistByIdOp<TId> operation,
            IStringSerialize serializer,
            IResourceLocator specifiedResourceLocator = null)
        {
            operation.MustForArg(nameof(operation)).NotBeNull();
            serializer.MustForArg(nameof(serializer)).NotBeNull();

            var serializedObjectId = serializer.SerializeToString(operation.Id);

            var result = new StandardGetInternalRecordIdsOp(
                new RecordFilter(
                    ids: new[]
                         {
                             new StringSerializedIdentifier(
                                 serializedObjectId,
                                 (operation.Id?.GetType() ?? typeof(TId)).ToRepresentation()),
                         },
                    objectTypes: operation.ObjectType == null
                        ? null
                        : new[]
                          {
                              operation.ObjectType,
                          }),
                RecordNotFoundStrategy.ReturnDefault,
                specifiedResourceLocator);

            return result;
        }

        /// <summary>
        /// Converts the operation to it's standardized form.
        /// </summary>
        /// <typeparam name="TId">The type of the identifier of the object.</typeparam>
        /// <typeparam name="TObject">The type of the object.</typeparam>
        /// <param name="operation">The operation.</param>
        /// <param name="serializer">The serializer for the identifier.</param>
        /// <param name="specifiedResourceLocator">OPTIONAL locator to use. DEFAULT will assume single locator on stream or throw.</param>
        /// <returns>
        /// The standardized operation.
        /// </returns>
        public static StandardGetLatestRecordOp Standardize<TId, TObject>(
            this GetLatestObjectByIdOp<TId, TObject> operation,
            IStringSerialize serializer,
            IResourceLocator specifiedResourceLocator = null)
        {
            operation.MustForArg(nameof(operation)).NotBeNull();
            serializer.MustForArg(nameof(serializer)).NotBeNull();

            var serializedObjectId = serializer.SerializeToString(operation.Id);

            var result = new StandardGetLatestRecordOp(
                new RecordFilter(
                    ids: new[]
                         {
                             new StringSerializedIdentifier(
                                 serializedObjectId,
                                 (operation.Id?.GetType() ?? typeof(TId)).ToRepresentation()),
                         },
                    objectTypes: new[]
                                 {
                                     typeof(TObject).ToRepresentation(),
                                 }),
                operation.RecordNotFoundStrategy,
                StreamRecordItemsToInclude.MetadataAndPayload,
                specifiedResourceLocator);

            return result;
        }

        /// <summary>
        /// Converts the operation to it's standardized form.
        /// </summary>
        /// <typeparam name="TObject">The type of the object.</typeparam>
        /// <param name="operation">The operation.</param>
        /// <param name="specifiedResourceLocator">OPTIONAL locator to use. DEFAULT will assume single locator on stream or throw.</param>
        /// <returns>
        /// The standardized operation.
        /// </returns>
        public static StandardGetLatestRecordOp Standardize<TObject>(
            this GetLatestObjectByTagsOp<TObject> operation,
            IResourceLocator specifiedResourceLocator = null)
        {
            operation.MustForArg(nameof(operation)).NotBeNull();

            var result = new StandardGetLatestRecordOp(
                new RecordFilter(
                    objectTypes: new[]
                                 {
                                     typeof(TObject).ToRepresentation(),
                                 },
                    versionMatchStrategy: operation.VersionMatchStrategy,
                    tags: operation.TagsToMatch,
                    tagMatchStrategy: operation.TagMatchStrategy),
                operation.RecordNotFoundStrategy,
                StreamRecordItemsToInclude.MetadataAndPayload,
                specifiedResourceLocator);

            return result;
        }

        /// <summary>
        /// Converts the operation to it's standardized form.
        /// </summary>
        /// <typeparam name="TObject">The type of the object.</typeparam>
        /// <param name="operation">The operation.</param>
        /// <param name="specifiedResourceLocator">OPTIONAL locator to use. DEFAULT will assume single locator on stream or throw.</param>
        /// <returns>
        /// The standardized operation.
        /// </returns>
        public static StandardGetLatestRecordOp Standardize<TObject>(
            this GetLatestObjectOp<TObject> operation,
            IResourceLocator specifiedResourceLocator = null)
        {
            operation.MustForArg(nameof(operation)).NotBeNull();

            var result = new StandardGetLatestRecordOp(
                new RecordFilter(
                    idTypes: operation.IdentifierType == null
                        ? null
                        : new[]
                          {
                              operation.IdentifierType,
                          },
                    objectTypes: new[]
                                 {
                                     typeof(TObject).ToRepresentation(),
                                 },
                    versionMatchStrategy: operation.VersionMatchStrategy),
                operation.RecordNotFoundStrategy,
                StreamRecordItemsToInclude.MetadataAndPayload,
                specifiedResourceLocator);

            return result;
        }

        /// <summary>
        /// Converts the operation to it's standardized form.
        /// </summary>
        /// <typeparam name="TId">The type of the identifier of the object.</typeparam>
        /// <typeparam name="TObject">The type of the object.</typeparam>
        /// <param name="operation">The operation.</param>
        /// <param name="serializer">The serializer for the identifier.</param>
        /// <param name="specifiedResourceLocator">OPTIONAL locator to use. DEFAULT will assume single locator on stream or throw.</param>
        /// <returns>
        /// The standardized operation.
        /// </returns>
        public static StandardGetLatestRecordOp Standardize<TId, TObject>(
            this GetLatestRecordByIdOp<TId, TObject> operation,
            IStringSerialize serializer,
            IResourceLocator specifiedResourceLocator = null)
        {
            operation.MustForArg(nameof(operation)).NotBeNull();
            serializer.MustForArg(nameof(serializer)).NotBeNull();

            var serializedObjectId = serializer.SerializeToString(operation.Id);

            var result = new StandardGetLatestRecordOp(
                new RecordFilter(
                    ids: new[]
                         {
                             new StringSerializedIdentifier(
                                 serializedObjectId,
                                 (operation.Id?.GetType() ?? typeof(TId)).ToRepresentation()),
                         },
                    objectTypes: new[]
                                 {
                                     typeof(TObject).ToRepresentation(),
                                 }),
                operation.RecordNotFoundStrategy,
                StreamRecordItemsToInclude.MetadataAndPayload,
                specifiedResourceLocator);

            return result;
        }

        /// <summary>
        /// Converts the operation to it's standardized form.
        /// </summary>
        /// <typeparam name="TId">The type of the identifier of the object.</typeparam>
        /// <param name="operation">The operation.</param>
        /// <param name="serializer">The serializer for the identifier.</param>
        /// <param name="specifiedResourceLocator">OPTIONAL locator to use. DEFAULT will assume single locator on stream or throw.</param>
        /// <returns>
        /// The standardized operation.
        /// </returns>
        public static StandardGetLatestRecordOp Standardize<TId>(
            this GetLatestRecordByIdOp<TId> operation,
            IStringSerialize serializer,
            IResourceLocator specifiedResourceLocator = null)
        {
            operation.MustForArg(nameof(operation)).NotBeNull();
            serializer.MustForArg(nameof(serializer)).NotBeNull();

            var serializedObjectId = serializer.SerializeToString(operation.Id);

            var result = new StandardGetLatestRecordOp(
                new RecordFilter(
                    ids: new[]
                         {
                             new StringSerializedIdentifier(
                                 serializedObjectId,
                                 (operation.Id?.GetType() ?? typeof(TId)).ToRepresentation()),
                         },
                    objectTypes: operation.ObjectType == null
                        ? null
                        : new[]
                          {
                              operation.ObjectType,
                          }),
                operation.RecordNotFoundStrategy,
                StreamRecordItemsToInclude.MetadataAndPayload,
                specifiedResourceLocator);

            return result;
        }

        /// <summary>
        /// Converts the operation to it's standardized form.
        /// </summary>
        /// <typeparam name="TId">The type of the identifier of the object.</typeparam>
        /// <param name="operation">The operation.</param>
        /// <param name="serializer">The serializer for the identifier.</param>
        /// <param name="specifiedResourceLocator">OPTIONAL locator to use. DEFAULT will assume single locator on stream or throw.</param>
        /// <returns>
        /// The standardized operation.
        /// </returns>
        public static StandardGetLatestRecordOp Standardize<TId>(
            this GetLatestRecordMetadataByIdOp<TId> operation,
            IStringSerialize serializer,
            IResourceLocator specifiedResourceLocator = null)
        {
            operation.MustForArg(nameof(operation)).NotBeNull();
            serializer.MustForArg(nameof(serializer)).NotBeNull();

            var serializedObjectId = serializer.SerializeToString(operation.Id);

            var result = new StandardGetLatestRecordOp(
                new RecordFilter(
                    ids: new[]
                         {
                             new StringSerializedIdentifier(
                                 serializedObjectId,
                                 (operation.Id?.GetType() ?? typeof(TId)).ToRepresentation()),
                         },
                    objectTypes: operation.ObjectType == null
                        ? null
                        : new[]
                          {
                              operation.ObjectType,
                          }),
                operation.RecordNotFoundStrategy,
                StreamRecordItemsToInclude.MetadataOnly,
                specifiedResourceLocator);

            return result;
        }

        /// <summary>
        /// Converts the operation to it's standardized form.
        /// </summary>
        /// <typeparam name="TObject">The type of the object.</typeparam>
        /// <param name="operation">The operation.</param>
        /// <param name="specifiedResourceLocator">OPTIONAL locator to use. DEFAULT will assume single locator on stream or throw.</param>
        /// <returns>
        /// The standardized operation.
        /// </returns>
        public static StandardGetLatestRecordOp Standardize<TObject>(
            this GetLatestRecordOp<TObject> operation,
            IResourceLocator specifiedResourceLocator = null)
        {
            operation.MustForArg(nameof(operation)).NotBeNull();

            var result = new StandardGetLatestRecordOp(
                new RecordFilter(
                    idTypes: operation.IdentifierType == null
                        ? null
                        : new[]
                          {
                              operation.IdentifierType,
                          },
                    objectTypes: new[]
                                 {
                                     typeof(TObject).ToRepresentation(),
                                 },
                    versionMatchStrategy: operation.VersionMatchStrategy),
                operation.RecordNotFoundStrategy,
                StreamRecordItemsToInclude.MetadataAndPayload,
                specifiedResourceLocator);

            return result;
        }

        /// <summary>
        /// Converts the operation to it's standardized form.
        /// </summary>
        /// <typeparam name="TId">The type of the identifier of the object.</typeparam>
        /// <param name="operation">The operation.</param>
        /// <param name="serializer">The serializer for the identifier.</param>
        /// <param name="specifiedResourceLocator">OPTIONAL locator to use. DEFAULT will assume single locator on stream or throw.</param>
        /// <returns>
        /// The standardized operation.
        /// </returns>
        public static StandardGetLatestStringSerializedObjectOp Standardize<TId>(
            this GetLatestStringSerializedObjectByIdOp<TId> operation,
            IStringSerialize serializer,
            IResourceLocator specifiedResourceLocator = null)
        {
            operation.MustForArg(nameof(operation)).NotBeNull();
            serializer.MustForArg(nameof(serializer)).NotBeNull();

            var serializedObjectId = serializer.SerializeToString(operation.Id);

            var result = new StandardGetLatestStringSerializedObjectOp(
                new RecordFilter(
                    ids: new[]
                         {
                             new StringSerializedIdentifier(serializedObjectId, typeof(TId).ToRepresentation()),
                         },
                    objectTypes: operation.ObjectType == null
                        ? null
                        : new[]
                          {
                              operation.ObjectType,
                          },
                    versionMatchStrategy: operation.VersionMatchStrategy),
                operation.RecordNotFoundStrategy,
                specifiedResourceLocator);

            return result;
        }

        /// <summary>
        /// Converts the operation to it's standardized form.
        /// </summary>
        /// <typeparam name="TId">The type of the identifier of the object.</typeparam>
        /// <param name="operation">The operation.</param>
        /// <returns>
        /// The standardized operation.
        /// </returns>
        public static StandardGetDistinctStringSerializedIdsOp Standardize<TId>(
            this GetDistinctIdsOp<TId> operation)
        {
            var result = new StandardGetDistinctStringSerializedIdsOp(new RecordFilter(
                idTypes: new[]
                         {
                             typeof(TId).ToRepresentation(),
                         },
                objectTypes: operation.ObjectTypes,
                versionMatchStrategy: operation.VersionMatchStrategy,
                tags: operation.TagsToMatch,
                tagMatchStrategy: operation.TagMatchStrategy,
                deprecatedIdTypes: operation.DeprecatedIdTypes));

            return result;
        }
    }
}
