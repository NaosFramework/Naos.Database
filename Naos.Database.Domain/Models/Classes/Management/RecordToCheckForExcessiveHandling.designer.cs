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
    public partial class RecordToCheckForExcessiveHandling : IModel<RecordToCheckForExcessiveHandling>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="RecordToCheckForExcessiveHandling"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(RecordToCheckForExcessiveHandling left, RecordToCheckForExcessiveHandling right)
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
        /// Determines whether two objects of type <see cref="RecordToCheckForExcessiveHandling"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(RecordToCheckForExcessiveHandling left, RecordToCheckForExcessiveHandling right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(RecordToCheckForExcessiveHandling other)
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
                      && this.Concern.IsEqualTo(other.Concern, StringComparer.Ordinal)
                      && this.RecordFilter.IsEqualTo(other.RecordFilter)
                      && this.HandlingFilter.IsEqualTo(other.HandlingFilter)
                      && this.Threshold.IsEqualTo(other.Threshold);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as RecordToCheckForExcessiveHandling);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.Id)
            .Hash(this.Concern)
            .Hash(this.RecordFilter)
            .Hash(this.HandlingFilter)
            .Hash(this.Threshold)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public RecordToCheckForExcessiveHandling DeepClone()
        {
            var result = new RecordToCheckForExcessiveHandling(
                                 this.Id?.DeepClone(),
                                 this.Concern?.DeepClone(),
                                 this.RecordFilter?.DeepClone(),
                                 this.HandlingFilter?.DeepClone(),
                                 this.Threshold.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Id" />.
        /// </summary>
        /// <param name="id">The new <see cref="Id" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="RecordToCheckForExcessiveHandling" /> using the specified <paramref name="id" /> for <see cref="Id" /> and a deep clone of every other property.</returns>
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
        public RecordToCheckForExcessiveHandling DeepCloneWithId(string id)
        {
            var result = new RecordToCheckForExcessiveHandling(
                                 id,
                                 this.Concern?.DeepClone(),
                                 this.RecordFilter?.DeepClone(),
                                 this.HandlingFilter?.DeepClone(),
                                 this.Threshold.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Concern" />.
        /// </summary>
        /// <param name="concern">The new <see cref="Concern" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="RecordToCheckForExcessiveHandling" /> using the specified <paramref name="concern" /> for <see cref="Concern" /> and a deep clone of every other property.</returns>
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
        public RecordToCheckForExcessiveHandling DeepCloneWithConcern(string concern)
        {
            var result = new RecordToCheckForExcessiveHandling(
                                 this.Id?.DeepClone(),
                                 concern,
                                 this.RecordFilter?.DeepClone(),
                                 this.HandlingFilter?.DeepClone(),
                                 this.Threshold.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="RecordFilter" />.
        /// </summary>
        /// <param name="recordFilter">The new <see cref="RecordFilter" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="RecordToCheckForExcessiveHandling" /> using the specified <paramref name="recordFilter" /> for <see cref="RecordFilter" /> and a deep clone of every other property.</returns>
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
        public RecordToCheckForExcessiveHandling DeepCloneWithRecordFilter(RecordFilter recordFilter)
        {
            var result = new RecordToCheckForExcessiveHandling(
                                 this.Id?.DeepClone(),
                                 this.Concern?.DeepClone(),
                                 recordFilter,
                                 this.HandlingFilter?.DeepClone(),
                                 this.Threshold.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="HandlingFilter" />.
        /// </summary>
        /// <param name="handlingFilter">The new <see cref="HandlingFilter" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="RecordToCheckForExcessiveHandling" /> using the specified <paramref name="handlingFilter" /> for <see cref="HandlingFilter" /> and a deep clone of every other property.</returns>
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
        public RecordToCheckForExcessiveHandling DeepCloneWithHandlingFilter(HandlingFilter handlingFilter)
        {
            var result = new RecordToCheckForExcessiveHandling(
                                 this.Id?.DeepClone(),
                                 this.Concern?.DeepClone(),
                                 this.RecordFilter?.DeepClone(),
                                 handlingFilter,
                                 this.Threshold.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Threshold" />.
        /// </summary>
        /// <param name="threshold">The new <see cref="Threshold" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="RecordToCheckForExcessiveHandling" /> using the specified <paramref name="threshold" /> for <see cref="Threshold" /> and a deep clone of every other property.</returns>
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
        public RecordToCheckForExcessiveHandling DeepCloneWithThreshold(int threshold)
        {
            var result = new RecordToCheckForExcessiveHandling(
                                 this.Id?.DeepClone(),
                                 this.Concern?.DeepClone(),
                                 this.RecordFilter?.DeepClone(),
                                 this.HandlingFilter?.DeepClone(),
                                 threshold);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.RecordToCheckForExcessiveHandling: Id = {this.Id?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Concern = {this.Concern?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, RecordFilter = {this.RecordFilter?.ToString() ?? "<null>"}, HandlingFilter = {this.HandlingFilter?.ToString() ?? "<null>"}, Threshold = {this.Threshold.ToString(CultureInfo.InvariantCulture) ?? "<null>"}.");

            return result;
        }
    }
}