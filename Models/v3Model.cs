using reCAPTCHAv3WithAspNetCoreDemo.Models.Configuration;
using System;

namespace reCAPTCHAv3WithAspNetCoreDemo.Models
{
    public class v3Model
    {
        public Guid Uid { get; set; }
        public string Action { get; set; }
        public string Language { get; set; }
        public CaptchaValidationSettings Settings { get; set; }
    }
}
