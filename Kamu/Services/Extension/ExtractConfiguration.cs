using Kamu.Services.Utilities;

namespace Kamu.Services.Extension
{
    public static class ExtractConfiguration
    {
        private static ClientConfiguration ExtractClientSettings(IConfiguration configuration)
        {
            return configuration.GetSection("ClientSettings")
                .Get<ClientConfiguration>();
        }

        public static AppConfiguration ExtractAppSettings(this IConfiguration configuration)
        {
            return new AppConfiguration
            {
                ClientConfiguration = ExtractClientSettings(configuration)
            };
        }
    }
}
