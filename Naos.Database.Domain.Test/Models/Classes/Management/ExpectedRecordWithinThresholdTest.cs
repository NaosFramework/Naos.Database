﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExpectedRecordWithinThresholdTest.cs" company="Naos Project">
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
    public static partial class ExpectedRecordWithinThresholdTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ExpectedRecordWithinThresholdTest()
        {
            ConstructorArgumentValidationTestScenarios
               .AddScenario(
                    () =>
                        new ConstructorArgumentValidationTestScenario<ExpectedRecordWithinThreshold>
                        {
                            Name = "constructor should throw ArgumentOutOfRangeException when parameter 'threshold' is less than TimeSpan.Zero scenario",
                            ConstructionFunc = () =>
                                               {
                                                   var referenceObject = A.Dummy<ExpectedRecordWithinThreshold>();

                                                   var result = new ExpectedRecordWithinThreshold(
                                                       referenceObject.Id,
                                                       referenceObject.RecordFilter,
                                                       TimeSpan.FromMinutes(1).Subtract(TimeSpan.FromMinutes(5)));

                                                   return result;
                                               },
                            ExpectedExceptionType = typeof(ArgumentOutOfRangeException),
                            ExpectedExceptionMessageContains = new[]
                                                               {
                                                                   "threshold",
                                                               },
                        });
        }
    }
}