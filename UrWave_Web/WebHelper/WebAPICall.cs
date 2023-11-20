namespace UrWave_Web.WebHelper
{
    public static class WebAPICall
    {
        private static IConfiguration config;
        public static IConfiguration Configuration
        {
            get
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
                config = builder.Build();
                return config;
            }
        }
        public static string GetAPICall(APIEnum controllerName)
        {
            var BackEndURl = Configuration.GetSection("BackEndURl").Value;
            //get URL From AppSettings
            var link = string.Concat(BackEndURl, "/api/", controllerName);
            return link;
        }
    }
}
