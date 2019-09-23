// ***********************************************************************
// Assembly         : GuiStracini.Mandae
// Author           : Guilherme Branco Stracini
// Created          : 2018-01-10
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 2019-01-15
// ***********************************************************************
// <copyright file="IServiceFactory.cs" company="Guilherme Branco Stracini">
//     Copyright © 2018-2019 Guilherme Branco Stracini
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace GuiStracini.SDKBuilder
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The service factory interface.
    /// </summary>
    public interface IServiceFactory
    {
        /// <summary>
        /// Gets the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        Task<TIn> Get<TIn>(TIn data, CancellationToken token)
            where TIn : BaseRequest;

        /// <summary>
        /// Gets the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <typeparam name="TOut">The type of the out.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        Task<TOut> Get<TIn, TOut>(TIn data, CancellationToken token)
            where TIn : BaseRequest
            where TOut : BaseResponse;

        /// <summary>
        /// Posts the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        Task<TIn> Post<TIn>(TIn data, CancellationToken token)
            where TIn : BaseRequest;

        /// <summary>
        /// Posts the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <typeparam name="TOut">The type of the out.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        Task<TOut> Post<TIn, TOut>(TIn data, CancellationToken token)
            where TIn : BaseRequest
            where TOut : BaseResponse;

        /// <summary>
        /// Puts the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        Task<TIn> Put<TIn>(TIn data, CancellationToken token)
            where TIn : BaseRequest;

        /// <summary>
        /// Puts the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <typeparam name="TOut">The type of the out.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        Task<TOut> Put<TIn, TOut>(TIn data, CancellationToken token)
            where TIn : BaseRequest
            where TOut : BaseResponse;

        /// <summary>
        /// Patches the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        Task<TIn> Patch<TIn>(TIn data, CancellationToken token)
            where TIn : BaseResponse;

        /// <summary>
        /// Patches the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <typeparam name="TOut">The type of the out.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        Task<TOut> Patch<TIn, TOut>(TIn data, CancellationToken token)
            where TIn : BaseRequest
            where TOut : BaseResponse;

        /// <summary>
        /// Deletes the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        Task<TIn> Delete<TIn>(TIn data, CancellationToken token)
            where TIn : BaseRequest;

    }
}
