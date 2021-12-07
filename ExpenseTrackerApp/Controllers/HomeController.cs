using ExpenseTrackerApp.Models;
using ExpenseTrackerWebApp.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTrackerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "ExpenseTrackerReport");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [RequestSizeLimit(5000000)]
        public async Task<IActionResult> ImageUpload(IFormFile file)
        {
            try
            {
                string image;

                var guid = Guid.NewGuid();
                var filePath = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot/upload",
                            guid + Path.GetExtension(file.FileName));
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                image = guid + Path.GetExtension(file.FileName);
                ApplicationUser appUser = await _userManager.GetUserAsync(User);
                if (appUser.Image != null && System.IO.File.Exists("wwwroot/upload/" + appUser.Image))
                {
                    System.IO.File.Delete("wwwroot/upload/" + appUser.Image);
                }
                appUser.Image = image;
                await _userManager.UpdateAsync(appUser);

                return Ok();
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
