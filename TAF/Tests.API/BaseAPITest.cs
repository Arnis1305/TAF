using Core.API.Managers;
using Core.AppSettings;
using Core.API.ServiceHelpers;

namespace Tests.API
{
    public class BaseAPITest
    {
        protected ISessionManager SessionManager;
        protected UserServiceHelper UserServiceHelper;

        protected BaseAPITest()
        {
            APIConfig apiConfig = new APIConfig();
            SessionManager = new SessionManager(apiConfig);
            UserServiceHelper = new UserServiceHelper(SessionManager);
        }
    }
}