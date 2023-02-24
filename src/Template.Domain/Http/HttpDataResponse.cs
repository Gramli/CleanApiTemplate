using System.Net;

namespace Template.Domain.Http
{
    public sealed class HttpDataResponse<T> : DataResponse<T>
    {
        public HttpStatusCode StatusCode { get; init; }

    }
}
