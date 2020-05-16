using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Entity;
namespace SegundoParcial
{ 
    
    public partial class ConsultaGui : Form
    {
        ServicioReciboDePago servicioReciboDePago = new ServicioReciboDePago();
        VentanaEmergente ventanaEmergente = new VentanaEmergente();
        public ConsultaGui()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (CbTipoConsulta.Text.Equals("Todos"))
            {
                ConsultaGeneral();
            }
            else
            {
                ConsultaPorFechaYEntidad();
            }
        }
        public void ConsultaGeneral()
        {
            DgvRecibo.DataSource = null;
            RespuestaConsulta respuestaConsulta = servicioReciboDePago.Consultar();
            DgvRecibo.DataSource = respuestaConsulta.RecibosDePago;
            TbCantidadRecibo.Text = servicioReciboDePago.CantidadRecibosDePago().ToString();
            TbTotalRecaudo.Text = servicioReciboDePago.ObtenerRecaudoGeneral().ToString();
        }
        public void ConsultaPorFechaYEntidad()
        {
            DgvRecibo.DataSource = null;
            RespuestaConsulta respuestaConsulta = servicioReciboDePago.Consultar();
            DateTime fecha = DtpMesAñoDia.Value;
            string entidadServicio = CbTipoConsulta.Text;
            DgvRecibo.DataSource = servicioReciboDePago.ConsultarPorFechaYEntidad(entidadServicio,fecha);
            TbCantidadRecibo.Text = servicioReciboDePago.CantidadPorFechaYEntidad(entidadServicio, fecha).ToString();
            TbTotalRecaudo.Text = servicioReciboDePago.ObtenerRecaudoPorFechaYEntidad(entidadServicio, fecha).ToString();
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            RespuestaConsulta respuestaConsulta = servicioReciboDePago.Consultar();
            DateTime fecha = DtpMesAñoDia.Value;
            string entidadServicio = CbTipoConsulta.Text;
            IList<ReciboDePago> recibosDePago = servicioReciboDePago.ConsultarPorFechaYEntidad(entidadServicio, fecha);
            ServicioExportar servicioExportar = new ServicioExportar();
            string mensaje = servicioExportar.Exportar(recibosDePago);
            ventanaEmergente.Mensaje(mensaje);
        }
    }
}
