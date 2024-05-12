using System.Text.Json;
using Core.API.Services;
using Core.API.Managers;
using Models;
using System.Net;

namespace Core.API.ServiceHelpers
{
    public class UserServiceHelper : BaseServiceHelper
    {
        private readonly UserService userService;

        public UserServiceHelper(ISessionManager sessionManager) : base(sessionManager)
        {
            userService = new UserService(sessionManager);
        }

        public UserData GetSingleUserInfo(int userNumber)
        {
            var response = userService.GetSingleUserInfo(userNumber);

            return JsonSerializer.Deserialize<UserData>(response.Content);
        }

        public WorkerData PutSingleUserInformation(int number)
        {
            var response = userService.PutSingleInfo(number);

            return JsonSerializer.Deserialize<WorkerData>(response.Content);
        }

        public WorkerData PostSingleUserInformation(int number)
        {
            var response = userService.PostSingleInfo(number);

            return JsonSerializer.Deserialize<WorkerData>(response.Content);
        }

        public HttpStatusCode GetSingleUserNotFoundResponseCode(int userNumber)
        {
            var response = userService.GetSingleUserInfo(userNumber);

            return response.StatusCode;
        }
    }
}