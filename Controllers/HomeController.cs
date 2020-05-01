using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using reCAPTCHAv3WithAspNetCoreDemo.Models;
using reCAPTCHAv3WithAspNetCoreDemo.Services.Interface;

namespace reCAPTCHAv3WithAspNetCoreDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICaptchaService _captchaService;

        public HomeController(ILogger<HomeController> logger, ICaptchaService captchaService)
        {
            this._logger = logger;
            this._captchaService = captchaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

        public async Task<JsonResult> VerifyCaptcha(string token)
        {
            var response = await this._captchaService.VerifyCaptcha(token);
            return Json(response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
