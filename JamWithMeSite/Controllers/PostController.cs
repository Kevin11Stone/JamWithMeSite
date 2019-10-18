﻿using System;
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


        /// <summary>
        /// Displays list of musicians.
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            List<Musician> musicanList = await MusicianDatabase.GetAllMusicians(_context);

            return View(musicanList);
        }



        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        public async Task<IActionResult> Add(Musician m)
        {
            if (ModelState.IsValid)
            {
                // add to database
                await MusicianDatabase.Add(m, _context);
                return RedirectToAction("Index");
            }

            return View(m);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Musician m = await MusicianDatabase.GetMusicianById(id, _context);
            return View(m);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await MusicianDatabase.Delete(id, _context);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            Musician selectedMusician = await MusicianDatabase.GetMusicianById(id, _context);
            return View(selectedMusician);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Musician m)
        {
            if (ModelState.IsValid)
            {
                await MusicianDatabase.UpdatePost(m, _context);
                return RedirectToAction("Index");
            }

            return View(m);
        }



    }
}