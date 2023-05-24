using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая_опбд
{
    public class Sotrudnik
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patr { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Post { get; set; }
        public int Salary { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Appendix> Appendix { get; set; }
        public Sotrudnik()
        {
            Appendix = new List<Appendix>();
        }

    }
}
