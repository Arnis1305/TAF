using Microsoft.Extensions.Configuration;

namespace Core.AppSettings
{
    public class APIConfig
    {
        public int Timeout => Convert.ToInt32(TestConfigurationManager.GetConfigurationRoot().GetValue<string>("APIConfig:Timeout"));
        public string URL => new(TestConfigurationManager.GetConfigurationRoot().GetValue<string>("APIConfig:URL"));
    }
}