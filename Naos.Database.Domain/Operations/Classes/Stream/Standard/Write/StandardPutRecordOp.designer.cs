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
    using global::OBeautifulCode.Serialization;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class StandardPutRecordOp : IModel<StandardPutRecordOp>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="StandardPutRecordOp"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(StandardPutRecordOp left, StandardPutRecordOp right)
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
        /// Determines whether two objects of type <see cref="StandardPutRecordOp"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(StandardPutRecordOp left, StandardPutRecordOp right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(StandardPutRecordOp other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.Metadata.IsEqualTo(other.Metadata)
                      && this.Payload.IsEqualTo(other.Payload)
                      && this.ExistingRecordStrategy.IsEqualTo(other.ExistingRecordStrategy)
                      && this.RecordRetentionCount.IsEqualTo(other.RecordRetentionCount)
                      && this.VersionMatchStrategy.IsEqualTo(other.VersionMatchStrategy)
                      && this.InternalRecordId.IsEqualTo(other.InternalRecordId)
                      && this.SpecifiedResourceLocator.IsEqualTo(other.SpecifiedResourceLocator);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as StandardPutRecordOp);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.Metadata)
            .Hash(this.Payload)
            .Hash(this.ExistingRecordStrategy)
            .Hash(this.RecordRetentionCount)
            .Hash(this.VersionMatchStrategy)
            .Hash(this.InternalRecordId)
            .Hash(this.SpecifiedResourceLocator)
            .Value;

        /// <inheritdoc />
        public new StandardPutRecordOp DeepClone() => (StandardPutRecordOp)this.DeepCloneInternal();

        /// <summary>
        /// Deep clones this object with a new <see cref="Metadata" />.
        /// </summary>
        /// <param name="metadata">The new <see cref="Metadata" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StandardPutRecordOp" /> using the specified <paramref name="metadata" /> for <see cref="Metadata" /> and a deep clone of every other property.</returns>
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
        public StandardPutRecordOp DeepCloneWithMetadata(StreamRecordMetadata metadata)
        {
            var result = new StandardPutRecordOp(
                                 metadata,
                                 this.Payload?.DeepClone(),
                                 this.ExistingRecordStrategy.DeepClone(),
                                 this.RecordRetentionCount?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone(),
                                 this.InternalRecordId?.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Payload" />.
        /// </summary>
        /// <param name="payload">The new <see cref="Payload" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StandardPutRecordOp" /> using the specified <paramref name="payload" /> for <see cref="Payload" /> and a deep clone of every other property.</returns>
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
        public StandardPutRecordOp DeepCloneWithPayload(DescribedSerializationBase payload)
        {
            var result = new StandardPutRecordOp(
                                 this.Metadata?.DeepClone(),
                                 payload,
                                 this.ExistingRecordStrategy.DeepClone(),
                                 this.RecordRetentionCount?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone(),
                                 this.InternalRecordId?.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ExistingRecordStrategy" />.
        /// </summary>
        /// <param name="existingRecordStrategy">The new <see cref="ExistingRecordStrategy" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StandardPutRecordOp" /> using the specified <paramref name="existingRecordStrategy" /> for <see cref="ExistingRecordStrategy" /> and a deep clone of every other property.</returns>
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
        public StandardPutRecordOp DeepCloneWithExistingRecordStrategy(ExistingRecordStrategy existingRecordStrategy)
        {
            var result = new StandardPutRecordOp(
                                 this.Metadata?.DeepClone(),
                                 this.Payload?.DeepClone(),
                                 existingRecordStrategy,
                                 this.RecordRetentionCount?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone(),
                                 this.InternalRecordId?.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="RecordRetentionCount" />.
        /// </summary>
        /// <param name="recordRetentionCount">The new <see cref="RecordRetentionCount" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StandardPutRecordOp" /> using the specified <paramref name="recordRetentionCount" /> for <see cref="RecordRetentionCount" /> and a deep clone of every other property.</returns>
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
        public StandardPutRecordOp DeepCloneWithRecordRetentionCount(int? recordRetentionCount)
        {
            var result = new StandardPutRecordOp(
                                 this.Metadata?.DeepClone(),
                                 this.Payload?.DeepClone(),
                                 this.ExistingRecordStrategy.DeepClone(),
                                 recordRetentionCount,
                                 this.VersionMatchStrategy.DeepClone(),
                                 this.InternalRecordId?.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="VersionMatchStrategy" />.
        /// </summary>
        /// <param name="versionMatchStrategy">The new <see cref="VersionMatchStrategy" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StandardPutRecordOp" /> using the specified <paramref name="versionMatchStrategy" /> for <see cref="VersionMatchStrategy" /> and a deep clone of every other property.</returns>
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
        public StandardPutRecordOp DeepCloneWithVersionMatchStrategy(VersionMatchStrategy versionMatchStrategy)
        {
            var result = new StandardPutRecordOp(
                                 this.Metadata?.DeepClone(),
                                 this.Payload?.DeepClone(),
                                 this.ExistingRecordStrategy.DeepClone(),
                                 this.RecordRetentionCount?.DeepClone(),
                                 versionMatchStrategy,
                                 this.InternalRecordId?.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="InternalRecordId" />.
        /// </summary>
        /// <param name="internalRecordId">The new <see cref="InternalRecordId" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StandardPutRecordOp" /> using the specified <paramref name="internalRecordId" /> for <see cref="InternalRecordId" /> and a deep clone of every other property.</returns>
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
        public StandardPutRecordOp DeepCloneWithInternalRecordId(long? internalRecordId)
        {
            var result = new StandardPutRecordOp(
                                 this.Metadata?.DeepClone(),
                                 this.Payload?.DeepClone(),
                                 this.ExistingRecordStrategy.DeepClone(),
                                 this.RecordRetentionCount?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone(),
                                 internalRecordId,
                                 this.SpecifiedResourceLocator?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="SpecifiedResourceLocator" />.
        /// </summary>
        /// <param name="specifiedResourceLocator">The new <see cref="SpecifiedResourceLocator" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StandardPutRecordOp" /> using the specified <paramref name="specifiedResourceLocator" /> for <see cref="SpecifiedResourceLocator" /> and a deep clone of every other property.</returns>
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
        public StandardPutRecordOp DeepCloneWithSpecifiedResourceLocator(IResourceLocator specifiedResourceLocator)
        {
            var result = new StandardPutRecordOp(
                                 this.Metadata?.DeepClone(),
                                 this.Payload?.DeepClone(),
                                 this.ExistingRecordStrategy.DeepClone(),
                                 this.RecordRetentionCount?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone(),
                                 this.InternalRecordId?.DeepClone(),
                                 specifiedResourceLocator);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        protected override OperationBase DeepCloneInternal()
        {
            var result = new StandardPutRecordOp(
                                 this.Metadata?.DeepClone(),
                                 this.Payload?.DeepClone(),
                                 this.ExistingRecordStrategy.DeepClone(),
                                 this.RecordRetentionCount?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone(),
                                 this.InternalRecordId?.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone());

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.StandardPutRecordOp: Metadata = {this.Metadata?.ToString() ?? "<null>"}, Payload = {this.Payload?.ToString() ?? "<null>"}, ExistingRecordStrategy = {this.ExistingRecordStrategy.ToString() ?? "<null>"}, RecordRetentionCount = {this.RecordRetentionCount?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, VersionMatchStrategy = {this.VersionMatchStrategy.ToString() ?? "<null>"}, InternalRecordId = {this.InternalRecordId?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, SpecifiedResourceLocator = {this.SpecifiedResourceLocator?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}