using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая_опбд
{
    public class Order
    {
        public int Id { get; set; }
        public string DishName { get; set; }
        public int DishId { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public int AppendixId { get; set; }
        public Menus Menus { get; set; }
        public Appendix Appendix { get; set; }
    }
}
