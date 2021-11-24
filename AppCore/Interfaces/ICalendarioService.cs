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
		ICollection<DtoCalendario> FindAllDtoCalendarios();
		void AddDtoCalendario(Calendario calendario);
		ICollection<DtoCalendario> CargarDtoCalendario(Calendario calendario);
		void CalculoPrincipal(Calendario calendario);
		void CalculoInteres(Calendario calendario);
		void CalculoCuota(Calendario calendario);
		void QuitarLista(Calendario calendario);
		ICollection<Calendario> FindAll(int tipo);

	}

}
