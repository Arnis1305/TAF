using Microsoft.Extensions.Configuration;
using Core.Enums;

namespace Core.AppSettings
{
    public static class ApplicationConfig
    {
        public static int ExplicitTimeout => Convert.ToInt32(TestConfigurationManager.GetConfigurationRoot().GetValue<string>("ApplicationConfig:ExplicitTimeout"));
        public static BrowserName BrowserName => Enum.Parse<BrowserName>(TestConfigurationManager.GetConfigurationRoot().GetValue<string>("ApplicationConfig:Browser"));
        public static string URL => new(TestConfigurationManager.GetConfigurationRoot().GetValue<string>("ApplicationConfig:URL"));
    }
}