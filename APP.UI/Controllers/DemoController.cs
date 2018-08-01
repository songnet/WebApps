using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using APP.UI.Models;

namespace APP.UI.Controllers
{
    public class DemoController : Controller
    {
        private Model1Container db = new Model1Container();

        // GET: Demo
        public ActionResult Index()
        {
            return View(db.sys_user.ToList());
        }

        // GET: Demo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sys_user sys_user = db.sys_user.Find(id);
            if (sys_user == null)
            {
                return HttpNotFound();
            }
            return View(sys_user);
        }

        // GET: Demo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Demo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,username,password,phone,sex,email,mark,rank,lastLogin,loginIp,imageUrl,regTime,locked,rights")] sys_user sys_user)
        {
            if (ModelState.IsValid)
            {
                db.sys_user.Add(sys_user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sys_user);
        }

        // GET: Demo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sys_user sys_user = db.sys_user.Find(id);
            if (sys_user == null)
            {
                return HttpNotFound();
            }
            return View(sys_user);
        }

        // POST: Demo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,username,password,phone,sex,email,mark,rank,lastLogin,loginIp,imageUrl,regTime,locked,rights")] sys_user sys_user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sys_user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sys_user);
        }

        // GET: Demo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sys_user sys_user = db.sys_user.Find(id);
            if (sys_user == null)
            {
                return HttpNotFound();
            }
            return View(sys_user);
        }

        // POST: Demo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sys_user sys_user = db.sys_user.Find(id);
            db.sys_user.Remove(sys_user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
