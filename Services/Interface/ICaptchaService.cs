using reCAPTCHAv3WithAspNetCoreDemo.Models.Captcha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reCAPTCHAv3WithAspNetCoreDemo.Services.Interface
{
    public interface ICaptchaService
    {
        Task<CaptchaTokenResponse> VerifyCaptcha(string token);
    }
}
