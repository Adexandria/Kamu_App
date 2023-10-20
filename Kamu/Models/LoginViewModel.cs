using Newtonsoft.Json;

namespace Kamu.Models
{
    public class LoginViewModel
    {
        [JsonProperty("email")]
        public string Email {get; set; }

         [JsonProperty("password")]
        public string Password {get; set; }
    }
}
