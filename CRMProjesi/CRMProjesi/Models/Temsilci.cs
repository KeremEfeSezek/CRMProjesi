using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Data
{
    public class Temsilci
    {
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Ad { get; set; }
    public string Soyad { get; set; }
    }
   
}
