using Core.API.Managers;

namespace Core.API
{
    public class BaseService
    {
        protected readonly ISessionManager SessionManager;

        public BaseService(ISessionManager sessionManager)
        {
            SessionManager = sessionManager;
        }
    }
}