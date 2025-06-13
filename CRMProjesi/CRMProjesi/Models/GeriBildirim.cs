using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Data
{
    public class GeriBildirim
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid MusteriId { get; set; }
        public string Metin { get; set; }
        public bool Tamamlandı { get; set; } = false;
    }
}
