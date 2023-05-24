using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая_опбд
{
    public class Appendix
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public int StaffId { get; set; }
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Order Order { get; set; }
        public Table Table { get; set; }
        public Sotrudnik Sotrudnik { get; set; }
    }
}
