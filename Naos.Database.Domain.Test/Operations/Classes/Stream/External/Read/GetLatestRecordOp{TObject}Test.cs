﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetLatestRecordOp{TObject}Test.cs" company="Naos Project">
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
    using OBeautifulCode.Representation.System;
    using Xunit;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class GetLatestRecordOpTObjectTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static GetLatestRecordOpTObjectTest()
        {
            ConstructorArgumentValidationTestScenarios
               .RemoveAllScenarios()
               .AddScenario(() =>
                   new ConstructorArgumentValidationTestScenario<GetLatestRecordOp<Version>>
                   {
                       Name = "constructor should throw ArgumentOutOfRangeException when parameter 'recordNotFoundStrategy' is RecordNotFoundStrategy.Unknown scenario",
                       ConstructionFunc = () =>
                       {
                           var referenceObject = A.Dummy<GetLatestRecordOp<Version>>();

                           var result = new GetLatestRecordOp<Version>(
                               referenceObject.IdentifierType,
                               referenceObject.VersionMatchStrategy,
                               RecordNotFoundStrategy.Unknown,
                               referenceObject.DeprecatedIdTypes);

                           return result;
                       },
                       ExpectedExceptionType = typeof(ArgumentOutOfRangeException),
                       ExpectedExceptionMessageContains = new[] { "recordNotFoundStrategy", "Unknown" },
                   })
               .AddScenario(() =>
                   new ConstructorArgumentValidationTestScenario<GetLatestRecordOp<Version>>
                   {
                       Name = "constructor should throw ArgumentException when parameter 'deprecatedIdTypes' contains a null element.",
                       ConstructionFunc = () =>
                       {
                           var referenceObject = A.Dummy<GetLatestRecordOp<Version>>();

                           var result = new GetLatestRecordOp<Version>(
                               referenceObject.IdentifierType,
                               referenceObject.VersionMatchStrategy,
                               referenceObject.RecordNotFoundStrategy,
                               new[] { A.Dummy<TypeRepresentation>(), null });

                           return result;
                       },
                       ExpectedExceptionType = typeof(ArgumentException),
                       ExpectedExceptionMessageContains = new[] { "deprecatedIdTypes", "contains at least one null element" },
                   });
        }
    }
}