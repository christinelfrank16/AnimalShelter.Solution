using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Controllers
{
    public class TypesController : Controller
    {
        private readonly AnimalShelterContext _db;

        public TypesController(AnimalShelterContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Type> model = _db.Types.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Type type)
        {
            _db.Types.Add(type);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}