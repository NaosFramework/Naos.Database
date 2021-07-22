﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Run.cs" company="Naos">
//   Copyright 2017 Naos
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in Naos.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Recipes.RunWithRetry
{
    using System;
    using System.Runtime.ExceptionServices;
    using System.Threading;
    using System.Threading.Tasks;

    using Spritely.Redo;

    using static System.FormattableString;

    /// <summary>
    /// Provides methods to run code and retry if that code throws.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("Naos.Recipes", "See package version number")]
    internal static class Run
    {
        /// <summary>
        /// Default retry count.
        /// </summary>
        public const int DefaultRetryCount = 5;

        /// <summary>
        /// Default back off delay.
        /// </summary>
        public static readonly TimeSpan DefaultLinearBackoffDelay = TimeSpan.FromSeconds(5);

        /// <summary>
        /// Runs a function and retries if any exception is thrown, using a linear backoff strategy.
        /// </summary>
        /// <param name="operation">The operation to execute.</param>
        /// <param name="retryCount">Optional number of retries; DEFAULT is <see cref="DefaultRetryCount" />.</param>
        /// <param name="backOffDelay">Optional backoff delay; DEFAULT is <see cref="DefaultLinearBackoffDelay" />.</param>
        /// <returns>
        /// A task.
        /// </returns>
        public static void WithRetry(this Action operation, int retryCount = DefaultRetryCount, TimeSpan backOffDelay = default(TimeSpan))
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            var localBackOff = backOffDelay == default(TimeSpan) ? DefaultLinearBackoffDelay : backOffDelay;

            Using
                .LinearBackOff(localBackOff)
                .WithMaxRetries(retryCount)
                .Run(operation)
                .Now();
        }

        /// <summary>
        /// Runs a function and retries if any exception is thrown, using a linear backoff strategy.
        /// </summary>
        /// <typeparam name="T">The type of task returned by the operation.</typeparam>
        /// <param name="operation">The operation to execute.</param>
        /// <param name="retryCount">Optional number of retries; DEFAULT is <see cref="DefaultRetryCount" />.</param>
        /// <param name="backOffDelay">Optional backoff delay; DEFAULT is <see cref="DefaultLinearBackoffDelay" />.</param>
        /// <returns>
        /// A task of type returned by the operation.
        /// </returns>
        public static T WithRetry<T>(this Func<T> operation, int retryCount = DefaultRetryCount, TimeSpan backOffDelay = default(TimeSpan))
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            var localBackOff = backOffDelay == default(TimeSpan) ? DefaultLinearBackoffDelay : backOffDelay;

            var result = Using
                             .LinearBackOff(localBackOff)
                             .WithMaxRetries(retryCount)
                             .Run(operation)
                             .Now();
            return result;
        }

        /// <summary>
        /// Runs a function and retries if any exception is thrown, using a linear backoff strategy.
        /// </summary>
        /// <param name="operation">The operation to execute.</param>
        /// <param name="reporter">Action to call to report exceptions as they occur.</param>
        /// <param name="messageBuilder">
        /// Optional.  Transforms the exception message and uses that as the Message property of the 
        /// anonymous object that's sent to the <paramref name="reporter"/>.  If null, then the exception's
        /// Message is used.
        /// </param>
        /// <param name="retryCount">Optional number of retries; DEFAULT is <see cref="DefaultRetryCount" />.</param>
        /// <param name="backOffDelay">Optional backoff delay; DEFAULT is <see cref="DefaultLinearBackoffDelay" />.</param>
        /// <returns>
        /// A task.
        /// </returns>
        public static void WithRetry(this Action operation, Action<object> reporter, Func<Exception, string> messageBuilder = null, int retryCount = DefaultRetryCount, TimeSpan backOffDelay = default(TimeSpan))
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            if (reporter == null)
            {
                throw new ArgumentNullException(nameof(reporter));
            }

            var localBackOff = backOffDelay == default(TimeSpan) ? DefaultLinearBackoffDelay : backOffDelay;

            Using
                .LinearBackOff(localBackOff)
                .WithReporter(_ => reporter(new { Message = messageBuilder == null ? _.Message : messageBuilder(_), Exception = _ }))
                .WithMaxRetries(retryCount)
                .Run(operation)
                .Now();
        }

        /// <summary>
        /// Runs a function and retries if any exception is thrown, using a linear backoff strategy.
        /// </summary>
        /// <typeparam name="T">The type of task returned by the operation.</typeparam>
        /// <param name="operation">The operation to execute.</param>
        /// <param name="reporter">Action to call to report exceptions as they occur.</param>
        /// <param name="messageBuilder">
        /// Optional.  Transforms the exception message and uses that as the Message property of the 
        /// anonymous object that's sent to the <paramref name="reporter"/>.  If null, then the exception's
        /// Message is used.
        /// </param>
        /// <param name="retryCount">Optional number of retries; DEFAULT is <see cref="DefaultRetryCount" />.</param>
        /// <param name="backOffDelay">Optional backoff delay; DEFAULT is <see cref="DefaultLinearBackoffDelay" />.</param>
        /// <returns>
        /// A task of type returned by the operation.
        /// </returns>
        public static T WithRetry<T>(this Func<T> operation, Action<object> reporter, Func<Exception, string> messageBuilder = null, int retryCount = DefaultRetryCount, TimeSpan backOffDelay = default(TimeSpan))
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            if (reporter == null)
            {
                throw new ArgumentNullException(nameof(reporter));
            }

            var localBackOff = backOffDelay == default(TimeSpan) ? DefaultLinearBackoffDelay : backOffDelay;

            var result = Using
                             .LinearBackOff(localBackOff)
                             .WithReporter(_ => reporter(new { Message = messageBuilder == null ? _.Message : messageBuilder(_), Exception = _ }))
                             .WithMaxRetries(retryCount)
                             .Run(operation)
                             .Now();
            return result;
        }

        /// <summary>
        /// Runs a function and retries if any exception is thrown, using a linear backoff strategy.
        /// </summary>
        /// <param name="operation">The operation to execute.</param>
        /// <param name="retryCount">Optional number of retries; DEFAULT is <see cref="DefaultRetryCount" />.</param>
        /// <param name="backOffDelay">Optional backoff delay; DEFAULT is <see cref="DefaultLinearBackoffDelay" />.</param>
        /// <returns>
        /// A task.
        /// </returns>
        public static async Task WithRetryAsync(this Func<Task> operation, int retryCount = DefaultRetryCount, TimeSpan backOffDelay = default(TimeSpan))
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            var localBackOff = backOffDelay == default(TimeSpan) ? DefaultLinearBackoffDelay : backOffDelay;

            await Using
                .LinearBackOff(localBackOff)
                .WithMaxRetries(retryCount)
                .RunAsync(operation)
                .Now();
        }

        /// <summary>
        /// Runs a function and retries if any exception is thrown, using a linear backoff strategy.
        /// </summary>
        /// <typeparam name="T">The type of task returned by the operation.</typeparam>
        /// <param name="operation">The operation to execute.</param>
        /// <param name="retryCount">Optional number of retries; DEFAULT is <see cref="DefaultRetryCount" />.</param>
        /// <param name="backOffDelay">Optional backoff delay; DEFAULT is <see cref="DefaultLinearBackoffDelay" />.</param>
        /// <returns>
        /// A task of type returned by the operation.
        /// </returns>
        public static async Task<T> WithRetryAsync<T>(this Func<Task<T>> operation, int retryCount = DefaultRetryCount, TimeSpan backOffDelay = default(TimeSpan))
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            var localBackOff = backOffDelay == default(TimeSpan) ? DefaultLinearBackoffDelay : backOffDelay;

            var result = await Using
                             .LinearBackOff(localBackOff)
                             .WithMaxRetries(retryCount)
                             .RunAsync(operation)
                             .Now();
            return result;
        }

        /// <summary>
        /// Runs a function and retries if any exception is thrown, using a linear backoff strategy.
        /// </summary>
        /// <param name="operation">The operation to execute.</param>
        /// <param name="reporter">Action to call to report exceptions as they occur.</param>
        /// <param name="messageBuilder">
        /// Optional.  Transforms the exception message and uses that as the Message property of the 
        /// anonymous object that's sent to the <paramref name="reporter"/>.  If null, then the exception's
        /// Message is used.
        /// </param>
        /// <param name="retryCount">Optional number of retries; DEFAULT is <see cref="DefaultRetryCount" />.</param>
        /// <param name="backOffDelay">Optional backoff delay; DEFAULT is <see cref="DefaultLinearBackoffDelay" />.</param>
        /// <returns>
        /// A task.
        /// </returns>
        public static async Task WithRetryAsync(this Func<Task> operation, Action<object> reporter, Func<Exception, string> messageBuilder = null, int retryCount = DefaultRetryCount, TimeSpan backOffDelay = default(TimeSpan))
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            if (reporter == null)
            {
                throw new ArgumentNullException(nameof(reporter));
            }

            var localBackOff = backOffDelay == default(TimeSpan) ? DefaultLinearBackoffDelay : backOffDelay;

            await Using
                .LinearBackOff(localBackOff)
                .WithReporter(_ => reporter(new { Message = messageBuilder == null ? _.Message : messageBuilder(_), Exception = _ }))
                .WithMaxRetries(retryCount)
                .RunAsync(operation)
                .Now();
        }

        /// <summary>
        /// Runs a function and retries if any exception is thrown, using a linear backoff strategy.
        /// </summary>
        /// <typeparam name="T">The type of task returned by the operation.</typeparam>
        /// <param name="operation">The operation to execute.</param>
        /// <param name="reporter">Action to call to report exceptions as they occur.</param>
        /// <param name="messageBuilder">
        /// Optional.  Transforms the exception message and uses that as the Message property of the 
        /// anonymous object that's sent to the <paramref name="reporter"/>.  If null, then the exception's
        /// Message is used.
        /// </param>
        /// <param name="retryCount">Optional number of retries; DEFAULT is <see cref="DefaultRetryCount" />.</param>
        /// <param name="backOffDelay">Optional backoff delay; DEFAULT is <see cref="DefaultLinearBackoffDelay" />.</param>
        /// <returns>
        /// A task of type returned by the operation.
        /// </returns>
        public static async Task<T> WithRetryAsync<T>(this Func<Task<T>> operation, Action<object> reporter, Func<Exception, string> messageBuilder = null, int retryCount = DefaultRetryCount, TimeSpan backOffDelay = default(TimeSpan))
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            if (reporter == null)
            {
                throw new ArgumentNullException(nameof(reporter));
            }

            var localBackOff = backOffDelay == default(TimeSpan) ? DefaultLinearBackoffDelay : backOffDelay;

            var result = await Using
                             .LinearBackOff(localBackOff)
                             .WithReporter(_ => reporter(new { Message = messageBuilder == null ? _.Message : messageBuilder(_), Exception = _ }))
                             .WithMaxRetries(retryCount)
                             .RunAsync(operation)
                             .Now();
            return result;
        }
    }
}