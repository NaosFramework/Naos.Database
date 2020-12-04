﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.139.0)
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
    public partial class GetHandlingStatusOfRecordsByIdOp<TId> : IModel<GetHandlingStatusOfRecordsByIdOp<TId>>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="GetHandlingStatusOfRecordsByIdOp{TId}"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(GetHandlingStatusOfRecordsByIdOp<TId> left, GetHandlingStatusOfRecordsByIdOp<TId> right)
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
        /// Determines whether two objects of type <see cref="GetHandlingStatusOfRecordsByIdOp{TId}"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(GetHandlingStatusOfRecordsByIdOp<TId> left, GetHandlingStatusOfRecordsByIdOp<TId> right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(GetHandlingStatusOfRecordsByIdOp<TId> other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.IdsToMatch.IsEqualTo(other.IdsToMatch)
                      && this.HandlingStatusCompositionStrategy.IsEqualTo(other.HandlingStatusCompositionStrategy)
                      && this.TypeVersionMatchStrategy.IsEqualTo(other.TypeVersionMatchStrategy);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as GetHandlingStatusOfRecordsByIdOp<TId>);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.IdsToMatch)
            .Hash(this.HandlingStatusCompositionStrategy)
            .Hash(this.TypeVersionMatchStrategy)
            .Value;

        /// <inheritdoc />
        public new GetHandlingStatusOfRecordsByIdOp<TId> DeepClone() => (GetHandlingStatusOfRecordsByIdOp<TId>)this.DeepCloneInternal();

        /// <summary>
        /// Deep clones this object with a new <see cref="IdsToMatch" />.
        /// </summary>
        /// <param name="idsToMatch">The new <see cref="IdsToMatch" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetHandlingStatusOfRecordsByIdOp{TId}" /> using the specified <paramref name="idsToMatch" /> for <see cref="IdsToMatch" /> and a deep clone of every other property.</returns>
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
        public GetHandlingStatusOfRecordsByIdOp<TId> DeepCloneWithIdsToMatch(IReadOnlyCollection<TId> idsToMatch)
        {
            var result = new GetHandlingStatusOfRecordsByIdOp<TId>(
                                 idsToMatch,
                                 this.HandlingStatusCompositionStrategy?.DeepClone(),
                                 this.TypeVersionMatchStrategy);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="HandlingStatusCompositionStrategy" />.
        /// </summary>
        /// <param name="handlingStatusCompositionStrategy">The new <see cref="HandlingStatusCompositionStrategy" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetHandlingStatusOfRecordsByIdOp{TId}" /> using the specified <paramref name="handlingStatusCompositionStrategy" /> for <see cref="HandlingStatusCompositionStrategy" /> and a deep clone of every other property.</returns>
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
        public GetHandlingStatusOfRecordsByIdOp<TId> DeepCloneWithHandlingStatusCompositionStrategy(HandlingStatusCompositionStrategy handlingStatusCompositionStrategy)
        {
            var result = new GetHandlingStatusOfRecordsByIdOp<TId>(
                                 this.IdsToMatch?.Select(i => DeepCloneGeneric(i)).ToList(),
                                 handlingStatusCompositionStrategy,
                                 this.TypeVersionMatchStrategy);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="TypeVersionMatchStrategy" />.
        /// </summary>
        /// <param name="typeVersionMatchStrategy">The new <see cref="TypeVersionMatchStrategy" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetHandlingStatusOfRecordsByIdOp{TId}" /> using the specified <paramref name="typeVersionMatchStrategy" /> for <see cref="TypeVersionMatchStrategy" /> and a deep clone of every other property.</returns>
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
        public GetHandlingStatusOfRecordsByIdOp<TId> DeepCloneWithTypeVersionMatchStrategy(TypeVersionMatchStrategy typeVersionMatchStrategy)
        {
            var result = new GetHandlingStatusOfRecordsByIdOp<TId>(
                                 this.IdsToMatch?.Select(i => DeepCloneGeneric(i)).ToList(),
                                 this.HandlingStatusCompositionStrategy?.DeepClone(),
                                 typeVersionMatchStrategy);

            return result;
        }

        /// <inheritdoc />
        protected override OperationBase DeepCloneInternal()
        {
            var result = new GetHandlingStatusOfRecordsByIdOp<TId>(
                                 this.IdsToMatch?.Select(i => DeepCloneGeneric(i)).ToList(),
                                 this.HandlingStatusCompositionStrategy?.DeepClone(),
                                 this.TypeVersionMatchStrategy);

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

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.{this.GetType().ToStringReadable()}: IdsToMatch = {this.IdsToMatch?.ToString() ?? "<null>"}, HandlingStatusCompositionStrategy = {this.HandlingStatusCompositionStrategy?.ToString() ?? "<null>"}, TypeVersionMatchStrategy = {this.TypeVersionMatchStrategy.ToString() ?? "<null>"}.");

            return result;
        }
    }
}