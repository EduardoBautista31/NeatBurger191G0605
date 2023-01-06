using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeatBurger191G0605.Models;
using NeatBurger191G0605.Models.ViewModels;

namespace NeatBurger191G0605.Controllers
{
    public class HomeController : Controller
    {
        neatContext context = new neatContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Menu1(int id)
        {

            var menu = context.Menus.Find(id);

            return View(menu);
        }
        public IActionResult Menu2(int id)
        {
            ClasificacionViewModel vmc = new ClasificacionViewModel();
            var burgers = context.Menus.OrderBy(x=> x.Id).ToList();
            vmc.clasificacion1 = context.Menus.Include(x => x.IdClasificacionNavigation).Where(x => x.IdClasificacionNavigation.Nombre =="Tendencias");
            vmc.clasificacion2 = context.Menus.Include(x => x.IdClasificacionNavigation).Where(x => x.IdClasificacionNavigation.Nombre == "Tradicionales");
            vmc.clasificacion3 = context.Menus.Include(x => x.IdClasificacionNavigation).Where(x => x.IdClasificacionNavigation.Nombre == "Favoritas del chef");

            return View(vmc);
        }
        public IActionResult Menu3(int id)
        {
            Menu3ViewModels vm = new Menu3ViewModels();
            vm.menus = context.Menus.OrderBy(x=> x.Nombre).ToList();
            vm.id = id;
            vm.Descripcion = context.Menus.Find(id).Descripción;
            return View(vm);
        }
        public IActionResult Alumno()
        {
            return View();
        }
    }
}
