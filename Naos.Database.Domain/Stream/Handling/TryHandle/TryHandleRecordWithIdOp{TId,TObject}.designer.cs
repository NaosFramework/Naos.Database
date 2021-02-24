﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.150.0)
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

    using global::Naos.Protocol.Domain;

    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class TryHandleRecordWithIdOp<TId, TObject> : IModel<TryHandleRecordWithIdOp<TId, TObject>>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="TryHandleRecordWithIdOp{TId, TObject}"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(TryHandleRecordWithIdOp<TId, TObject> left, TryHandleRecordWithIdOp<TId, TObject> right)
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
        /// Determines whether two objects of type <see cref="TryHandleRecordWithIdOp{TId, TObject}"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(TryHandleRecordWithIdOp<TId, TObject> left, TryHandleRecordWithIdOp<TId, TObject> right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(TryHandleRecordWithIdOp<TId, TObject> other)
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
                      && this.TypeVersionMatchStrategy.IsEqualTo(other.TypeVersionMatchStrategy)
                      && this.OrderRecordsStrategy.IsEqualTo(other.OrderRecordsStrategy)
                      && this.SpecifiedResourceLocator.IsEqualTo(other.SpecifiedResourceLocator)
                      && this.Tags.IsEqualTo(other.Tags)
                      && this.Details.IsEqualTo(other.Details, StringComparer.Ordinal)
                      && this.MinimumInternalRecordId.IsEqualTo(other.MinimumInternalRecordId)
                      && this.InheritRecordTags.IsEqualTo(other.InheritRecordTags);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as TryHandleRecordWithIdOp<TId, TObject>);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.Concern)
            .Hash(this.TypeVersionMatchStrategy)
            .Hash(this.OrderRecordsStrategy)
            .Hash(this.SpecifiedResourceLocator)
            .Hash(this.Tags)
            .Hash(this.Details)
            .Hash(this.MinimumInternalRecordId)
            .Hash(this.InheritRecordTags)
            .Value;

        /// <inheritdoc />
        public new TryHandleRecordWithIdOp<TId, TObject> DeepClone() => (TryHandleRecordWithIdOp<TId, TObject>)this.DeepCloneInternal();

        /// <summary>
        /// Deep clones this object with a new <see cref="Concern" />.
        /// </summary>
        /// <param name="concern">The new <see cref="Concern" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TryHandleRecordWithIdOp{TId, TObject}" /> using the specified <paramref name="concern" /> for <see cref="Concern" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
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
        public TryHandleRecordWithIdOp<TId, TObject> DeepCloneWithConcern(string concern)
        {
            var result = new TryHandleRecordWithIdOp<TId, TObject>(
                                 concern,
                                 this.TypeVersionMatchStrategy,
                                 this.OrderRecordsStrategy,
                                 (IResourceLocator)DeepCloneInterface(this.SpecifiedResourceLocator),
                                 this.Tags?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 this.Details?.DeepClone(),
                                 this.MinimumInternalRecordId,
                                 this.InheritRecordTags);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="TypeVersionMatchStrategy" />.
        /// </summary>
        /// <param name="typeVersionMatchStrategy">The new <see cref="TypeVersionMatchStrategy" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TryHandleRecordWithIdOp{TId, TObject}" /> using the specified <paramref name="typeVersionMatchStrategy" /> for <see cref="TypeVersionMatchStrategy" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
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
        public TryHandleRecordWithIdOp<TId, TObject> DeepCloneWithTypeVersionMatchStrategy(TypeVersionMatchStrategy typeVersionMatchStrategy)
        {
            var result = new TryHandleRecordWithIdOp<TId, TObject>(
                                 this.Concern?.DeepClone(),
                                 typeVersionMatchStrategy,
                                 this.OrderRecordsStrategy,
                                 (IResourceLocator)DeepCloneInterface(this.SpecifiedResourceLocator),
                                 this.Tags?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 this.Details?.DeepClone(),
                                 this.MinimumInternalRecordId,
                                 this.InheritRecordTags);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="OrderRecordsStrategy" />.
        /// </summary>
        /// <param name="orderRecordsStrategy">The new <see cref="OrderRecordsStrategy" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TryHandleRecordWithIdOp{TId, TObject}" /> using the specified <paramref name="orderRecordsStrategy" /> for <see cref="OrderRecordsStrategy" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
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
        public TryHandleRecordWithIdOp<TId, TObject> DeepCloneWithOrderRecordsStrategy(OrderRecordsStrategy orderRecordsStrategy)
        {
            var result = new TryHandleRecordWithIdOp<TId, TObject>(
                                 this.Concern?.DeepClone(),
                                 this.TypeVersionMatchStrategy,
                                 orderRecordsStrategy,
                                 (IResourceLocator)DeepCloneInterface(this.SpecifiedResourceLocator),
                                 this.Tags?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 this.Details?.DeepClone(),
                                 this.MinimumInternalRecordId,
                                 this.InheritRecordTags);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="SpecifiedResourceLocator" />.
        /// </summary>
        /// <param name="specifiedResourceLocator">The new <see cref="SpecifiedResourceLocator" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TryHandleRecordWithIdOp{TId, TObject}" /> using the specified <paramref name="specifiedResourceLocator" /> for <see cref="SpecifiedResourceLocator" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
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
        public TryHandleRecordWithIdOp<TId, TObject> DeepCloneWithSpecifiedResourceLocator(IResourceLocator specifiedResourceLocator)
        {
            var result = new TryHandleRecordWithIdOp<TId, TObject>(
                                 this.Concern?.DeepClone(),
                                 this.TypeVersionMatchStrategy,
                                 this.OrderRecordsStrategy,
                                 specifiedResourceLocator,
                                 this.Tags?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 this.Details?.DeepClone(),
                                 this.MinimumInternalRecordId,
                                 this.InheritRecordTags);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Tags" />.
        /// </summary>
        /// <param name="tags">The new <see cref="Tags" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TryHandleRecordWithIdOp{TId, TObject}" /> using the specified <paramref name="tags" /> for <see cref="Tags" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
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
        public TryHandleRecordWithIdOp<TId, TObject> DeepCloneWithTags(IReadOnlyDictionary<string, string> tags)
        {
            var result = new TryHandleRecordWithIdOp<TId, TObject>(
                                 this.Concern?.DeepClone(),
                                 this.TypeVersionMatchStrategy,
                                 this.OrderRecordsStrategy,
                                 (IResourceLocator)DeepCloneInterface(this.SpecifiedResourceLocator),
                                 tags,
                                 this.Details?.DeepClone(),
                                 this.MinimumInternalRecordId,
                                 this.InheritRecordTags);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Details" />.
        /// </summary>
        /// <param name="details">The new <see cref="Details" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TryHandleRecordWithIdOp{TId, TObject}" /> using the specified <paramref name="details" /> for <see cref="Details" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
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
        public TryHandleRecordWithIdOp<TId, TObject> DeepCloneWithDetails(string details)
        {
            var result = new TryHandleRecordWithIdOp<TId, TObject>(
                                 this.Concern?.DeepClone(),
                                 this.TypeVersionMatchStrategy,
                                 this.OrderRecordsStrategy,
                                 (IResourceLocator)DeepCloneInterface(this.SpecifiedResourceLocator),
                                 this.Tags?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 details,
                                 this.MinimumInternalRecordId,
                                 this.InheritRecordTags);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="MinimumInternalRecordId" />.
        /// </summary>
        /// <param name="minimumInternalRecordId">The new <see cref="MinimumInternalRecordId" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TryHandleRecordWithIdOp{TId, TObject}" /> using the specified <paramref name="minimumInternalRecordId" /> for <see cref="MinimumInternalRecordId" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
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
        public TryHandleRecordWithIdOp<TId, TObject> DeepCloneWithMinimumInternalRecordId(long? minimumInternalRecordId)
        {
            var result = new TryHandleRecordWithIdOp<TId, TObject>(
                                 this.Concern?.DeepClone(),
                                 this.TypeVersionMatchStrategy,
                                 this.OrderRecordsStrategy,
                                 (IResourceLocator)DeepCloneInterface(this.SpecifiedResourceLocator),
                                 this.Tags?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 this.Details?.DeepClone(),
                                 minimumInternalRecordId,
                                 this.InheritRecordTags);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="InheritRecordTags" />.
        /// </summary>
        /// <param name="inheritRecordTags">The new <see cref="InheritRecordTags" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TryHandleRecordWithIdOp{TId, TObject}" /> using the specified <paramref name="inheritRecordTags" /> for <see cref="InheritRecordTags" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
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
        public TryHandleRecordWithIdOp<TId, TObject> DeepCloneWithInheritRecordTags(bool inheritRecordTags)
        {
            var result = new TryHandleRecordWithIdOp<TId, TObject>(
                                 this.Concern?.DeepClone(),
                                 this.TypeVersionMatchStrategy,
                                 this.OrderRecordsStrategy,
                                 (IResourceLocator)DeepCloneInterface(this.SpecifiedResourceLocator),
                                 this.Tags?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 this.Details?.DeepClone(),
                                 this.MinimumInternalRecordId,
                                 inheritRecordTags);

            return result;
        }

        /// <inheritdoc />
        protected override OperationBase DeepCloneInternal()
        {
            var result = new TryHandleRecordWithIdOp<TId, TObject>(
                                 this.Concern?.DeepClone(),
                                 this.TypeVersionMatchStrategy,
                                 this.OrderRecordsStrategy,
                                 (IResourceLocator)DeepCloneInterface(this.SpecifiedResourceLocator),
                                 this.Tags?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 this.Details?.DeepClone(),
                                 this.MinimumInternalRecordId,
                                 this.InheritRecordTags);

            return result;
        }

        private static TId DeepCloneGeneric(TId value)
        {
            object result;

            var type = typeof(TId);

            if (type.IsValueType)
            {
                result = value;
            }
            else
            {
                if (ReferenceEquals(value, null))
                {
                    result = default;
                }
                else if (value is IDeepCloneable<TId> deepCloneableValue)
                {
                    result = deepCloneableValue.DeepClone();
                }
                else if (value is string valueAsString)
                {
                    result = valueAsString.DeepClone();
                }
                else if (value is global::System.Version valueAsVersion)
                {
                    result = valueAsVersion.DeepClone();
                }
                else if (value is global::System.Uri valueAsUri)
                {
                    result = valueAsUri.DeepClone();
                }
                else
                {
                    throw new NotSupportedException(Invariant($"I do not know how to deep clone an object of type '{type.ToStringReadable()}'"));
                }
            }

            return (TId)result;
        }

        private static TObject DeepCloneGeneric(TObject value)
        {
            object result;

            var type = typeof(TObject);

            if (type.IsValueType)
            {
                result = value;
            }
            else
            {
                if (ReferenceEquals(value, null))
                {
                    result = default;
                }
                else if (value is IDeepCloneable<TObject> deepCloneableValue)
                {
                    result = deepCloneableValue.DeepClone();
                }
                else if (value is string valueAsString)
                {
                    result = valueAsString.DeepClone();
                }
                else if (value is global::System.Version valueAsVersion)
                {
                    result = valueAsVersion.DeepClone();
                }
                else if (value is global::System.Uri valueAsUri)
                {
                    result = valueAsUri.DeepClone();
                }
                else
                {
                    throw new NotSupportedException(Invariant($"I do not know how to deep clone an object of type '{type.ToStringReadable()}'"));
                }
            }

            return (TObject)result;
        }

        private static object DeepCloneInterface(object value)
        {
            object result;

            if (ReferenceEquals(value, null))
            {
                result = null;
            }
            else
            {
                var type = value.GetType();

                if (type.IsValueType)
                {
                    result = value;
                }
                else if (value is string valueAsString)
                {
                    result = valueAsString.DeepClone();
                }
                else if (value is global::System.Version valueAsVersion)
                {
                    result = valueAsVersion.DeepClone();
                }
                else if (value is global::System.Uri valueAsUri)
                {
                    result = valueAsUri.DeepClone();
                }
                else
                {
                    var deepCloneableInterface = typeof(IDeepCloneable<>).MakeGenericType(type);

                    if (deepCloneableInterface.IsAssignableFrom(type))
                    {
                        var deepCloneMethod = deepCloneableInterface.GetMethod(nameof(IDeepCloneable<object>.DeepClone));

                        result = deepCloneMethod.Invoke(value, null);
                    }
                    else
                    {
                        throw new NotSupportedException(Invariant($"I do not know how to deep clone an object of type '{type.ToStringReadable()}'"));
                    }
                }
            }

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.{this.GetType().ToStringReadable()}: Concern = {this.Concern?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, TypeVersionMatchStrategy = {this.TypeVersionMatchStrategy.ToString() ?? "<null>"}, OrderRecordsStrategy = {this.OrderRecordsStrategy.ToString() ?? "<null>"}, SpecifiedResourceLocator = {this.SpecifiedResourceLocator?.ToString() ?? "<null>"}, Tags = {this.Tags?.ToString() ?? "<null>"}, Details = {this.Details?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, MinimumInternalRecordId = {this.MinimumInternalRecordId?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, InheritRecordTags = {this.InheritRecordTags.ToString(CultureInfo.InvariantCulture) ?? "<null>"}.");

            return result;
        }
    }
}