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
        /// Heads the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        ValueTask<TIn> Head<TIn>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest;

        /// <summary>
        /// Gets the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        ValueTask<TIn> Get<TIn>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest;

        /// <summary>
        /// Gets the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <typeparam name="TOut">The type of the out.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        ValueTask<TOut> Get<TIn, TOut>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest
            where TOut : BaseResponse;

        /// <summary>
        /// Posts the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        ValueTask<TIn> Post<TIn>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest;

        /// <summary>
        /// Posts the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <typeparam name="TOut">The type of the out.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        ValueTask<TOut> Post<TIn, TOut>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest
            where TOut : BaseResponse;

        /// <summary>
        /// Puts the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        ValueTask<TIn> Put<TIn>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest;

        /// <summary>
        /// Puts the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <typeparam name="TOut">The type of the out.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        ValueTask<TOut> Put<TIn, TOut>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest
            where TOut : BaseResponse;

        /// <summary>
        /// Patches the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        ValueTask<TIn> Patch<TIn>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseResponse;

        /// <summary>
        /// Patches the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <typeparam name="TOut">The type of the out.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        ValueTask<TOut> Patch<TIn, TOut>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest
            where TOut : BaseResponse;

        /// <summary>
        /// Deletes the specified data.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        ValueTask<TIn> Delete<TIn>(TIn data, CancellationToken cancellationToken)
            where TIn : BaseRequest;
    }
}
