using Newtonsoft.Json;

namespace Kamu.Services.Utilities
{
    public class Response<T> where T : class
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("errors")]
        public List<string> Errors { get; set; }

        [JsonProperty("isSuccessful")]
        public bool IsSuccessful { get; set; }

        [JsonProperty("notSuccessful")]
        public bool NotSuccessful { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
