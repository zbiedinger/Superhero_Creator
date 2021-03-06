﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperheroCreator.Models;
using SuperheroCreator.Data;

namespace SuperheroCreator.Controllers
{
    public class SuperheroController : Controller
    {
        private ApplicationDbContext _context;
        public SuperheroController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SuperheroController
        public ActionResult Index()
        {
            var heros = _context.Superheroes.ToList();
            return View(heros);
        }

        // GET: SuperheroController/Details/5
        public ActionResult Details(int id)
        {
            var herodetails = _context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(herodetails);
        }

        // GET: SuperheroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperheroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                _context.Superheroes.Add(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperheroController/Edit/5
        public ActionResult Edit(int id)
        {
            var editedHero = _context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(editedHero);
        }

        // POST: SuperheroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Superhero superhero)
        {
            try
            {
                var editedHero = _context.Superheroes.Where(s => s == superhero).FirstOrDefault();
                editedHero.Name = superhero.Name;
                editedHero.AlterEgoFirstName = superhero.AlterEgoFirstName;
                editedHero.AlterEgoLastName = superhero.AlterEgoLastName;
                editedHero.Ability = superhero.Ability;
                editedHero.SecondAbility = superhero.SecondAbility;
                editedHero.Catchphrase = superhero.Catchphrase;

                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperheroController/Delete/5
        public ActionResult Delete(int id)
        {
            var person = _context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(person);
        }

        // POST: SuperheroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Superhero superhero)
        {
            try
            {
                var deletedhero = _context.Superheroes.Where(s => s == superhero).FirstOrDefault();
                _context.Superheroes.Remove(deletedhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
