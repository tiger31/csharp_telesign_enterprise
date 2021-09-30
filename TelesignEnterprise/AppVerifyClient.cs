using System.Net;
using _AppVerifyClient = Telesign.AppVerifyClient;

namespace TelesignEnterprise
{
    using Telesign.Strategy;

    public class AppVerifyClient : _AppVerifyClient
    {
        public AppVerifyClient(string customerId,
            string apiKey)
            : base(customerId,
                apiKey)
        { }

        public AppVerifyClient(string customerId,
            string apiKey,
            string restEndpoint)
            : base(customerId,
                apiKey,
                restEndpoint)
        { }

        public AppVerifyClient(string customerId,
            string apiKey,
            string restEndpoint,
            int timeout,
            IWebProxy proxy,
            string proxyUsername,
            string proxyPassword,
            IHeadersStrategy strategy = null)
            : base(customerId,
                apiKey,
                restEndpoint,
                timeout,
                proxy,
                proxyUsername,
                proxyPassword,
                strategy)
        { }
    }
}