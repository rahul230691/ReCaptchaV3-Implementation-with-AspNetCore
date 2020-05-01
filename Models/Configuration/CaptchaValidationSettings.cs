using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reCAPTCHAv3WithAspNetCoreDemo.Models.Configuration
{
    public class CaptchaValidationSettings
    {
        public string VerifyAPI { get; set; }
        public string SiteKey { get; set; }
        public string SecretKey { get; set; }
    }
}
