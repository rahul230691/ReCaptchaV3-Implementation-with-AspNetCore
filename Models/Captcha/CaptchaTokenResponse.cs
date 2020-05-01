using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reCAPTCHAv3WithAspNetCoreDemo.Models.Captcha
{
    public class CaptchaTokenResponse
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; } = false;

        [JsonProperty(PropertyName = "score")]
        public decimal Score { get; set; }

        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        [JsonProperty(propertyName: "challenge_ts")]
        public DateTime ChallangeLoadTimestamp { get; set; }

        [JsonProperty(PropertyName = "hostname")]
        public string HostName { get; set; }

        [JsonProperty(PropertyName = "error-codes")]
        public List<string> ErrorCodes { get; set; }
    }
}
