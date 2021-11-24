using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public interface ICalendarioRepository: IModel<Calendario>
	{
		
		void QuitarLista(Calendario calendario);
		 ICollection<Calendario> FindAll(int tipo);
	}
}
