using _CoreDepartmanWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace _CoreDepartmanWeb.Controllers
{
    public class DepartmanController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            ViewBag.baslik = "Departmanlar";
            var degerler = c.Departmanlars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniDepartmanEkle() 
        {
            ViewBag.baslik = "Yeni Departman Ekle";

            return View();
        }
        [HttpPost]
        public IActionResult YeniDepartmanEkle(Departmanlar d )
        {
            c.Departmanlars.Add( d );
            c.SaveChanges();
            return RedirectToAction("Index");
            
        }
       
        public IActionResult DepartmanSil()
        {
            ViewBag.baslik = "Departman Sil";

            return View();
        }


        public IActionResult DepartmanSilme(int id)
        {
            var dep = c.Departmanlars.Find(id);
            c.Departmanlars.Remove(dep);
            c.SaveChanges(); 
            return RedirectToAction("Index");
        }
    }
}
