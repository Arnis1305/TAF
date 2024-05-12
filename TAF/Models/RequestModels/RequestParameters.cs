using Newtonsoft.Json;

namespace Models.RequestModels
{
    public class RequestParameters
    {
        public static string PutParameters
        {
            get
            {
                var body = new RequestModel()
                {
                    Name = "morpheus",
                    Job = "zion resident"
                };

                return JsonConvert.SerializeObject(body);
            }

        }

        public static string PostParameters
        {
            get
            {
                var body = new RequestModel()
                {
                    Name = "morpheus",
                    Job = "leader"
                };

                return JsonConvert.SerializeObject(body);
            }

        }
    }
}