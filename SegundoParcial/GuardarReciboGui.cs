using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Bll;
namespace SegundoParcial
{
    public partial class GuardarReciboGui : Form
    {
        ServicioReciboDePago servicioReciboDePago = new ServicioReciboDePago();
        OperacionesCampos campos = new OperacionesCampos();
        VentanaEmergente ventanaEmergente = new VentanaEmergente();
        public GuardarReciboGui()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!campos.EsCampoVacio(this))
            {
                ReciboDePago reciboDePago = CrearReciboDePago();
                if (reciboDePago != null)
                {
                    string mensaje = servicioReciboDePago.Guardar(reciboDePago);
                    ventanaEmergente.Mensaje(mensaje);
                }
            }
            else
            {
                ventanaEmergente.MensajeErrorCampoVacio();
            }
            
        }
        public ReciboDePago CrearReciboDePago()
        {
            string entidadServicio = CmbEntidadServicio.Text;
            string idRecibo = TbIdRecibo.Text;
            DateTime fecha = DtpMesAñoDia.Value;
            decimal valorPagado = decimal.Parse(TbValorPagado.Text);
            ReciboDePago reciboDePago = new ReciboDePago(idRecibo,entidadServicio,fecha,valorPagado);
            return reciboDePago;
        }
        private void BtnVaciarCampos_Click(object sender, EventArgs e)
        {

        }
    }
}
