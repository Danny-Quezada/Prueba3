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
		private List<Calendario> Calendarios;
		private List<Calendario> Pagados;
		public CalendarioListRepository()
		{
			Calendarios = new List<Calendario>();
			Pagados = new List<Calendario>();
		}
		

		public ICollection<Calendario> FindAll(int tipo)
		{
			if (tipo == 1)
			{
				return Calendarios;
			}
			else if (tipo == 2)
			{
				return Pagados;
			}
			return null;
		}

		public void QuitarLista(Calendario calendario)
		{
			Calendarios.Remove(calendario);
			Pagados.Add(calendario);
		}
	}
}
