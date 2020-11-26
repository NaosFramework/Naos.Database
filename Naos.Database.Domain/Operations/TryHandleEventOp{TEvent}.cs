﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TryHandleEventOp{TEvent}.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Attempts to put a <see cref="HandlingEventEvent{TId,TEvent}"/> and return the found <see cref="IEvent"/> to handle.
    /// </summary>
    /// <typeparam name="TEvent">Type of the event.</typeparam>
    public partial class TryHandleEventOp<TEvent> : ReturningOperationBase<EventToHandle<TEvent>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TryHandleEventOp{TEvent}"/> class.
        /// </summary>
        /// <param name="details">The details about the handler.</param>
        public TryHandleEventOp(
            string details)
        {
            details.MustForArg(nameof(details)).NotBeNullNorWhiteSpace();
            this.Details = details;
        }

        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <value>The details.</value>
        public string Details { get; private set; }
    }
}
