using System.Net;
using _VoiceClient = Telesign.VoiceClient;

namespace TelesignEnterprise
{
    using System.Net.Http;
    using Telesign.Strategy;

    public class VoiceClient : _VoiceClient
    {
        public VoiceClient(string customerId,
            string apiKey)
            : base(customerId,
                apiKey)
        { }

        public VoiceClient(string customerId,
            string apiKey,
            string restEndpoint)
            : base(customerId,
                apiKey,
                restEndpoint)
        { }

        public VoiceClient(string customerId,
            string apiKey,
            string restEndpoint,
            int timeout,
            WebProxy proxy,
            string proxyUsername,
            string proxyPassword,
            IHeadersStrategy strategy = null,
            HttpClient client = null)
            : base(customerId,
                apiKey,
                restEndpoint,
                timeout,
                proxy,
                proxyUsername,
                proxyPassword,
                strategy,
                client)
        { }    
        
    }
}