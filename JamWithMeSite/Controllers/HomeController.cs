using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JamWithMeSite.Models;
using Microsoft.AspNetCore.Authorization;

namespace JamWithMeSite.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// If user is logged in, they are given access to the 
        /// listings. 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToAction("WelcomeUserPage");
            }
            return View();
        }

        /// <summary>
        /// Must be logged in to view the Privacy Policy
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        /// <summary>
        /// Once the user is logged in. They are directed to this page.
        /// </summary>
        /// <returns></returns>
        public IActionResult WelcomeUserPage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
