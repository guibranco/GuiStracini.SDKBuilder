namespace GuiStracini.SDKBuilder
{
    using Enums;
    using System.Threading;
    using System.Threading.Tasks;

    public class ServiceFactory : IServiceFactory
    {
        #region Private fields


        #endregion

        #region ~Ctors


        #endregion

        #region Private methods

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
        public Task<TIn> Get<TIn>(TIn data, CancellationToken token) where TIn : BaseRequest
        {
            return ExecuteAsync<TIn, TIn>(ActionMethod.GET, data, token);

        }

        /// <inheritdoc />
        public Task<TOut> Get<TIn, TOut>(TIn data, CancellationToken token) where TIn : BaseRequest where TOut : BaseResponse
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<TIn> Post<TIn>(TIn data, CancellationToken token) where TIn : BaseRequest
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<TOut> Post<TIn, TOut>(TIn data, CancellationToken token) where TIn : BaseRequest where TOut : BaseResponse
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<TIn> Put<TIn>(TIn data, CancellationToken token) where TIn : BaseRequest
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<TOut> Put<TIn, TOut>(TIn data, CancellationToken token) where TIn : BaseRequest where TOut : BaseResponse
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<TIn> Patch<TIn>(TIn data, CancellationToken token) where TIn : BaseResponse
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<TOut> Patch<TIn, TOut>(TIn data, CancellationToken token) where TIn : BaseRequest where TOut : BaseResponse
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<TIn> Delete<TIn>(TIn data, CancellationToken token) where TIn : BaseRequest
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
