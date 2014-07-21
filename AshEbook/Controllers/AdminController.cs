using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AshEbook.Models;
using PagedList;

namespace AshEbook.Controllers
{

    [Authorize]
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();
        private readonly int _pageSize = int.Parse(ConfigurationManager.AppSettings["PageSize"]);

        public ActionResult Index(int ? page)
        {
            var pagenumber = page ?? 1;

            var books = _db.Books.OrderBy(x => x.Id).ToPagedList(pagenumber, _pageSize);

            return View(books);
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            var book = _db.Books.Find(id);

            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Add(book);

                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            var book = _db.Books.Find(id);

            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(book).State = EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            var book = _db.Books.Find(id);

            if (book == null)
            {
                return HttpNotFound();
            }

            _db.Books.Remove(book);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
 
    }
}
