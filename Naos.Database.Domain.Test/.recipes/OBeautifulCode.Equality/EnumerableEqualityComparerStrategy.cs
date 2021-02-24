﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumerableEqualityComparerStrategy.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.Equality.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Equality.Recipes
{
    using global::System.Collections.Generic;

    /// <summary>
    /// Determines the strategy to use when comparing two <see cref="IEnumerable{T}"/> for equality.
    /// </summary>
#if !OBeautifulCodeEqualitySolution
    [global::System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.Equality.Recipes", "See package version number")]
    internal
#else
    public
#endif
    enum EnumerableEqualityComparerStrategy
    {
        /// <summary>
        /// Use <see cref="EqualityExtensions.IsSequenceEqualTo{TSource}"/>.
        /// </summary>
        SequenceEqual,

        /// <summary>
        /// Use <see cref="EqualityExtensions.IsUnorderedEqualTo{TSource}"/>.
        /// </summary>
        UnorderedEqual,
    }
}
