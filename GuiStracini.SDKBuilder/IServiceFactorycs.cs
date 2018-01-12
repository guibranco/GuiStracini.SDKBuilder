// ***********************************************************************
// Assembly         : GuiStracini.Mandae
// Author           : Guilherme Branco Stracini
// Created          : 10/01/2018
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 10/01/2018
// ***********************************************************************
// <copyright file="IServiceFactory.cs" company="Guilherme Branco Stracini">
//     Copyright © 2018 Guilherme Branco Stracini
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace GuiStracini.SDKBuilder
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IServiceFactory
    {
        Task<TIn> Get<TIn>(TIn data, CancellationToken token) where TIn : BaseRequest;

        Task<TOut> Get<TIn, TOut>(TIn data, CancellationToken token) where TIn : BaseRequest where TOut : BaseResponse;

        Task<TIn> Post<TIn>(TIn data, CancellationToken token) where TIn : BaseRequest;

        Task<TOut> Post<TIn, TOut>(TIn data, CancellationToken token) where TIn : BaseRequest where TOut : BaseResponse;

        Task<TIn> Put<TIn>(TIn data, CancellationToken token) where TIn : BaseRequest;

        Task<TOut> Put<TIn, TOut>(TIn data, CancellationToken token) where TIn : BaseRequest where TOut : BaseResponse;



    }
}
