using AppCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistematicoCalendario
{
	public partial class Form1 : Form
	{
		private ICalendarioService Calendario;
		public Form1(ICalendarioService calendario)
		{
			this.Calendario = calendario;
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		
		}

		private void btnCrear_Click(object sender, EventArgs e)
		{
			
		}
	}
}
