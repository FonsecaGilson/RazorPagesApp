namespace RazorPagesApp.HttpClient
{
    class AuthHeadersHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("UsuarioId", "123");

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
