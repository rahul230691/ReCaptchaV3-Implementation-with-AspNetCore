using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using reCAPTCHAv3WithAspNetCoreDemo.Models.Captcha;
using reCAPTCHAv3WithAspNetCoreDemo.Models.Configuration;
using reCAPTCHAv3WithAspNetCoreDemo.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace reCAPTCHAv3WithAspNetCoreDemo.Services.Implementation
{
    public class CaptchaService : ICaptchaService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly CaptchaValidationSettings captchaValidationSettings;

        public CaptchaService(IHttpClientFactory httpClientFactory, IOptions<CaptchaValidationSettings> options)
        {
            this._httpClientFactory = httpClientFactory;
            this.captchaValidationSettings = options.Value;
        }

        public async Task<CaptchaTokenResponse> VerifyCaptcha(string token)
        {
            CaptchaTokenResponse captchaTokenResponse = null;
            using (var client = this._httpClientFactory.CreateClient())
            {
                var response = await client.GetStringAsync($"{this.captchaValidationSettings.VerifyAPI}?secret={this.captchaValidationSettings.SecretKey}&response={token}");
                captchaTokenResponse = JsonConvert.DeserializeObject<CaptchaTokenResponse>(response);
            }

            return captchaTokenResponse;
        }
    }
}
