using SuperHeroCala.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroCala.Controllers
{
    public class SuperHeroController : Controller
    {
        ApplicationDbContext context;
        public SuperHeroController()
        {
            context = new ApplicationDbContext();
        }
        // GET: SuperHero
        public ActionResult Index()
        {
            List<SuperHero> superHeroes = context.SuperHeroes.ToList();
            return View(superHeroes);
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperHero/Create
        public ActionResult Create()
        {
            SuperHero superHero = new SuperHero();
            return View(superHero);
        }

        // POST: SuperHero/Create
        [HttpPost]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                // TODO: Add insert logic here
                context.SuperHeroes.Add(superHero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHero superhero = context.SuperHeroes.Where(s => s.ID == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SuperHero superHero)
        {
            try
            {
                // TODO: Add update logic here
                SuperHero dbsuperhero = context.SuperHeroes.Where(s => s.ID == id).FirstOrDefault();
                dbsuperhero.superHeroName = superHero.superHeroName;
                dbsuperhero.alterEgo = superHero.alterEgo;
                dbsuperhero.primarySuperHeroAbility = superHero.primarySuperHeroAbility;
                dbsuperhero.secondarySuperHeroAbility = superHero.secondarySuperHeroAbility;
                dbsuperhero.catchPhrase = superHero.catchPhrase;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int id)
        {
            SuperHero superhero = context.SuperHeroes.Where(s => s.ID == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: SuperHero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SuperHero superHero)
        {
            try
            {
                superHero = context.SuperHeroes.Where(s => s.ID == id).FirstOrDefault();
                context.SuperHeroes.Remove(superHero);
                context.SaveChanges();
                return View();
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
