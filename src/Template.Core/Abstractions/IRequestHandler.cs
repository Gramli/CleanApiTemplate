using Template.Domain.Http;

namespace Template.Core.Abstractions
{
    public interface IRequestHandler<TResponse, in TRequest>
    {
        Task<HttpDataResponse<TResponse>> HandleAsync(TRequest request, CancellationToken cancellationToken);
    }
}