using Microsoft.Extensions.Configuration;
using System.IO;


namespace BasicSelenium_Project.Configuration
{
    static class ConfigurationProviders
    {
        public static IConfiguration GetValue { get; }
        static ConfigurationProviders()
        {
            GetValue = new ConfigurationBuilder()
                .SetBasePath($"{Directory.GetCurrentDirectory()}/Configuration")
                .AddJsonFile("AppSettings.json")
                .Build();
        }
    }
}



