﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PutOp{TObject}Test.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain.Test
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using FakeItEasy;

    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Math.Recipes;

    using Xunit;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class PutOpTObjectTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static PutOpTObjectTest()
        {
            ConstructorArgumentValidationTestScenarios
               .RemoveAllScenarios()
               .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<PutOp<Version>>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'recordRetentionCount' is null and parameter 'existingRecordStrategy' is a pruning strategy scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<PutOp<Version>>();

                            var result = new PutOp<Version>(
                                                 referenceObject.ObjectToPut,
                                                 referenceObject.Tags,
                                                 A.Dummy<ExistingRecordStrategy>().ThatIs(_ => _.ToString().ToLowerInvariant().Contains("prune")),
                                                 null,
                                                 referenceObject.VersionMatchStrategy);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "Must have a retention count if pruning", },
                    })
               .AddScenario(() =>
                   new ConstructorArgumentValidationTestScenario<PutOp<Version>>
                   {
                       Name = "constructor should throw ArgumentException when parameter 'recordRetentionCount' is not null and parameter 'existingRecordStrategy' is not a pruning strategy scenario",
                       ConstructionFunc = () =>
                       {
                           var referenceObject = A.Dummy<PutOp<Version>>();

                           var result = new PutOp<Version>(
                               referenceObject.ObjectToPut,
                               referenceObject.Tags,
                               A.Dummy<ExistingRecordStrategy>().ThatIs(_ => !_.ToString().ToLowerInvariant().Contains("prune")),
                               A.Dummy<ZeroOrPositiveInteger>(),
                               referenceObject.VersionMatchStrategy);

                           return result;
                       },
                       ExpectedExceptionType = typeof(ArgumentException),
                       ExpectedExceptionMessageContains = new[] { "Cannot have a retention count if not pruning", },
                   })
               .AddScenario(() =>
                   new ConstructorArgumentValidationTestScenario<PutOp<Version>>
                   {
                       Name = "constructor should throw ArgumentOutOfRangeException when parameter 'recordRetentionCount' negative",
                       ConstructionFunc = () =>
                       {
                           var referenceObject = A.Dummy<PutOp<Version>>();

                           var result = new PutOp<Version>(
                               referenceObject.ObjectToPut,
                               referenceObject.Tags,
                               A.Dummy<ExistingRecordStrategy>().ThatIs(_ => _.ToString().ToLowerInvariant().Contains("prune")),
                               A.Dummy<NegativeInteger>(),
                               referenceObject.VersionMatchStrategy);

                           return result;
                       },
                       ExpectedExceptionType = typeof(ArgumentOutOfRangeException),
                       ExpectedExceptionMessageContains = new[] { "recordRetentionCount", },
                   });

            EquatableTestScenarios
                .RemoveAllScenarios()
                .AddScenario(() =>
                    new EquatableTestScenario<PutOp<Version>>
                    {
                        Name = "Default Code Generated Scenario",
                        ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                        ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new PutOp<Version>[]
                        {
                            new PutOp<Version>(
                                    ReferenceObjectForEquatableTestScenarios.ObjectToPut,
                                    ReferenceObjectForEquatableTestScenarios.Tags,
                                    ReferenceObjectForEquatableTestScenarios.ExistingRecordStrategy,
                                    ReferenceObjectForEquatableTestScenarios.RecordRetentionCount,
                                    ReferenceObjectForEquatableTestScenarios.VersionMatchStrategy),
                        },
                        ObjectsThatAreNotEqualToReferenceObject = new PutOp<Version>[]
                        {
                            new PutOp<Version>(
                                    A.Dummy<PutOp<Version>>().Whose(_ => !_.ObjectToPut.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ObjectToPut)).ObjectToPut,
                                    ReferenceObjectForEquatableTestScenarios.Tags,
                                    ReferenceObjectForEquatableTestScenarios.ExistingRecordStrategy,
                                    ReferenceObjectForEquatableTestScenarios.RecordRetentionCount,
                                    ReferenceObjectForEquatableTestScenarios.VersionMatchStrategy),
                            new PutOp<Version>(
                                    ReferenceObjectForEquatableTestScenarios.ObjectToPut,
                                    A.Dummy<PutOp<Version>>().Whose(_ => !_.Tags.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Tags)).Tags,
                                    ReferenceObjectForEquatableTestScenarios.ExistingRecordStrategy,
                                    ReferenceObjectForEquatableTestScenarios.RecordRetentionCount,
                                    ReferenceObjectForEquatableTestScenarios.VersionMatchStrategy),
                            new PutOp<Version>(
                                    ReferenceObjectForEquatableTestScenarios.ObjectToPut,
                                    ReferenceObjectForEquatableTestScenarios.Tags,
                                    ReferenceObjectForEquatableTestScenarios.ExistingRecordStrategy.ToString().ToLowerInvariant().Contains("prune")
                                        ? A.Dummy<PutAndReturnInternalRecordIdOp<Version>>().Whose(_ => _.ToString().ToLowerInvariant().Contains("prune") && !_.ExistingRecordStrategy.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ExistingRecordStrategy)).ExistingRecordStrategy
                                        : A.Dummy<PutAndReturnInternalRecordIdOp<Version>>().Whose(_ => (!_.ToString().ToLowerInvariant().Contains("prune")) && !_.ExistingRecordStrategy.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ExistingRecordStrategy)).ExistingRecordStrategy,
                                    ReferenceObjectForEquatableTestScenarios.RecordRetentionCount,
                                    ReferenceObjectForEquatableTestScenarios.VersionMatchStrategy),
                            // Harder to test because if RecordRetentionCount is null, then ExistingRecordStrategy needs to be tweaked as well
                            ////new PutOp<Version>(
                            ////        ReferenceObjectForEquatableTestScenarios.ObjectToPut,
                            ////        ReferenceObjectForEquatableTestScenarios.Tags,
                            ////        ReferenceObjectForEquatableTestScenarios.ExistingRecordStrategy,
                            ////        A.Dummy<PutOp<Version>>().Whose(_ => !_.RecordRetentionCount.IsEqualTo(ReferenceObjectForEquatableTestScenarios.RecordRetentionCount)).RecordRetentionCount,
                            ////        ReferenceObjectForEquatableTestScenarios.VersionMatchStrategy),
                            new PutOp<Version>(
                                    ReferenceObjectForEquatableTestScenarios.ObjectToPut,
                                    ReferenceObjectForEquatableTestScenarios.Tags,
                                    ReferenceObjectForEquatableTestScenarios.ExistingRecordStrategy,
                                    ReferenceObjectForEquatableTestScenarios.RecordRetentionCount,
                                    A.Dummy<PutOp<Version>>().Whose(_ => !_.VersionMatchStrategy.IsEqualTo(ReferenceObjectForEquatableTestScenarios.VersionMatchStrategy)).VersionMatchStrategy),
                        },
                        ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                        {
                            A.Dummy<object>(),
                            A.Dummy<string>(),
                            A.Dummy<int>(),
                            A.Dummy<int?>(),
                            A.Dummy<Guid>(),
                            A.Dummy<DisableHandlingForStreamOp>(),
                            A.Dummy<EnableHandlingForStreamOp>(),
                            A.Dummy<DisableHandlingForRecordOp>(),
                            A.Dummy<CancelRunningHandleRecordOp>(),
                            A.Dummy<CompleteRunningHandleRecordOp>(),
                            A.Dummy<StandardCreateStreamOp>(),
                            A.Dummy<StandardDeleteStreamOp>(),
                            A.Dummy<DoesAnyExistByIdOp<Version>>(),
                            A.Dummy<FailRunningHandleRecordOp>(),
                            A.Dummy<GetAllRecordsByIdOp<Version>>(),
                            A.Dummy<GetAllRecordsMetadataByIdOp<Version>>(),
                            A.Dummy<GetAllResourceLocatorsOp>(),
                            A.Dummy<GetHandlingHistoryOp>(),
                            A.Dummy<GetHandlingStatusOp>(),
                            A.Dummy<GetCompositeHandlingStatusByIdsOp>(),
                            A.Dummy<GetCompositeHandlingStatusByIdsOp<Version>>(),
                            A.Dummy<GetCompositeHandlingStatusByTagsOp>(),
                            A.Dummy<GetLatestObjectByIdOp<Version, Version>>(),
                            A.Dummy<GetLatestObjectByTagsOp<Version>>(),
                            A.Dummy<GetLatestObjectOp<Version>>(),
                            A.Dummy<GetLatestRecordByIdOp<Version, Version>>(),
                            A.Dummy<GetLatestRecordByIdOp<Version>>(),
                            A.Dummy<GetLatestRecordMetadataByIdOp<Version>>(),
                            A.Dummy<GetLatestRecordOp<Version>>(),
                            A.Dummy<GetNextUniqueLongOp>(),
                            A.Dummy<GetResourceLocatorByIdOp<Version>>(),
                            A.Dummy<GetResourceLocatorForUniqueIdentifierOp>(),
                            A.Dummy<GetStreamFromRepresentationOp>(),
                            A.Dummy<GetStreamFromRepresentationOp<FileStreamRepresentation, MemoryStandardStream>>(),
                            A.Dummy<HandleRecordOp>(),
                            A.Dummy<HandleRecordOp<Version>>(),
                            A.Dummy<HandleRecordWithIdOp<Version, Version>>(),
                            A.Dummy<HandleRecordWithIdOp<Version>>(),
                            A.Dummy<PruneBeforeInternalRecordDateOp>(),
                            A.Dummy<PruneBeforeInternalRecordIdOp>(),
                            A.Dummy<PutAndReturnInternalRecordIdOp<Version>>(),
                            A.Dummy<PutWithIdAndReturnInternalRecordIdOp<Version, Version>>(),
                            A.Dummy<PutWithIdOp<Version, Version>>(),
                            A.Dummy<ResetFailedHandleRecordOp>(),
                            A.Dummy<SelfCancelRunningHandleRecordOp>(),
                            A.Dummy<StandardDoesAnyExistByIdOp>(),
                            A.Dummy<StandardGetAllRecordsByIdOp>(),
                            A.Dummy<StandardGetAllRecordsMetadataByIdOp>(),
                            A.Dummy<StandardGetDistinctStringSerializedIdsOp>(),
                            A.Dummy<StandardGetLatestRecordByIdOp>(),
                            A.Dummy<StandardGetLatestRecordByTagsOp>(),
                            A.Dummy<StandardGetLatestRecordMetadataByIdOp>(),
                            A.Dummy<StandardGetLatestRecordOp>(),
                            A.Dummy<StandardGetNextUniqueLongOp>(),
                            A.Dummy<StandardGetRecordByInternalRecordIdOp>(),
                            A.Dummy<StandardPutRecordOp>(),
                            A.Dummy<ThrowIfResourceUnavailableOp>(),
                            A.Dummy<StandardTryHandleRecordOp>(),
                            A.Dummy<TryHandleRecordOp<Version>>(),
                            A.Dummy<TryHandleRecordWithIdOp<Version, Version>>(),
                            A.Dummy<TryHandleRecordWithIdOp<Version>>(),
                        },
                    });
        }
    }
}