﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StandardGetRecordByInternalRecordIdOpTest.cs" company="Naos Project">
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

    using Xunit;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class StandardGetRecordByInternalRecordIdOpTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static StandardGetRecordByInternalRecordIdOpTest()
        {
            ConstructorArgumentValidationTestScenarios
                .RemoveAllScenarios()
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<StandardGetRecordByInternalRecordIdOp>
                    {
                        Name = "constructor should throw ArgumentOutOfRangeException when parameter 'recordNotFoundStrategy' is RecordNotFoundStrategy.Unknown scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<StandardGetRecordByInternalRecordIdOp>();

                            var result = new StandardGetRecordByInternalRecordIdOp(
                                referenceObject.InternalRecordId,
                                RecordNotFoundStrategy.Unknown,
                                referenceObject.StreamRecordItemsToInclude,
                                referenceObject.SpecifiedResourceLocator);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentOutOfRangeException),
                        ExpectedExceptionMessageContains = new[] { "recordNotFoundStrategy", "Unknown" },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<StandardGetRecordByInternalRecordIdOp>
                    {
                        Name = "constructor should throw ArgumentOutOfRangeException when parameter 'streamRecordItemsToInclude' is StreamRecordItemsToInclude.Unknown scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<StandardGetRecordByInternalRecordIdOp>();

                            var result = new StandardGetRecordByInternalRecordIdOp(
                                referenceObject.InternalRecordId,
                                referenceObject.RecordNotFoundStrategy,
                                StreamRecordItemsToInclude.Unknown,
                                referenceObject.SpecifiedResourceLocator);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentOutOfRangeException),
                        ExpectedExceptionMessageContains = new[] { "streamRecordItemsToInclude", "Unknown" },
                    });
        }
    }
}