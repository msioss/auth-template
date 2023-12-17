using AuthSystem.Areas.Identity.Data;
using AuthSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AuthSystem.Areas.Identity.Data.DbContext;
using AuthSystem.Areas.Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, 
            UserManager<User> userManager, 
            SignInManager<User> signInManager, 
            ApplicationDbContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["UserID"]=_userManager.GetUserId(this.User);
            return View();
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            var userId = _userManager.GetUserId(this.User);

            var lastAccessLog = await _context.AccessLogs.OrderBy(x=>x.Id).LastAsync(x => x.UserId == userId);
            lastAccessLog.LogOutTime = DateTime.UtcNow;
            
            _context.AccessLogs.Update(lastAccessLog);
            await _context.SaveChangesAsync();
            
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}