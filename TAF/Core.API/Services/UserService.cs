using Core.API.Managers;
using RestSharp;

namespace Core.API.Services
{
    public class UserService : BaseService
    {
        public UserService(ISessionManager sessionManager) : base(sessionManager)
        {
        }

        public RestResponse GetSingleUserInfo(int userNumber)
        {
            var client = SessionManager.RestClient;
            var request = SessionManager.RestRequest;

            request.Resource = $"/api/users/{userNumber}";
            request.Method = Method.Get;

            return client.Execute(request);
        }

        public RestResponse PutSingleInfo(int userNumber)
        {
            var client = SessionManager.RestClient;
            var request = SessionManager.RestRequest;

            request.Method = Method.Put;
            request.Resource = $"/api/users/{userNumber}";

            request.AddParameter("application/json", Models.RequestModels.RequestParameters.PutParameters, ParameterType.RequestBody);

            return client.Execute(request);
        }

        public RestResponse PostSingleInfo(int userNumber)
        {
            var client = SessionManager.RestClient;
            var request = SessionManager.RestRequest;

            request.Method = Method.Post;
            request.Resource = $"/api/users/{userNumber}";

            request.AddParameter("application/json", Models.RequestModels.RequestParameters.PostParameters, ParameterType.RequestBody);

            return client.Execute(request);
        }
    }
}