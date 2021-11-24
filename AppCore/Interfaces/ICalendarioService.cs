using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
	public interface ICalendarioService: IServices<Calendario>
	{

		void QuitarLista(Calendario calendario);
		ICollection<Calendario> FindAll(int tipo);

	}

}
