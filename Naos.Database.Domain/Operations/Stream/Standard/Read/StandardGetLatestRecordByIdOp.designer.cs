﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.171.0)
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
    using global::OBeautifulCode.Representation.System;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class StandardGetLatestRecordByIdOp : IModel<StandardGetLatestRecordByIdOp>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="StandardGetLatestRecordByIdOp"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(StandardGetLatestRecordByIdOp left, StandardGetLatestRecordByIdOp right)
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
        /// Determines whether two objects of type <see cref="StandardGetLatestRecordByIdOp"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(StandardGetLatestRecordByIdOp left, StandardGetLatestRecordByIdOp right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(StandardGetLatestRecordByIdOp other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.StringSerializedId.IsEqualTo(other.StringSerializedId, StringComparer.Ordinal)
                      && this.IdentifierType.IsEqualTo(other.IdentifierType)
                      && this.ObjectType.IsEqualTo(other.ObjectType)
                      && this.VersionMatchStrategy.IsEqualTo(other.VersionMatchStrategy)
                      && this.RecordNotFoundStrategy.IsEqualTo(other.RecordNotFoundStrategy)
                      && this.SpecifiedResourceLocator.IsEqualTo(other.SpecifiedResourceLocator);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as StandardGetLatestRecordByIdOp);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.StringSerializedId)
            .Hash(this.IdentifierType)
            .Hash(this.ObjectType)
            .Hash(this.VersionMatchStrategy)
            .Hash(this.RecordNotFoundStrategy)
            .Hash(this.SpecifiedResourceLocator)
            .Value;

        /// <inheritdoc />
        public new StandardGetLatestRecordByIdOp DeepClone() => (StandardGetLatestRecordByIdOp)this.DeepCloneInternal();

        /// <summary>
        /// Deep clones this object with a new <see cref="StringSerializedId" />.
        /// </summary>
        /// <param name="stringSerializedId">The new <see cref="StringSerializedId" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StandardGetLatestRecordByIdOp" /> using the specified <paramref name="stringSerializedId" /> for <see cref="StringSerializedId" /> and a deep clone of every other property.</returns>
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
        public StandardGetLatestRecordByIdOp DeepCloneWithStringSerializedId(string stringSerializedId)
        {
            var result = new StandardGetLatestRecordByIdOp(
                                 stringSerializedId,
                                 this.IdentifierType?.DeepClone(),
                                 this.ObjectType?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone(),
                                 this.RecordNotFoundStrategy.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="IdentifierType" />.
        /// </summary>
        /// <param name="identifierType">The new <see cref="IdentifierType" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StandardGetLatestRecordByIdOp" /> using the specified <paramref name="identifierType" /> for <see cref="IdentifierType" /> and a deep clone of every other property.</returns>
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
        public StandardGetLatestRecordByIdOp DeepCloneWithIdentifierType(TypeRepresentation identifierType)
        {
            var result = new StandardGetLatestRecordByIdOp(
                                 this.StringSerializedId?.DeepClone(),
                                 identifierType,
                                 this.ObjectType?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone(),
                                 this.RecordNotFoundStrategy.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ObjectType" />.
        /// </summary>
        /// <param name="objectType">The new <see cref="ObjectType" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StandardGetLatestRecordByIdOp" /> using the specified <paramref name="objectType" /> for <see cref="ObjectType" /> and a deep clone of every other property.</returns>
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
        public StandardGetLatestRecordByIdOp DeepCloneWithObjectType(TypeRepresentation objectType)
        {
            var result = new StandardGetLatestRecordByIdOp(
                                 this.StringSerializedId?.DeepClone(),
                                 this.IdentifierType?.DeepClone(),
                                 objectType,
                                 this.VersionMatchStrategy.DeepClone(),
                                 this.RecordNotFoundStrategy.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="VersionMatchStrategy" />.
        /// </summary>
        /// <param name="versionMatchStrategy">The new <see cref="VersionMatchStrategy" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StandardGetLatestRecordByIdOp" /> using the specified <paramref name="versionMatchStrategy" /> for <see cref="VersionMatchStrategy" /> and a deep clone of every other property.</returns>
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
        public StandardGetLatestRecordByIdOp DeepCloneWithVersionMatchStrategy(VersionMatchStrategy versionMatchStrategy)
        {
            var result = new StandardGetLatestRecordByIdOp(
                                 this.StringSerializedId?.DeepClone(),
                                 this.IdentifierType?.DeepClone(),
                                 this.ObjectType?.DeepClone(),
                                 versionMatchStrategy,
                                 this.RecordNotFoundStrategy.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="RecordNotFoundStrategy" />.
        /// </summary>
        /// <param name="recordNotFoundStrategy">The new <see cref="RecordNotFoundStrategy" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StandardGetLatestRecordByIdOp" /> using the specified <paramref name="recordNotFoundStrategy" /> for <see cref="RecordNotFoundStrategy" /> and a deep clone of every other property.</returns>
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
        public StandardGetLatestRecordByIdOp DeepCloneWithRecordNotFoundStrategy(RecordNotFoundStrategy recordNotFoundStrategy)
        {
            var result = new StandardGetLatestRecordByIdOp(
                                 this.StringSerializedId?.DeepClone(),
                                 this.IdentifierType?.DeepClone(),
                                 this.ObjectType?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone(),
                                 recordNotFoundStrategy,
                                 this.SpecifiedResourceLocator?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="SpecifiedResourceLocator" />.
        /// </summary>
        /// <param name="specifiedResourceLocator">The new <see cref="SpecifiedResourceLocator" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StandardGetLatestRecordByIdOp" /> using the specified <paramref name="specifiedResourceLocator" /> for <see cref="SpecifiedResourceLocator" /> and a deep clone of every other property.</returns>
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
        public StandardGetLatestRecordByIdOp DeepCloneWithSpecifiedResourceLocator(IResourceLocator specifiedResourceLocator)
        {
            var result = new StandardGetLatestRecordByIdOp(
                                 this.StringSerializedId?.DeepClone(),
                                 this.IdentifierType?.DeepClone(),
                                 this.ObjectType?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone(),
                                 this.RecordNotFoundStrategy.DeepClone(),
                                 specifiedResourceLocator);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        protected override OperationBase DeepCloneInternal()
        {
            var result = new StandardGetLatestRecordByIdOp(
                                 this.StringSerializedId?.DeepClone(),
                                 this.IdentifierType?.DeepClone(),
                                 this.ObjectType?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone(),
                                 this.RecordNotFoundStrategy.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone());

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.StandardGetLatestRecordByIdOp: StringSerializedId = {this.StringSerializedId?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, IdentifierType = {this.IdentifierType?.ToString() ?? "<null>"}, ObjectType = {this.ObjectType?.ToString() ?? "<null>"}, VersionMatchStrategy = {this.VersionMatchStrategy.ToString() ?? "<null>"}, RecordNotFoundStrategy = {this.RecordNotFoundStrategy.ToString() ?? "<null>"}, SpecifiedResourceLocator = {this.SpecifiedResourceLocator?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}