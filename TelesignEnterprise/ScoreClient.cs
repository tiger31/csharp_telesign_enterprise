using System.Net;
using _ScoreClient = Telesign.ScoreClient;

namespace TelesignEnterprise
{
    using Telesign.Strategy;

    public class ScoreClient : _ScoreClient
    {
        public ScoreClient(string customerId,
            string apiKey)
            : base(customerId,
                apiKey)
        { }

        public ScoreClient(string customerId,
            string apiKey,
            string restEndpoint)
            : base(customerId,
                apiKey,
                restEndpoint)
        { }

        public ScoreClient(string customerId,
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