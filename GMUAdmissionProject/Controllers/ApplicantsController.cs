using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GMUAdmissionProject.DAL;

namespace GMUAdmissionProject.Controllers
{
    
    public class ApplicantsController : Controller
    {
        private AdmissionsDBContext db = new AdmissionsDBContext();

        // GET: Applicants
        public ActionResult Index(string search)
        {
            if (!String.IsNullOrEmpty(search))
            {
                var aSSN = db.Applicants.Where(n => n.SSN == search);

                return View(aSSN.ToList());
            }
            else
            {
                return View(db.Applicants.ToList());
            }
        }

        // GET: Applicants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // GET: Applicants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Applicants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include =
            "Id,FirstName,MiddleName,LastName,SSN,Email,Phone,Street,City,State,Zipcode,DOB,Gender,HSName,HSCity,GradDate,GPA,MthScore,VerbScore,AreaOfInterest,StuType,EnrollDate,EnrollYear,SubDate")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                Applicant matchingApplicant = db.Applicants.Where(cm => string.Compare(cm.SSN, applicant.SSN, true) == 0).FirstOrDefault();

                if(applicant == null)
                {
                    return HttpNotFound();
                }

                if(matchingApplicant != null)
                {
                    ModelState.AddModelError("SSN", "This student has already registered.");
                    return View(applicant);
                }

                if(applicant.GPA < 3)
                {
                    ModelState.AddModelError("GPA", "GPA must be at least 3.00");
                    return View(applicant);
                }
                else if(applicant.MthScore + applicant.VerbScore < 1000)
                    {
                        ModelState.AddModelError(string.Empty, "Total SAT score must be at least 1000.");
                        return View(applicant);
                    }

                db.Applicants.Add(applicant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(applicant);
        }

        [Authorize]
        // GET: Applicants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        [Authorize]
        // POST: Applicants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,MiddleName,LastName,SSN,Email,Phone,Street,City,State,Zipcode,DOB,Gender,HSName,HSCity,GradDate,GPA,MthScore,VerbScore,AreaOfInterest,StuType,EnrollDate,EnrollYear,SubDate,AdDecision")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(applicant);
        }

        [Authorize]
        // GET: Applicants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        [Authorize]
        // POST: Applicants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Applicant applicant = db.Applicants.Find(id);
            db.Applicants.Remove(applicant);
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
