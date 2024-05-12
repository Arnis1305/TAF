using Core.API.Managers;

namespace Core.API
{
    public class BaseServiceHelper
    {
        protected BaseService BaseService { get; set; }

        public BaseServiceHelper(ISessionManager sessionManager)
        {
            BaseService = new BaseService(sessionManager);
        }
    }
}