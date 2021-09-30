using System.Net;
using _MessagingClient = Telesign.MessagingClient;

namespace TelesignEnterprise
{
    using Telesign.Strategy;

    public class MessagingClient : _MessagingClient
    {
        public MessagingClient(string customerId,
            string apiKey)
            : base(customerId,
                apiKey)
        { }

        public MessagingClient(string customerId,
            string apiKey,
            string restEndpoint)
            : base(customerId,
                apiKey,
                restEndpoint)
        { }

        public MessagingClient(string customerId,
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