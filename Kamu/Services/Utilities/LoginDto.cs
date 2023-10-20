using Newtonsoft.Json;

namespace Kamu.Services.Utilities
{
    public class LoginDto
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("organisationId")]
        public string OrganisationId { get; set; }
    }
}
