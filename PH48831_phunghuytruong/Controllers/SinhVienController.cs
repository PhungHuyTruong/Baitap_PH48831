using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using PH48831_phunghuytruong.Models;

namespace PH48831_phunghuytruong.Controllers
{
    public class SinhVienController : Controller
    {
        BaitapPh48831Context dbfirst;
        public SinhVienController(BaitapPh48831Context db)
        {
            dbfirst = db;
        }
        public IActionResult Index()
        {
            var sinhviens = dbfirst.SinhViens.ToList();
            return View(sinhviens);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SinhVien sv)
        {
            dbfirst.SinhViens.Add(sv);
            dbfirst.SaveChanges();
            return RedirectToAction("Index");
            return View(sv);
        }
        [HttpGet]
        public IActionResult Details(string id)
        {
            var sinhvien = dbfirst.SinhViens.Find(id);
            return View(sinhvien);
        }
        [HttpPost]
        public IActionResult Details(SinhVien sv)
        {
            dbfirst.SinhViens.ToList();
            return RedirectToAction("Index");
            return View(sv);
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            var editsv = dbfirst.SinhViens.Find(id);
            return View(editsv);
        }
        [HttpPost]
        public IActionResult Edit(SinhVien sv)
        {
            dbfirst.SinhViens.Update(sv);
            dbfirst.SaveChanges();
            return RedirectToAction("Index");
            return View(sv);
        }
        [HttpGet]
        public IActionResult Delete(string id)
        {
            var xoasv = dbfirst.SinhViens.Find(id);
            return View(xoasv);
        }
        [HttpPost]
        public IActionResult Delete(SinhVien sv)
        {
            dbfirst.SinhViens.Remove(sv);
            dbfirst.SaveChanges();
            return RedirectToAction("Index");
            return View(sv);
        }
    }
}
