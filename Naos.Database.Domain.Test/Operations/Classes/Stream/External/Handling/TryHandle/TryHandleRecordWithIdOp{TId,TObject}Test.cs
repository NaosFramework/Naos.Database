﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TryHandleRecordWithIdOp{TId,TObject}Test.cs" company="Naos Project">
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
    using OBeautifulCode.Math.Recipes;
    using OBeautifulCode.Type;
    using Xunit;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class TryHandleRecordWithIdOpTIdTObjectTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static TryHandleRecordWithIdOpTIdTObjectTest()
        {
            ConstructorArgumentValidationTestScenarios
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<TryHandleRecordWithIdOp<Version, Version>>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'concern' is reserved scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<TryHandleRecordWithIdOp<Version, Version>>();

                            var result = new TryHandleRecordWithIdOp<Version, Version>(
                                Concerns.StreamHandlingDisabledConcern,
                                referenceObject.VersionMatchStrategy,
                                referenceObject.TagsToMatch,
                                referenceObject.TagMatchStrategy,
                                referenceObject.OrderRecordsBy,
                                referenceObject.Tags,
                                referenceObject.Details,
                                referenceObject.MinimumInternalRecordId,
                                referenceObject.InheritRecordTags);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "concern", "is reserved for internal use and may not be used", },
                    });
        }
    }
}