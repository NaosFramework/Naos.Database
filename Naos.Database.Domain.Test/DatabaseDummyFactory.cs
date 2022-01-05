﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DatabaseDummyFactory.cs" company="Naos Project">
//     Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FakeItEasy;
    using Naos.CodeAnalysis.Recipes;
    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.Math.Recipes;
    using OBeautifulCode.Serialization;
    using OBeautifulCode.Type;

    /// <summary>
    /// A Dummy Factory for types in <see cref="Domain" />.
    /// Implements the <see cref="DefaultDatabaseDummyFactory" />.
    /// </summary>
    /// <seealso cref="DefaultDatabaseDummyFactory" />
#if !NaosDatabaseSolution
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("Naos.Database.Domain.Test", "See package version number")]
    internal
#else
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = NaosSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public
#endif
    class DatabaseDummyFactory : DefaultDatabaseDummyFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseDummyFactory" /> class.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = NaosSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        public DatabaseDummyFactory()
        {
            // ------------------------------- EVENTS -------------------------------------
            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new HandlingForStreamDisabledEvent(
                    A.Dummy<UtcDateTime>(),
                    A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new HandlingForStreamEnabledEvent(
                    A.Dummy<UtcDateTime>(),
                    A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new HandlingForRecordDisabledEvent(
                    A.Dummy<long>(),
                    A.Dummy<string>(),
                    A.Dummy<UtcDateTime>(),
                    A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var record = A.Dummy<StreamRecord>();

                    return new RecordHandlingAvailableEvent(
                        record.InternalRecordId,
                        A.Dummy<string>(),
                        record,
                        A.Dummy<UtcDateTime>(),
                        A.Dummy<string>());
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new RecordHandlingCanceledEvent(
                    A.Dummy<long>(),
                    A.Dummy<string>(),
                    A.Dummy<UtcDateTime>(),
                    A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new RecordHandlingCompletedEvent(
                    A.Dummy<long>(),
                    A.Dummy<string>(),
                    A.Dummy<UtcDateTime>(),
                    A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new RecordHandlingFailedEvent(
                    A.Dummy<long>(),
                    A.Dummy<string>(),
                    A.Dummy<UtcDateTime>(),
                    A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new RecordHandlingFailureResetEvent(
                    A.Dummy<long>(),
                    A.Dummy<string>(),
                    A.Dummy<UtcDateTime>(),
                    A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new RecordHandlingRunningEvent(
                    A.Dummy<long>(),
                    A.Dummy<string>(),
                    A.Dummy<UtcDateTime>(),
                    A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new RecordHandlingSelfCanceledEvent(
                    A.Dummy<long>(),
                    A.Dummy<string>(),
                    A.Dummy<UtcDateTime>(),
                    A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new PruneOperationExecutedEvent(
                    A.Dummy<IPruneOp>(),
                    A.Dummy<PruneSummary>(),
                    A.Dummy<UtcDateTime>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new PruneOperationRequestedEvent(
                    A.Dummy<IPruneOp>(),
                    A.Dummy<UtcDateTime>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new PruneRequestCanceledEvent(
                    A.Dummy<string>(),
                    A.Dummy<UtcDateTime>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new UniqueLongIssuedEvent(
                    A.Dummy<long>(),
                    A.Dummy<UtcDateTime>(),
                    A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var result = new IdDeprecatedEvent(
                        A.Dummy<UtcDateTime>(),
                        A.Dummy<string>());

                    return result;
                });

            // ------------------------------- MODELS -------------------------------------
            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new StreamRecordHandlingEntryMetadata(
                    A.Dummy<long>(),
                    A.Dummy<string>(),
                    A.Dummy<HandlingStatus>(),
                    A.Dummy<string>(),
                    A.Dummy<SerializerRepresentation>(),
                    A.Dummy<TypeRepresentationWithAndWithoutVersion>(),
                    A.Dummy<TypeRepresentationWithAndWithoutVersion>(),
                    A.Dummy<IReadOnlyCollection<NamedValue<string>>>(),
                    A.Dummy<UtcDateTime>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var scenario = ThreadSafeRandom.Next(1, 4);

                    switch (scenario)
                    {
                        case 1:
                            return new CreateStreamResult(false, true);
                        case 2:
                            return new CreateStreamResult(true, false);
                        case 3:
                            return new CreateStreamResult(true, true);
                        default:
                            throw new NotSupportedException(
                                FormattableString.Invariant($"Invalid scenario {scenario} for creating a dummy {nameof(CreateStreamResult)}."));
                    }
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new StreamRecordMetadata(
                    A.Dummy<string>(),
                    A.Dummy<SerializerRepresentation>(),
                    A.Dummy<TypeRepresentationWithAndWithoutVersion>(),
                    A.Dummy<TypeRepresentationWithAndWithoutVersion>(),
                    A.Dummy<IReadOnlyCollection<NamedValue<string>>>(),
                    A.Dummy<UtcDateTime>(),
                    A.Dummy<UtcDateTime>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new StreamRecordMetadata<Version>(
                    A.Dummy<Version>(),
                    A.Dummy<SerializerRepresentation>(),
                    A.Dummy<TypeRepresentationWithAndWithoutVersion>(),
                    A.Dummy<TypeRepresentationWithAndWithoutVersion>(),
                    A.Dummy<IReadOnlyCollection<NamedValue<string>>>(),
                    A.Dummy<UtcDateTime>(),
                    A.Dummy<UtcDateTime>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new GetStreamFromRepresentationOp<FileStreamRepresentation, MemoryStandardStream>(
                    A.Dummy<FileStreamRepresentation>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var scenario = ThreadSafeRandom.Next(1, 5);

                    switch (scenario)
                    {
                        case 1:
                            return new PutRecordResult(A.Dummy<long>(), null);
                        case 2:
                            return new PutRecordResult(null, Some.ReadOnlyDummies<long>().ToList());
                        case 3:
                            return new PutRecordResult(null, Some.ReadOnlyDummies<long>().ToList(), Some.ReadOnlyDummies<long>().ToList());
                        case 4:
                            return new PutRecordResult(A.Dummy<long>(), Some.ReadOnlyDummies<long>().ToList(), Some.ReadOnlyDummies<long>().ToList());
                        default:
                            throw new NotSupportedException(FormattableString.Invariant($"Invalid scenario {scenario} for creating a dummy {nameof(PutRecordResult)}."));
                    }
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var scenario = ThreadSafeRandom.Next(1, 4);

                    switch (scenario)
                    {
                        case 1:
                            return new TryHandleRecordResult(null, false);
                        case 2:
                            return new TryHandleRecordResult(A.Dummy<StreamRecord>(), false);
                        case 3:
                            return new TryHandleRecordResult(null, true);
                        default:
                            throw new NotSupportedException(FormattableString.Invariant($"Invalid scenario {scenario} for creating a dummy {nameof(TryHandleRecordResult)}."));
                    }
                });

            // ------------------------------- ENUMS --------------------------------------
            AutoFixtureBackedDummyFactory.ConstrainDummyToBeOneOf(VersionMatchStrategy.Any, VersionMatchStrategy.SpecifiedVersion);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(CompositeHandlingStatus.Unknown);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(ExistingRecordStrategy.Unknown);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(ExistingStreamStrategy.Unknown);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(HandlingStatus.Unknown);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(OrderRecordsBy.Unknown);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(RecordNotFoundStrategy.Unknown);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(StreamNotFoundStrategy.Unknown);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(StreamRecordItemsToInclude.Unknown);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(TagMatchStrategy.Unknown);

            // ------------------------------- MODEL INTERFACES --------------------------------------
            AutoFixtureBackedDummyFactory.UseRandomInterfaceImplementationForDummy<IResourceLocator>();
            AutoFixtureBackedDummyFactory.UseRandomInterfaceImplementationForDummy<IStreamRepresentation>();

            // ------------------------------- OPERATIONS -------------------------------------
            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new PruneBeforeInternalRecordDateOp(
                    A.Dummy<UtcDateTime>(),
                    A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new StandardPruneStreamOp(
                    A.Dummy<long>(),
                    A.Dummy<UtcDateTime>(),
                    A.Dummy<string>(),
                    A.Dummy<IResourceLocator>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new StandardUpdateHandlingStatusForRecordOp(
                    A.Dummy<long>(),
                    A.Dummy<string>(),
                    A.Dummy<HandlingStatus>().ThatIsNot(HandlingStatus.DisabledForStream),
                    Some.ReadOnlyDummies<HandlingStatus>().ToList(),
                    A.Dummy<string>(),
                    Some.ReadOnlyDummies<NamedValue<string>>().ToList(),
                    A.Dummy<bool>(),
                    A.Dummy<IResourceLocator>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new StandardUpdateHandlingStatusForStreamOp(
                    A.Dummy<HandlingStatus>().ThatIsIn(new[] { HandlingStatus.DisabledForStream, HandlingStatus.AvailableByDefault }),
                    A.Dummy<string>(),
                    Some.ReadOnlyDummies<NamedValue<string>>().ToList(),
                    A.Dummy<IResourceLocator>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var existingRecordStrategy = A.Dummy<ExistingRecordStrategy>();

                    var result = new PutAndReturnInternalRecordIdOp<Version>(
                        A.Dummy<Version>(),
                        A.Dummy<IReadOnlyCollection<NamedValue<string>>>(),
                        existingRecordStrategy,
                        existingRecordStrategy == ExistingRecordStrategy.PruneIfFoundById || existingRecordStrategy == ExistingRecordStrategy.PruneIfFoundByIdAndType
                            ? (int?)A.Dummy<ZeroOrPositiveInteger>()
                            : null,
                        A.Dummy<VersionMatchStrategy>());

                    return result;
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var existingRecordStrategy = A.Dummy<ExistingRecordStrategy>();

                    var result =  new PutOp<Version>(
                        A.Dummy<Version>(),
                        A.Dummy<IReadOnlyCollection<NamedValue<string>>>(),
                        existingRecordStrategy,
                        existingRecordStrategy == ExistingRecordStrategy.PruneIfFoundById || existingRecordStrategy == ExistingRecordStrategy.PruneIfFoundByIdAndType
                            ? (int?)A.Dummy<ZeroOrPositiveInteger>()
                            : null,
                        A.Dummy<VersionMatchStrategy>());

                    return result;
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var existingRecordStrategy = A.Dummy<ExistingRecordStrategy>();

                    var result =  new PutWithIdAndReturnInternalRecordIdOp<Version, Version>(
                        A.Dummy<Version>(),
                        A.Dummy<Version>(),
                        A.Dummy<IReadOnlyCollection<NamedValue<string>>>(),
                        existingRecordStrategy,
                        existingRecordStrategy == ExistingRecordStrategy.PruneIfFoundById || existingRecordStrategy == ExistingRecordStrategy.PruneIfFoundByIdAndType
                            ? (int?)A.Dummy<ZeroOrPositiveInteger>()
                            : null,
                        A.Dummy<VersionMatchStrategy>());

                    return result;
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var existingRecordStrategy = A.Dummy<ExistingRecordStrategy>();

                    var result = new PutWithIdOp<Version, Version>(
                        A.Dummy<Version>(),
                        A.Dummy<Version>(),
                        A.Dummy<IReadOnlyCollection<NamedValue<string>>>(),
                        existingRecordStrategy,
                        existingRecordStrategy == ExistingRecordStrategy.PruneIfFoundById || existingRecordStrategy == ExistingRecordStrategy.PruneIfFoundByIdAndType
                            ? (int?)A.Dummy<ZeroOrPositiveInteger>()
                            : null,
                        A.Dummy<VersionMatchStrategy>());

                    return result;
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var existingRecordStrategy = A.Dummy<ExistingRecordStrategy>();

                    var result = new StandardPutRecordOp(
                        A.Dummy<StreamRecordMetadata>(),
                        A.Dummy<DescribedSerializationBase>(),
                        existingRecordStrategy,
                        existingRecordStrategy == ExistingRecordStrategy.PruneIfFoundById || existingRecordStrategy == ExistingRecordStrategy.PruneIfFoundByIdAndType
                            ? (int?)A.Dummy<ZeroOrPositiveInteger>()
                            : null,
                        A.Dummy<VersionMatchStrategy>(),
                        A.Dummy<long?>(),
                        A.Dummy<IResourceLocator>());

                    return result;
                });

            // ------------------------------- OPERATION INTERFACES -------------------------------------
            AutoFixtureBackedDummyFactory.UseRandomInterfaceImplementationForDummy<IPruneOp>();
        }
    }
}
