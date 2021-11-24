using AppCore.Interfaces;
using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
	public class CalendarioServices : BaseServices<Calendario>, ICalendarioService
	{
		public ICalendarioRepository calendarioRepository;
		public CalendarioServices(ICalendarioRepository calendarioRepository) : base(calendarioRepository)
		{
			this.calendarioRepository = calendarioRepository;
		}

        public void AddDtoCalendario(Calendario calendario)
        {
			calendarioRepository.AddDtoCalendario(calendario);
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
        public ICollection<Calendario> FindAll(int tipo)
		{
			return calendarioRepository.FindAll(tipo);
		}

		public void QuitarLista(Calendario calendario)
		{
			calendarioRepository.QuitarLista(calendario);
		}

        public ICollection<DtoCalendario> CargarDtoCalendario(Calendario calendario)
        {
			return calendarioRepository.CargarDtoCalendario(calendario);
        }

        public ICollection<DtoCalendario> FindAllDtoCalendarios()
        {
			return calendarioRepository.FindAllDtoCalendarios();
        }
    }
}
