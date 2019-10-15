using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JamWithMeSite.Data;
using JamWithMeSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace JamWithMeSite.Controllers
{
    public class PostController : Controller
    {

        private readonly ApplicationDbContext _context;

        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }


        
        public async Task<IActionResult> Index()
        {
            List<Musician> musicanList = await MusicianDatabase.GetAllMusicians(_context);

            return View(musicanList);
        }
    }
}