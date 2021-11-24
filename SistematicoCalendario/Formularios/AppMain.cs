using AppCore.Interfaces;
using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistematicoCalendario.Formularios
{
    public partial class AppMain : Form
    {
        private ICalendarioService Calendario;
        public AppMain(ICalendarioService calendarios)
        {
            CalendarioListRepository calendarioListRepository = new CalendarioListRepository();
            this.Calendario = calendarios;
            InitializeComponent();
        }
        private void txtIntereses_Click(object sender, EventArgs e)
        {
            txtIntereses.Text = "";
        }

        private void txtTerminos_Click(object sender, EventArgs e)
        {
            txtTerminos.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (0 == ValidacionCampos())
            {
                DgvInfo1.Visible = false;
                DgvInfo.Visible = true;
                Calendario calendario = new Calendario
                {
                    Id = Calendario.GetLastId() + 1,
                    Intereses = decimal.Parse(txtIntereses.Text),
                    Estado = Domain.Enum.Estado.Pendiente,
                    Tasa = decimal.Parse(txtIntereses.Text) / 100,
                    Terminos = Int32.Parse(txtTerminos.Text) * 12,
                    MontoPrestamo = decimal.Parse(txtPrestamo.Text)
                };
                Calendario.CalculoPrincipal(calendario);
                Calendario.CalculoInteres(calendario);
                Calendario.CalculoCuota(calendario);
                Calendario.Create(calendario);
                Calendario.AddDtoCalendario(calendario);
                DgvInfo.DataSource = Calendario.CargarDtoCalendario(calendario);
                txtIntereses.Text = "";
                txtPrestamo.Text = "";
                txtTerminos.Text = "";
                txtBusqueda.Text = "";
            }
            else
            {
                MessageBox.Show("Debe de rellenar todos los campos del prestamo", "Error en los campos del prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator
                || char.IsControl(e.KeyChar))

                e.Handled = false;

            else

                e.Handled = true;
        }

        private void txtTerminos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIntereses_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator
                || char.IsControl(e.KeyChar))

                e.Handled = false;

            else

                e.Handled = true;
        }
        private int ValidacionCampos()
        {
            if (txtIntereses.Text == "" || txtPrestamo.Text == "" || txtTerminos.Text == "")
            {
                return 1;
            }
            return 0;
        }
        private DataTable ConvertToDataTable()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in DgvInfo1.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in DgvInfo1.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }

            return dt;
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
                {
                    DgvInfo.Visible = false;
                    DgvInfo1.Visible = true;
                    DgvInfo1.DataSource = Calendario.FindAll(1);
                    return;
                }
                DgvInfo1.DataSource = Calendario.FindAll(1);
                DataTable dt = ConvertToDataTable();
                dt.DefaultView.RowFilter = string.Format("Id  = '{0}' OR MontoPrestamo = '{0}' OR Tasa = '{0}'", txtBusqueda.Text);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                DgvInfo1.DataSource = bs;
            }
        }
        private void AppMain_Load(object sender, EventArgs e)
        {
            DgvInfo1.Visible = false;
        }

        private void txtBusqueda_Click(object sender, EventArgs e)
        {
            DgvInfo.Visible = false;
            DgvInfo1.Visible = true;
            DgvInfo1.DataSource = Calendario.FindAll(1);
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator
                || char.IsControl(e.KeyChar))

                e.Handled = false;

            else

                e.Handled = true;
        }
    }
}
