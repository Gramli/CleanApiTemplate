using Template.Domain;

namespace Template.Core.Abstractions
{
    public interface IHelloWorldRequestHandler : IRequestHandler<HelloWorldDto, HelloWorldRequest>
    {
    }
}
