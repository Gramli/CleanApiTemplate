using Microsoft.AspNetCore.Mvc;
using Template.Api.Extensions;
using Template.Core.Abstractions;
using Template.Domain;

namespace Template.Api.EndpointBuilders
{
    public static class EndpointsBuilder
    {
        public static IEndpointRouteBuilder BuildEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
        {
            return endpointRouteBuilder
                .BuildHelloWorld();
        }

        private static IEndpointRouteBuilder BuildHelloWorld(this IEndpointRouteBuilder endpointRouteBuilder)
        {
            endpointRouteBuilder.MapPost("v1/helloWorld",
                async ([FromBody] HelloWorldRequest request, [FromServices] IHelloWorldRequestHandler handler, CancellationToken cancellationToken) =>
                    await handler.SendAsync(request, cancellationToken))
                        .Produces<bool>()
                        .WithName("HelloWorld")
                        .WithTags("Get");

            return endpointRouteBuilder;
        }
    }
}