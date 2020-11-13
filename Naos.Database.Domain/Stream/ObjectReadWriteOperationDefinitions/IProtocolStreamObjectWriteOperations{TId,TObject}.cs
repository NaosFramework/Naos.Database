﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IProtocolStreamObjectWriteOperations{TId,TObject}.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using Naos.Protocol.Domain;

    /// <summary>
    /// Interface to protocol the basic stream data operations with a known identifier.
    /// </summary>
    /// <typeparam name="TId">Type of ID used.</typeparam>
    /// <typeparam name="TObject">Type of object used.</typeparam>
    public interface IProtocolStreamObjectWriteOperations<TId, TObject> :
        IProtocolStreamObjectWithIdWriteOperations<TId>,
        IProtocolStreamObjectWriteOperations<TObject>,
        ISyncAndAsyncVoidProtocol<PutOp<TId, TObject>>,
        ISyncAndAsyncReturningProtocol<PutAndReturnStreamInternalObjectIdOp<TId, TObject>, long>,
        ISyncAndAsyncVoidProtocol<PutIdentifiableOp<TId, TObject>>,
        ISyncAndAsyncReturningProtocol<PutIdentifiableAndReturnStreamInternalObjectIdOp<TId, TObject>, long>
    {
    }
}
