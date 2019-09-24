namespace GuiStracini.SDKBuilder
{
    using System.Threading;
    using System.Threading.Tasks;

    public class ServiceFactory : IServiceFactory
    {
        #region Private fields


        #endregion

        #region ~Ctors


        #endregion

        #region Private methods

        /// <summary>
        /// Executes the asynchronous.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <typeparam name="TOut">The type of the out.</typeparam>
        /// <param name="method">The method.</param>
        /// <param name="requestObject">The request object.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        private async Task<TOut> ExecuteAsync<TIn, TOut>(ActionMethod method, TIn requestObject,
            CancellationToken token) where TIn : BaseRequest
        {
            token.ThrowIfCancellationRequested();
            await Task.Delay(1000, token);
            return default;
        }

        #endregion

        #region Implementation of IServiceFactory

        /// <inheritdoc />
        public async ValueTask<TIn> Head<TIn>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async ValueTask<TIn> Get<TIn>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async ValueTask<TOut> Get<TIn, TOut>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest where TOut : BaseResponse
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async ValueTask<TIn> Post<TIn>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async ValueTask<TOut> Post<TIn, TOut>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest where TOut : BaseResponse
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async ValueTask<TIn> Put<TIn>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async ValueTask<TOut> Put<TIn, TOut>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest where TOut : BaseResponse
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async ValueTask<TIn> Patch<TIn>(TIn data, CancellationToken cancellationToken) where TIn : BaseResponse
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async ValueTask<TOut> Patch<TIn, TOut>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest where TOut : BaseResponse
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async ValueTask<TIn> Delete<TIn>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
