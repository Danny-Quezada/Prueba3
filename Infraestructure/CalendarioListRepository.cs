using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
	public class CalendarioListRepository : BaseRepository<Calendario>, ICalendarioRepository
	{
		private List<DtoCalendario> dtoCalendarios;
		private List<Calendario> Pagados;
		public CalendarioListRepository()
		{
			dtoCalendarios = new List<DtoCalendario>();
			Pagados = new List<Calendario>();
		}

        public void AddDtoCalendario(Calendario calendario)
        {
			DtoCalendario dtoCalendario = new DtoCalendario
			{
				Mes = dtoCalendarios.Count == 0 ? 0 : dtoCalendarios.Max(x => x.Mes + 1),
				Monto_Prestamo = calendario.MontoPrestamo,
				Tasa_Interes = calendario.Intereses,
				Meses_Restantes = calendario.Terminos,
				Principal = calendario.Principal,
				Cuota = calendario.Cuota,
				Intereses = calendario.Intereses
			};
			dtoCalendarios.Add(dtoCalendario);
		}

        public void CalculoCuota(Calendario calendario)
        {
			calendario.Cuota = calendario.Principal + calendario.Intereses;
        }

        public void CalculoInteres(Calendario calendario)
        {
			calendario.Intereses = calendario.MontoPrestamo * (calendario.Tasa / calendario.Terminos);
        }

        public void CalculoPrincipal(Calendario calendario)
        {
			calendario.Principal = (calendario.MontoPrestamo * (1 + calendario.Tasa)) / calendario.Terminos;
		}

        public ICollection<DtoCalendario> CargarDtoCalendario(Calendario calendario)
        {
			List<DtoCalendario> DTOCalendarios = new List<DtoCalendario>();
			for (int i = 0; i < calendario.Terminos; i++)
			{
				DtoCalendario dtoCalendario = new DtoCalendario
				{
					Mes = DTOCalendarios.Count == 0 ? 1 : DTOCalendarios.Max(x => x.Mes + 1),
					Monto_Prestamo = calendario.MontoPrestamo,
					Tasa_Interes = calendario.Intereses,
					Meses_Restantes = calendario.Terminos - i,
					Principal = calendario.Principal,
					Cuota = calendario.Cuota,
					Intereses = calendario.Intereses
				};
				DTOCalendarios.Add(dtoCalendario);
			}
			return DTOCalendarios;
		}

        public ICollection<Calendario> FindAll(int tipo)
		{
			if (tipo == 1)
			{
				return datos;
			}
			else if (tipo == 2)
			{
				return Pagados;
			}
			return null;
		}

        public ICollection<DtoCalendario> FindAllDtoCalendarios()
        {
			return dtoCalendarios;
        }

        public void QuitarLista(Calendario calendario)
		{
			datos.Remove(calendario);
			Pagados.Add(calendario);
		}
	}
}
