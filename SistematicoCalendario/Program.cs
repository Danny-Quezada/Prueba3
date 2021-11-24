using AppCore.Interfaces;
using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistematicoCalendario
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var builder = new ContainerBuilder();

			builder.RegisterType<CalendarioListRepository>().As<ICalendarioRepository>();
			builder.RegisterType<CalendarioServices>().As<ICalendarioService>();
			var container = builder.Build();
			Application.Run(new Form1(container.Resolve<ICalendarioService>()));
		}
	}
}
