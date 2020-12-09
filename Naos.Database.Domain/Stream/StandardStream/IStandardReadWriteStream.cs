﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStandardReadWriteStream.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Serialization;

    /// <summary>
    /// Standard streams reduced to core calls to participate in the StandardStream specific protocols.
    /// </summary>
    public interface IStandardReadWriteStream
        :
          IReadWriteStream,
          IStreamManagementProtocolFactory,
          IStreamRecordHandlingProtocolFactory,
          IStreamManagementProtocols,
          IReturningProtocol<GetNextUniqueLongOp, long>,
          IReturningProtocol<GetLatestRecordOp, StreamRecord>,
          IReturningProtocol<GetLatestRecordByIdOp, StreamRecord>,
          IReturningProtocol<GetHandlingHistoryOfRecordOp, IReadOnlyList<StreamRecordHandlingEntry>>,
          IReturningProtocol<GetHandlingStatusOfRecordsByIdOp, HandlingStatus>,
          IReturningProtocol<GetHandlingStatusOfRecordSetByTagOp, HandlingStatus>,
          IReturningProtocol<TryHandleRecordOp, StreamRecord>,
          IReturningProtocol<PutRecordOp, long>,
          IVoidProtocol<BlockRecordHandlingOp>,
          IVoidProtocol<CancelBlockedRecordHandlingOp>,
          IVoidProtocol<CancelHandleRecordExecutionRequestOp>,
          IVoidProtocol<CancelRunningHandleRecordExecutionOp>,
          IVoidProtocol<CompleteRunningHandleRecordExecutionOp>,
          IVoidProtocol<FailRunningHandleRecordExecutionOp>,
          IVoidProtocol<SelfCancelRunningHandleRecordExecutionOp>,
          IVoidProtocol<RetryFailedHandleRecordExecutionOp>
    {
        /// <summary>
        /// Gets the serializer factory.
        /// </summary>
        /// <value>The serializer factory.</value>
        ISerializerFactory SerializerFactory { get; }

        /// <summary>
        /// Gets the default serializer representation.
        /// </summary>
        /// <value>The default serializer representation.</value>
        SerializerRepresentation DefaultSerializerRepresentation { get; }

        /// <summary>
        /// Gets the default serialization format.
        /// </summary>
        /// <value>The default serialization format.</value>
        SerializationFormat DefaultSerializationFormat { get; }
    }
}
