using Kamu.Services.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace Kamu.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(HttpClient httpClient, AppConfiguration appConfiguration)
        {
            Client = httpClient;
            Client.BaseAddress = new Uri(appConfiguration.ClientConfiguration.BaseUrl);
        }
        protected readonly HttpClient Client;
    }
}
