using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая_опбд
{
    public class Compozitions
    {
        public int Id { get; set; }
        public int DishId { get; set; }
        public string Ingred { get; set; }
        public Menus Menus { get; set; }
    }
}
