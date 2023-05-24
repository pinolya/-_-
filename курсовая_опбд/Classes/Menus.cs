using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая_опбд
{
    public class Menus
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public int IdRazdel { get; set; }
        public Razdels Razdels { get; set; }
        public List<Compozitions> Compozitions { get; set; }
        public List<Order> Orders { get; set; }
        public Menus()
        {
            Compozitions = new List<Compozitions>();
            Orders = new List<Order>();
        }
    }
}
