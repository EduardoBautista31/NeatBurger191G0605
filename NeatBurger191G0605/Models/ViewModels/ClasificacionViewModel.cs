namespace NeatBurger191G0605.Models.ViewModels
{
    public class ClasificacionViewModel
    {
        public IEnumerable<Menu> clasificacion1 { get; set; }= new List<Menu>();
        public IEnumerable<Menu> clasificacion2 { get; set; } = new List<Menu>();
        public IEnumerable<Menu> clasificacion3 { get; set; } = new List<Menu>();

    }
}
