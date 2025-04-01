// ***********************************************************************
// Assembly         : GuiStracini.SDKBuilder
// Author           : Guilherme Branco Stracini
// Created          : 14/01/2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 15/01/2023
// ***********************************************************************
// <copyright file="IServiceFactorycs.cs" company="Guilherme Branco Stracini">
//     © 2019 - 2023 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace GuiStracini.SDKBuilder;

using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// The service factory interface.
/// </summary>
public interface IServiceFactory
{
    /// <summary>
    /// Heads the specified data.
    /// </summary>
    /// <typeparam name="TIn">The type of the in.</typeparam>
    /// <param name="data">The data.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>ValueTask&lt;TIn&gt;.</returns>
    ValueTask<TIn> Head<TIn>(TIn data, CancellationToken cancellationToken)
        where TIn : BaseRequest;

    /// <summary>
    /// Gets the specified data.
    /// </summary>
    /// <typeparam name="TIn">The type of the in.</typeparam>
    /// <param name="data">The data.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>ValueTask&lt;TIn&gt;.</returns>
    ValueTask<TIn> Get<TIn>(TIn data, CancellationToken cancellationToken)
        where TIn : BaseRequest;

    /// <summary>
    /// Gets the specified data.
    /// </summary>
    /// <typeparam name="TIn">The type of the in.</typeparam>
    /// <typeparam name="TOut">The type of the out.</typeparam>
    /// <param name="data">The data.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>ValueTask&lt;TOut&gt;.</returns>
    ValueTask<TOut> Get<TIn, TOut>(TIn data, CancellationToken cancellationToken)
        where TIn : BaseRequest
        where TOut : BaseResponse;

    /// <summary>
    /// Posts the specified data.
    /// </summary>
    /// <typeparam name="TIn">The type of the in.</typeparam>
    /// <param name="data">The data.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>ValueTask&lt;TIn&gt;.</returns>
    ValueTask<TIn> Post<TIn>(TIn data, CancellationToken cancellationToken)
        where TIn : BaseRequest;

    /// <summary>
    /// Posts the specified data.
    /// </summary>
    /// <typeparam name="TIn">The type of the in.</typeparam>
    /// <typeparam name="TOut">The type of the out.</typeparam>
    /// <param name="data">The data.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>ValueTask&lt;TOut&gt;.</returns>
    ValueTask<TOut> Post<TIn, TOut>(TIn data, CancellationToken cancellationToken)
        where TIn : BaseRequest
        where TOut : BaseResponse;

    /// <summary>
    /// Puts the specified data.
    /// </summary>
    /// <typeparam name="TIn">The type of the in.</typeparam>
    /// <param name="data">The data.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>ValueTask&lt;TIn&gt;.</returns>
    ValueTask<TIn> Put<TIn>(TIn data, CancellationToken cancellationToken)
        where TIn : BaseRequest;

    /// <summary>
    /// Puts the specified data.
    /// </summary>
    /// <typeparam name="TIn">The type of the in.</typeparam>
    /// <typeparam name="TOut">The type of the out.</typeparam>
    /// <param name="data">The data.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>ValueTask&lt;TOut&gt;.</returns>
    ValueTask<TOut> Put<TIn, TOut>(TIn data, CancellationToken cancellationToken)
        where TIn : BaseRequest
        where TOut : BaseResponse;

    /// <summary>
    /// Patches the specified data.
    /// </summary>
    /// <typeparam name="TIn">The type of the in.</typeparam>
    /// <param name="data">The data.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>ValueTask&lt;TIn&gt;.</returns>
    ValueTask<TIn> Patch<TIn>(TIn data, CancellationToken cancellationToken)
        where TIn : BaseResponse;

    /// <summary>
    /// Patches the specified data.
    /// </summary>
    /// <typeparam name="TIn">The type of the in.</typeparam>
    /// <typeparam name="TOut">The type of the out.</typeparam>
    /// <param name="data">The data.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>ValueTask&lt;TOut&gt;.</returns>
    ValueTask<TOut> Patch<TIn, TOut>(TIn data, CancellationToken cancellationToken)
        where TIn : BaseRequest
        where TOut : BaseResponse;

    /// <summary>
    /// Deletes the specified data.
    /// </summary>
    /// <typeparam name="TIn">The type of the in.</typeparam>
    /// <param name="data">The data.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>ValueTask&lt;TIn&gt;.</returns>
    ValueTask<TIn> Delete<TIn>(TIn data, CancellationToken cancellationToken)
        where TIn : BaseRequest;
}
