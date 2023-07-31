using IDGS904_BD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_BD.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            using (AlumnoDbContext dbAlumno = new AlumnoDbContext())
            {
                return View(dbAlumno.Alumno.ToList());
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Alumno alumno) {
            using (AlumnoDbContext dbAlumno = new AlumnoDbContext())
            {
                dbAlumno.Alumno.Add(alumno);
                dbAlumno.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            using (AlumnoDbContext dbAlumno = new AlumnoDbContext())
            {
                var current = dbAlumno.Alumno.Find(id); ;
                if(current == null)
                {
                    return HttpNotFound();
                }
                
                return View(current);
            }
        }


        public ActionResult Edit(int? id)
        {
            using (AlumnoDbContext dbAlumno = new AlumnoDbContext())
            {
                var current = dbAlumno.Alumno.Find(id); ;
                if (current == null)
                {
                    return HttpNotFound();
                }

                return View(current);
            }
        }

        public ActionResult Edit(int? id, Alumno alummno)
        {
            using (AlumnoDbContext dbAlumno = new AlumnoDbContext())
            {
                if(ModelState.IsValid)
                {
                    dbAlumno.Entry(alummno).State = System.Data.Entity.EntityState.Modified;
                    dbAlumno.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(alummno);
            }
        }
    }
}