using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm=new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }

        public IActionResult CategoryDelete(int id) 
        {
            var value = cm.TGetById(id);
            cm.TDelete(value);

            return RedirectToAction("Index");
        }
    }

    
}
