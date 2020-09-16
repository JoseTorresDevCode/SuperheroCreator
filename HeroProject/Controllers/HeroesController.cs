using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeroProject.Data;
using HeroProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeroProject.Controllers
{
    public class HeroesController : Controller

        
    {
        private readonly ApplicationDbContext _db;
        public HeroesController(ApplicationDbContext context)
        {
            _db = context;
        }

        // GET: Heroes
        public ActionResult Index()//default view
        {
            //query for the heroes you want to display
            //pass that var to the view
            var superheroes = _db.Heroes;
            return View(superheroes);
        }

        // GET: Heroes/Details/5
        public ActionResult Details(int id)
        {
            //query the db to find the hero with the correct id
            var hero = _db.Heroes.Where(a => a.Id == id).FirstOrDefault();
            return View();
        }

        // GET: Heroes/Create
        public ActionResult Create()
        {
            SuperHero superhero = new SuperHero();
            return View(superhero);
        }

        // POST: Heroes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHero superhero)
        {
            try
            {
                _db.Heroes.Add(superhero);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Heroes/Edit/5
        public ActionResult Edit(int id)
        {
            var editHero = _db.Heroes.Where(h => h.Id == id).FirstOrDefault();
            return View(editHero);
        }
         
        // POST: Heroes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SuperHero superhero)
        {
            try
            {
                _db.Heroes.Update(superhero);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Heroes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Heroes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
