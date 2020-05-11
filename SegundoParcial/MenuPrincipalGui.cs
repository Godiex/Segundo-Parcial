using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class MenuPrincipalGui : Form
    {
        public MenuPrincipalGui()
        {
            InitializeComponent();
        }

        private void PbSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro que desea salir ?";
            string titulo = "Avertencia !!!";
            var resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PbRestaurar.Visible = true;
            PbMaximizar.Visible = false;
        }

        private void PbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            PbMaximizar.Visible = true;
            PbRestaurar.Visible = false;
        }

        private void PbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private Form FormActual = null;
        private void AbrirFormHijoEnPanel(Form formHijo)
        {
            if (FormActual != null)
                FormActual.Close();
            FormActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(formHijo);
            PanelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormHijoEnPanel(new  ConsultaGui());
        }
    }
}
