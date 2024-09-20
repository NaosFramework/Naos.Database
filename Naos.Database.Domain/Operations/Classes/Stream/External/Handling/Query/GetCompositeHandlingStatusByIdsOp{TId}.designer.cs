﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.189.0)
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
    public partial class GetCompositeHandlingStatusByIdsOp<TId> : IModel<GetCompositeHandlingStatusByIdsOp<TId>>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="GetCompositeHandlingStatusByIdsOp{TId}"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(GetCompositeHandlingStatusByIdsOp<TId> left, GetCompositeHandlingStatusByIdsOp<TId> right)
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
        /// Determines whether two objects of type <see cref="GetCompositeHandlingStatusByIdsOp{TId}"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(GetCompositeHandlingStatusByIdsOp<TId> left, GetCompositeHandlingStatusByIdsOp<TId> right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(GetCompositeHandlingStatusByIdsOp<TId> other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.Concern.IsEqualTo(other.Concern, StringComparer.Ordinal)
                      && this.IdsToMatch.IsEqualTo(other.IdsToMatch)
                      && this.VersionMatchStrategy.IsEqualTo(other.VersionMatchStrategy)
                      && this.TypeSelectionStrategy.IsEqualTo(other.TypeSelectionStrategy);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as GetCompositeHandlingStatusByIdsOp<TId>);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.Concern)
            .Hash(this.IdsToMatch)
            .Hash(this.VersionMatchStrategy)
            .Hash(this.TypeSelectionStrategy)
            .Value;

        /// <inheritdoc />
        public new GetCompositeHandlingStatusByIdsOp<TId> DeepClone() => (GetCompositeHandlingStatusByIdsOp<TId>)this.DeepCloneInternal();

        /// <summary>
        /// Deep clones this object with a new <see cref="Concern" />.
        /// </summary>
        /// <param name="concern">The new <see cref="Concern" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetCompositeHandlingStatusByIdsOp{TId}" /> using the specified <paramref name="concern" /> for <see cref="Concern" /> and a deep clone of every other property.</returns>
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
        public GetCompositeHandlingStatusByIdsOp<TId> DeepCloneWithConcern(string concern)
        {
            var result = new GetCompositeHandlingStatusByIdsOp<TId>(
                                 concern,
                                 this.IdsToMatch?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone(),
                                 this.TypeSelectionStrategy.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="IdsToMatch" />.
        /// </summary>
        /// <param name="idsToMatch">The new <see cref="IdsToMatch" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetCompositeHandlingStatusByIdsOp{TId}" /> using the specified <paramref name="idsToMatch" /> for <see cref="IdsToMatch" /> and a deep clone of every other property.</returns>
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
        public GetCompositeHandlingStatusByIdsOp<TId> DeepCloneWithIdsToMatch(IReadOnlyCollection<TId> idsToMatch)
        {
            var result = new GetCompositeHandlingStatusByIdsOp<TId>(
                                 this.Concern?.DeepClone(),
                                 idsToMatch,
                                 this.VersionMatchStrategy.DeepClone(),
                                 this.TypeSelectionStrategy.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="VersionMatchStrategy" />.
        /// </summary>
        /// <param name="versionMatchStrategy">The new <see cref="VersionMatchStrategy" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetCompositeHandlingStatusByIdsOp{TId}" /> using the specified <paramref name="versionMatchStrategy" /> for <see cref="VersionMatchStrategy" /> and a deep clone of every other property.</returns>
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
        public GetCompositeHandlingStatusByIdsOp<TId> DeepCloneWithVersionMatchStrategy(VersionMatchStrategy versionMatchStrategy)
        {
            var result = new GetCompositeHandlingStatusByIdsOp<TId>(
                                 this.Concern?.DeepClone(),
                                 this.IdsToMatch?.DeepClone(),
                                 versionMatchStrategy,
                                 this.TypeSelectionStrategy.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="TypeSelectionStrategy" />.
        /// </summary>
        /// <param name="typeSelectionStrategy">The new <see cref="TypeSelectionStrategy" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetCompositeHandlingStatusByIdsOp{TId}" /> using the specified <paramref name="typeSelectionStrategy" /> for <see cref="TypeSelectionStrategy" /> and a deep clone of every other property.</returns>
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
        public GetCompositeHandlingStatusByIdsOp<TId> DeepCloneWithTypeSelectionStrategy(TypeSelectionStrategy typeSelectionStrategy)
        {
            var result = new GetCompositeHandlingStatusByIdsOp<TId>(
                                 this.Concern?.DeepClone(),
                                 this.IdsToMatch?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone(),
                                 typeSelectionStrategy);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        protected override OperationBase DeepCloneInternal()
        {
            var result = new GetCompositeHandlingStatusByIdsOp<TId>(
                                 this.Concern?.DeepClone(),
                                 this.IdsToMatch?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone(),
                                 this.TypeSelectionStrategy.DeepClone());

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.{this.GetType().ToStringReadable()}: Concern = {this.Concern?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, IdsToMatch = {this.IdsToMatch?.ToString() ?? "<null>"}, VersionMatchStrategy = {this.VersionMatchStrategy.ToString() ?? "<null>"}, TypeSelectionStrategy = {this.TypeSelectionStrategy.ToString() ?? "<null>"}.");

            return result;
        }
    }
}