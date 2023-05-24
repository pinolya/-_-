using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая_опбд
{
    public class Razdels
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Menus> Menus { get; set; }
        public Razdels()
        {
            Menus = new List<Menus>();
        }
    }
}
