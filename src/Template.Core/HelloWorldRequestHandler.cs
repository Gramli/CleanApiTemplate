using Template.Core.Abstractions;
using Template.Domain;
using Template.Domain.Http;

namespace Template.Core
{
    internal sealed class HelloWorldRequestHandler : IHelloWorldRequestHandler
    {
        public Task<HttpDataResponse<HelloWorldDto>> HandleAsync(HelloWorldRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
