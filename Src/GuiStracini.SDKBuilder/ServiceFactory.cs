namespace GuiStracini.SDKBuilder;

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
    /// <param name="cancellationToken">The cancellationToken.</param>
    /// <returns></returns>
    private static async Task<TOut> ExecuteAsync<TIn, TOut>(ActionMethod method, TIn requestObject,
        CancellationToken cancellationToken) where TIn : BaseRequest
    {
        cancellationToken.ThrowIfCancellationRequested();
        await Task.Delay(1000, cancellationToken);
        return default;
    }

    #endregion

    #region Implementation of IServiceFactory

    /// <inheritdoc />
    public async ValueTask<TIn> Head<TIn>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest
    {
        return await ExecuteAsync<TIn, TIn>(ActionMethod.HEAD, data, cancellationToken);
    }

    /// <inheritdoc />
    public async ValueTask<TIn> Get<TIn>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest
    {
        return await Task.FromResult(data);
    }

    /// <inheritdoc />
    public async ValueTask<TOut> Get<TIn, TOut>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest where TOut : BaseResponse
    {
        return await Task.FromResult((TOut)null);
    }

    /// <inheritdoc />
    public async ValueTask<TIn> Post<TIn>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest
    {
        return await Task.FromResult(data);
    }

    /// <inheritdoc />
    public async ValueTask<TOut> Post<TIn, TOut>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest where TOut : BaseResponse
    {
        return await Task.FromResult((TOut)null);
    }

    /// <inheritdoc />
    public async ValueTask<TIn> Put<TIn>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest
    {
        return await Task.FromResult(data);
    }

    /// <inheritdoc />
    public async ValueTask<TOut> Put<TIn, TOut>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest where TOut : BaseResponse
    {
        return await Task.FromResult((TOut)null);
    }

    /// <inheritdoc />
    public async ValueTask<TIn> Patch<TIn>(TIn data, CancellationToken cancellationToken) where TIn : BaseResponse
    {
        return await Task.FromResult(data);
    }

    /// <inheritdoc />
    public async ValueTask<TOut> Patch<TIn, TOut>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest where TOut : BaseResponse
    {
        return await Task.FromResult((TOut)null);
    }

    /// <inheritdoc />
    public async ValueTask<TIn> Delete<TIn>(TIn data, CancellationToken cancellationToken) where TIn : BaseRequest
    {
        return await Task.FromResult(data);
    }

    #endregion
}