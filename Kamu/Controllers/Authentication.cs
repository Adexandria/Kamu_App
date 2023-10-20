using Kamu.Models;
using Kamu.Services.Utilities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Kamu.Controllers
{
    public class Authentication : BaseController
    {
        public Authentication(HttpClient httpClient, AppConfiguration appConfiguration) : base(httpClient, appConfiguration)
        {
        }

        [HttpPost()]
        public async Task<IActionResult> Login(LoginViewModel loginDTO)
        {
            var response = await Client.PostAsync("api/authentication/sign-in", JsonContent.Create(loginDTO));
            var responseContent = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Response<LoginDto>>(responseContent);
            if(result.NotSuccessful)
                return RedirectToAction("Index", "Home");

            return RedirectToAction("Dashboard","Home");
        }


        [HttpPost]
        public IActionResult CreateUser(SignUpViewModel signUpDTO)
        {
            Console.WriteLine(signUpDTO.Email);
            return RedirectToAction("Dashboard","Home");
        }
    }
}
