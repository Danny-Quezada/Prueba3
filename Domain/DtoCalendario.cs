using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DtoCalendario
    {
        public int Mes { get; set; }
        public decimal Monto_Prestamo { get; set; }
        public decimal Tasa_Interes { get; set; }
        public decimal Meses_Restantes { get; set; }
        public decimal Principal { get; set; }
        public decimal Intereses { get; set; }
        public decimal Cuota { get; set; }
    }
}
