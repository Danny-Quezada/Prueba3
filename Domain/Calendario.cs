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
        public int Id { get; set; }
        public decimal Principal { get; set; }
        public decimal Intereses { get; set; }
        public decimal Cuota { get; set; }
        public Estado Estado { get; set; }
        public decimal PrincipalPagado { get; set; }
        public decimal InteresesPagados { get; set; }
        public decimal CuotaPrestamo { get; set; }
        public decimal Tasa { get; set; }
        public int Terminos { get; set; }
        public decimal MontoPrestamo { get; set; }

    }
}
