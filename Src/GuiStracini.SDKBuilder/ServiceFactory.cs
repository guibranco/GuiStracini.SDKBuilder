// ***********************************************************************
// Assembly         : GuiStracini.SDKBuilder
// Author           : Guilherme Branco Stracini
// Created          : 14/01/2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 15/01/2023
// ***********************************************************************
// <copyright file="ServiceFactory.cs" company="Guilherme Branco Stracini">
//     © 2019 - 2023 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace GuiStracini.SDKBuilder
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Class ServiceFactory.
    /// Implements the <see cref="GuiStracini.SDKBuilder.IServiceFactory" />
    /// </summary>
    /// <seealso cref="GuiStracini.SDKBuilder.IServiceFactory" />
    public class ServiceFactory : IServiceFactory
    {
        #region Private methods

        /// <summary>
        /// Executes the asynchronous.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <typeparam name="TOut">The type of the out.</typeparam>
        /// <param name="method">The method.</param>
        /// <param name="requestObject">The request object.</param>
        /// <param name="cancellationToken">The cancellationToken.</param>
        /// <returns>A Task&lt;TOut&gt; representing the asynchronous operation.</returns>
        private static async Task<TOut> ExecuteAsync<TIn, TOut>(
            ActionMethod method,
            TIn requestObject,
            CancellationToken cancellationToken
        ) where TIn : BaseRequest
        {
            cancellationToken.ThrowIfCancellationRequested();
            await Task.Delay(1000, cancellationToken);
            return default;
        }

        #endregion

        #region Implementation of IServiceFactory

        /// <inheritdoc />
        public async ValueTask<TIn> Head<TIn>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest
        {
            return await ExecuteAsync<TIn, TIn>(ActionMethod.HEAD, data, cancellationToken);
        }

        /// <inheritdoc />
        public async ValueTask<TIn> Get<TIn>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest
        {
            return await Task.FromResult(data);
        }

        /// <inheritdoc />
        public async ValueTask<TOut> Get<TIn, TOut>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest
            where TOut : BaseResponse
        {
            return await Task.FromResult((TOut)null);
        }

        /// <inheritdoc />
        public async ValueTask<TIn> Post<TIn>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest
        {
            return await Task.FromResult(data);
        }

        /// <inheritdoc />
        public async ValueTask<TOut> Post<TIn, TOut>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest
            where TOut : BaseResponse
        {
            return await Task.FromResult((TOut)null);
        }

        /// <inheritdoc />
        public async ValueTask<TIn> Put<TIn>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest
        {
            return await Task.FromResult(data);
        }

        /// <inheritdoc />
        public async ValueTask<TOut> Put<TIn, TOut>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest
            where TOut : BaseResponse
        {
            return await Task.FromResult((TOut)null);
        }

        /// <inheritdoc />
        public async ValueTask<TIn> Patch<TIn>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseResponse
        {
            return await Task.FromResult(data);
        }

        /// <inheritdoc />
        public async ValueTask<TOut> Patch<TIn, TOut>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest
            where TOut : BaseResponse
        {
            return await Task.FromResult((TOut)null);
        }

        /// <inheritdoc />
        public async ValueTask<TIn> Delete<TIn>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest
        {
            return await Task.FromResult(data);
        }

        #endregion
    }
}
