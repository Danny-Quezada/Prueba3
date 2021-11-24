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
		public CalendarioServices(ICalendarioRepository calendario,IModel<Calendario> model) : base(model)
		{
			this.calendarioRepository = calendario;
		}

		public ICollection<Calendario> FindAll(int tipo)
		{
			return calendarioRepository.FindAll(tipo);
		}

		public void QuitarLista(Calendario calendario)
		{
			calendarioRepository.QuitarLista(calendario);
		}
	}
}
