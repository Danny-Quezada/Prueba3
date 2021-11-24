using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Calendario
	{

       
        
        public DateTime FechaVencimiento { get; set; }
        
        public decimal Monto { get; set; }
      
        public decimal Tasa { get; set; }
       
        public decimal Impuestos { get; set; }
        public decimal MontoTotal { get; set; }
        public int Id { get; set; }
        public decimal Intereses { get; set; }

        public Estado Estado { get; set; }
        public DateTime FechaPaga { get; set; }
        public decimal Principal { get; set; }

        public int Terminos { get; set; }

    }
}
