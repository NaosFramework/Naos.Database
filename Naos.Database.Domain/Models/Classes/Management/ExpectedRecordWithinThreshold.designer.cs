﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.191.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Globalization;
    using global::System.Linq;

    using global::OBeautifulCode.Cloning.Recipes;
    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class ExpectedRecordWithinThreshold : IModel<ExpectedRecordWithinThreshold>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ExpectedRecordWithinThreshold"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ExpectedRecordWithinThreshold left, ExpectedRecordWithinThreshold right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = left.Equals(right);

            return result;
        }

        /// <summary>
        /// Determines whether two objects of type <see cref="ExpectedRecordWithinThreshold"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ExpectedRecordWithinThreshold left, ExpectedRecordWithinThreshold right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ExpectedRecordWithinThreshold other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.Id.IsEqualTo(other.Id, StringComparer.Ordinal)
                      && this.RecordFilter.IsEqualTo(other.RecordFilter)
                      && this.Threshold.IsEqualTo(other.Threshold)
                      && this.SkipWhenStreamHandlingIsDisabled.IsEqualTo(other.SkipWhenStreamHandlingIsDisabled);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as ExpectedRecordWithinThreshold);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.Id)
            .Hash(this.RecordFilter)
            .Hash(this.Threshold)
            .Hash(this.SkipWhenStreamHandlingIsDisabled)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public ExpectedRecordWithinThreshold DeepClone()
        {
            var result = new ExpectedRecordWithinThreshold(
                                 this.Id?.DeepClone(),
                                 this.RecordFilter?.DeepClone(),
                                 this.Threshold.DeepClone(),
                                 this.SkipWhenStreamHandlingIsDisabled.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Id" />.
        /// </summary>
        /// <param name="id">The new <see cref="Id" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ExpectedRecordWithinThreshold" /> using the specified <paramref name="id" /> for <see cref="Id" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public ExpectedRecordWithinThreshold DeepCloneWithId(string id)
        {
            var result = new ExpectedRecordWithinThreshold(
                                 id,
                                 this.RecordFilter?.DeepClone(),
                                 this.Threshold.DeepClone(),
                                 this.SkipWhenStreamHandlingIsDisabled.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="RecordFilter" />.
        /// </summary>
        /// <param name="recordFilter">The new <see cref="RecordFilter" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ExpectedRecordWithinThreshold" /> using the specified <paramref name="recordFilter" /> for <see cref="RecordFilter" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public ExpectedRecordWithinThreshold DeepCloneWithRecordFilter(RecordFilter recordFilter)
        {
            var result = new ExpectedRecordWithinThreshold(
                                 this.Id?.DeepClone(),
                                 recordFilter,
                                 this.Threshold.DeepClone(),
                                 this.SkipWhenStreamHandlingIsDisabled.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Threshold" />.
        /// </summary>
        /// <param name="threshold">The new <see cref="Threshold" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ExpectedRecordWithinThreshold" /> using the specified <paramref name="threshold" /> for <see cref="Threshold" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public ExpectedRecordWithinThreshold DeepCloneWithThreshold(TimeSpan threshold)
        {
            var result = new ExpectedRecordWithinThreshold(
                                 this.Id?.DeepClone(),
                                 this.RecordFilter?.DeepClone(),
                                 threshold,
                                 this.SkipWhenStreamHandlingIsDisabled.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="SkipWhenStreamHandlingIsDisabled" />.
        /// </summary>
        /// <param name="skipWhenStreamHandlingIsDisabled">The new <see cref="SkipWhenStreamHandlingIsDisabled" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ExpectedRecordWithinThreshold" /> using the specified <paramref name="skipWhenStreamHandlingIsDisabled" /> for <see cref="SkipWhenStreamHandlingIsDisabled" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public ExpectedRecordWithinThreshold DeepCloneWithSkipWhenStreamHandlingIsDisabled(bool skipWhenStreamHandlingIsDisabled)
        {
            var result = new ExpectedRecordWithinThreshold(
                                 this.Id?.DeepClone(),
                                 this.RecordFilter?.DeepClone(),
                                 this.Threshold.DeepClone(),
                                 skipWhenStreamHandlingIsDisabled);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.ExpectedRecordWithinThreshold: Id = {this.Id?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, RecordFilter = {this.RecordFilter?.ToString() ?? "<null>"}, Threshold = {this.Threshold.ToString() ?? "<null>"}, SkipWhenStreamHandlingIsDisabled = {this.SkipWhenStreamHandlingIsDisabled.ToString(CultureInfo.InvariantCulture) ?? "<null>"}.");

            return result;
        }
    }
}