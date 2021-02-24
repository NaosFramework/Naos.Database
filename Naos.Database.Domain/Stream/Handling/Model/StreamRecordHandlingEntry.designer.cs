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

    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Serialization;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class StreamRecordHandlingEntry : IModel<StreamRecordHandlingEntry>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="StreamRecordHandlingEntry"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(StreamRecordHandlingEntry left, StreamRecordHandlingEntry right)
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
        /// Determines whether two objects of type <see cref="StreamRecordHandlingEntry"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(StreamRecordHandlingEntry left, StreamRecordHandlingEntry right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(StreamRecordHandlingEntry other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.InternalHandlingEntryId.IsEqualTo(other.InternalHandlingEntryId)
                      && this.Metadata.IsEqualTo(other.Metadata)
                      && this.Payload.IsEqualTo(other.Payload);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as StreamRecordHandlingEntry);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.InternalHandlingEntryId)
            .Hash(this.Metadata)
            .Hash(this.Payload)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public StreamRecordHandlingEntry DeepClone()
        {
            var result = new StreamRecordHandlingEntry(
                                 this.InternalHandlingEntryId,
                                 this.Metadata?.DeepClone(),
                                 this.Payload?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="InternalHandlingEntryId" />.
        /// </summary>
        /// <param name="internalHandlingEntryId">The new <see cref="InternalHandlingEntryId" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StreamRecordHandlingEntry" /> using the specified <paramref name="internalHandlingEntryId" /> for <see cref="InternalHandlingEntryId" /> and a deep clone of every other property.</returns>
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
        public StreamRecordHandlingEntry DeepCloneWithInternalHandlingEntryId(long internalHandlingEntryId)
        {
            var result = new StreamRecordHandlingEntry(
                                 internalHandlingEntryId,
                                 this.Metadata?.DeepClone(),
                                 this.Payload?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Metadata" />.
        /// </summary>
        /// <param name="metadata">The new <see cref="Metadata" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StreamRecordHandlingEntry" /> using the specified <paramref name="metadata" /> for <see cref="Metadata" /> and a deep clone of every other property.</returns>
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
        public StreamRecordHandlingEntry DeepCloneWithMetadata(StreamRecordHandlingEntryMetadata metadata)
        {
            var result = new StreamRecordHandlingEntry(
                                 this.InternalHandlingEntryId,
                                 metadata,
                                 this.Payload?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Payload" />.
        /// </summary>
        /// <param name="payload">The new <see cref="Payload" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StreamRecordHandlingEntry" /> using the specified <paramref name="payload" /> for <see cref="Payload" /> and a deep clone of every other property.</returns>
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
        public StreamRecordHandlingEntry DeepCloneWithPayload(DescribedSerializationBase payload)
        {
            var result = new StreamRecordHandlingEntry(
                                 this.InternalHandlingEntryId,
                                 this.Metadata?.DeepClone(),
                                 payload);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.StreamRecordHandlingEntry: InternalHandlingEntryId = {this.InternalHandlingEntryId.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Metadata = {this.Metadata?.ToString() ?? "<null>"}, Payload = {this.Payload?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}