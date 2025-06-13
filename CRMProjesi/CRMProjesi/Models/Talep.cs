using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Data
{
    public class Talep
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Konu { get; set; }
        public string Detay { get; set; }
        public Guid MusteriID { get; set; }
        public Guid TemsilciID { get; set; }
    }

}
