
namespace SistematicoCalendario.Formularios
{
    partial class AppMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.lblIntereses = new System.Windows.Forms.Label();
            this.lblTerminos = new System.Windows.Forms.Label();
            this.txtPrestamo = new System.Windows.Forms.TextBox();
            this.txtIntereses = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTerminos = new System.Windows.Forms.TextBox();
            this.DgvInfo = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvInfo1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInfo1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Location = new System.Drawing.Point(32, 34);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(51, 13);
            this.lblPrestamo.TabIndex = 0;
            this.lblPrestamo.Text = "Prestamo";
            // 
            // lblIntereses
            // 
            this.lblIntereses.AutoSize = true;
            this.lblIntereses.Location = new System.Drawing.Point(32, 70);
            this.lblIntereses.Name = "lblIntereses";
            this.lblIntereses.Size = new System.Drawing.Size(50, 13);
            this.lblIntereses.TabIndex = 1;
            this.lblIntereses.Text = "Intereses";
            // 
            // lblTerminos
            // 
            this.lblTerminos.AutoSize = true;
            this.lblTerminos.Location = new System.Drawing.Point(32, 109);
            this.lblTerminos.Name = "lblTerminos";
            this.lblTerminos.Size = new System.Drawing.Size(50, 13);
            this.lblTerminos.TabIndex = 2;
            this.lblTerminos.Text = "Terminos";
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(152, 27);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtPrestamo.TabIndex = 3;
            this.txtPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrestamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrestamo_KeyPress);
            // 
            // txtIntereses
            // 
            this.txtIntereses.Location = new System.Drawing.Point(152, 63);
            this.txtIntereses.Name = "txtIntereses";
            this.txtIntereses.Size = new System.Drawing.Size(100, 20);
            this.txtIntereses.TabIndex = 4;
            this.txtIntereses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIntereses.Click += new System.EventHandler(this.txtIntereses_Click);
            this.txtIntereses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntereses_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.txtTerminos);
            this.groupBox1.Controls.Add(this.txtIntereses);
            this.groupBox1.Controls.Add(this.lblPrestamo);
            this.groupBox1.Controls.Add(this.lblIntereses);
            this.groupBox1.Controls.Add(this.txtPrestamo);
            this.groupBox1.Controls.Add(this.lblTerminos);
            this.groupBox1.Location = new System.Drawing.Point(8, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 146);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del prestamo";
            // 
            // txtTerminos
            // 
            this.txtTerminos.Location = new System.Drawing.Point(152, 102);
            this.txtTerminos.Name = "txtTerminos";
            this.txtTerminos.Size = new System.Drawing.Size(100, 20);
            this.txtTerminos.TabIndex = 5;
            this.txtTerminos.Text = "Años";
            this.txtTerminos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTerminos.Click += new System.EventHandler(this.txtTerminos_Click);
            this.txtTerminos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTerminos_KeyPress);
            // 
            // DgvInfo
            // 
            this.DgvInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInfo.Location = new System.Drawing.Point(309, 56);
            this.DgvInfo.Name = "DgvInfo";
            this.DgvInfo.Size = new System.Drawing.Size(473, 336);
            this.DgvInfo.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(99, 196);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(99, 310);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar app";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(386, 22);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(167, 20);
            this.txtBusqueda.TabIndex = 10;
            this.txtBusqueda.Click += new System.EventHandler(this.txtBusqueda_Click);
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // DgvInfo1
            // 
            this.DgvInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInfo1.Location = new System.Drawing.Point(310, 56);
            this.DgvInfo1.Name = "DgvInfo1";
            this.DgvInfo1.Size = new System.Drawing.Size(472, 336);
            this.DgvInfo1.TabIndex = 13;
            // 
            // AppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.DgvInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.DgvInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "AppMain";
            this.Text = "AppMain";
            this.Load += new System.EventHandler(this.AppMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInfo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Label lblIntereses;
        private System.Windows.Forms.Label lblTerminos;
        private System.Windows.Forms.TextBox txtPrestamo;
        private System.Windows.Forms.TextBox txtIntereses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTerminos;
        private System.Windows.Forms.DataGridView DgvInfo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvInfo1;
    }
}