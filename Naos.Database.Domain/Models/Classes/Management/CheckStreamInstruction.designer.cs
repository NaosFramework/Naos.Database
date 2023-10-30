﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.181.0)
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
    public partial class CheckStreamInstruction : IModel<CheckStreamInstruction>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="CheckStreamInstruction"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(CheckStreamInstruction left, CheckStreamInstruction right)
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
        /// Determines whether two objects of type <see cref="CheckStreamInstruction"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(CheckStreamInstruction left, CheckStreamInstruction right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(CheckStreamInstruction other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.ExpectedRecordsWithinThreshold.IsEqualTo(other.ExpectedRecordsWithinThreshold)
                      && this.RecordsExpectedToBeHandled.IsEqualTo(other.RecordsExpectedToBeHandled);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as CheckStreamInstruction);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ExpectedRecordsWithinThreshold)
            .Hash(this.RecordsExpectedToBeHandled)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public CheckStreamInstruction DeepClone()
        {
            var result = new CheckStreamInstruction(
                                 this.ExpectedRecordsWithinThreshold?.DeepClone(),
                                 this.RecordsExpectedToBeHandled?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ExpectedRecordsWithinThreshold" />.
        /// </summary>
        /// <param name="expectedRecordsWithinThreshold">The new <see cref="ExpectedRecordsWithinThreshold" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CheckStreamInstruction" /> using the specified <paramref name="expectedRecordsWithinThreshold" /> for <see cref="ExpectedRecordsWithinThreshold" /> and a deep clone of every other property.</returns>
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
        public CheckStreamInstruction DeepCloneWithExpectedRecordsWithinThreshold(IReadOnlyCollection<ExpectedRecordWithinThreshold> expectedRecordsWithinThreshold)
        {
            var result = new CheckStreamInstruction(
                                 expectedRecordsWithinThreshold,
                                 this.RecordsExpectedToBeHandled?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="RecordsExpectedToBeHandled" />.
        /// </summary>
        /// <param name="recordsExpectedToBeHandled">The new <see cref="RecordsExpectedToBeHandled" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CheckStreamInstruction" /> using the specified <paramref name="recordsExpectedToBeHandled" /> for <see cref="RecordsExpectedToBeHandled" /> and a deep clone of every other property.</returns>
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
        public CheckStreamInstruction DeepCloneWithRecordsExpectedToBeHandled(IReadOnlyCollection<RecordExpectedToBeHandled> recordsExpectedToBeHandled)
        {
            var result = new CheckStreamInstruction(
                                 this.ExpectedRecordsWithinThreshold?.DeepClone(),
                                 recordsExpectedToBeHandled);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.CheckStreamInstruction: ExpectedRecordsWithinThreshold = {this.ExpectedRecordsWithinThreshold?.ToString() ?? "<null>"}, RecordsExpectedToBeHandled = {this.RecordsExpectedToBeHandled?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}