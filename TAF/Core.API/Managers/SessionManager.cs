using Core.AppSettings;
using RestSharp;

namespace Core.API.Managers
{
    public class SessionManager : ISessionManager
    {
        private readonly APIConfig apiConfig;
        public SessionManager(APIConfig apiConfig)
        {
            this.apiConfig = apiConfig;
        }
        public RestClient RestClient
        {
            get
            {
                var restClient = new RestClient(new RestClientOptions { MaxTimeout = apiConfig.Timeout, BaseUrl = new System.Uri(apiConfig.URL) });

                return restClient;
            }
        }

        public RestRequest RestRequest
        {
            get
            {
                var restRequest = new RestRequest
                {
                    Timeout = apiConfig.Timeout
                };

                return restRequest;
            }
        }
    }
}