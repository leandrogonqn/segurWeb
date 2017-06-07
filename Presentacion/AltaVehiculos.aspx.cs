using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class AltaVehiculos : System.Web.UI.Page
    {
        VehiculosNego vehiculoNego = new VehiculosNego();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarVehiculo();
        }

        private void GuardarVehiculo()
        {
            Vehiculos vehiculos = new Vehiculos();
            vehiculos.vehiculoDominio = txtDominio.Text;
            vehiculos.vehiculoAnio = int.Parse(txtAño.Text);
            vehiculos.vehiculoNumeroChasis = txtNumeroChasis.Text;
            vehiculos.vehiculoNumeroMotor = txtNumeroMotor.Text;
            vehiculos.modeloId = int.Parse(txtPruebaModelo.Text);
            vehiculos.vehiculoEstado = 1;

            vehiculoNego.GuardarVehiculos(vehiculos);

            txtDominio.Text = String.Empty;
            txtAño.Text = String.Empty;
            txtPruebaModelo.Text = String.Empty;
            txtNumeroChasis.Text = String.Empty;
            txtNumeroMotor.Text = String.Empty;

            //using (segurosEntities context = new segurosEntities())
            //{
            //    context.Vehiculos.Add(vehiculos);
            //    context.SaveChanges();
            //}
                

            //try
            //{
            //    //vehiculos.vehiculoDominio = txtDominio.Text;
            //    //vehiculos.vehiculoAnio = int.Parse(txtAño.Text);
            //    //vehiculos.vehiculoNumeroChasis = txtNumeroChasis.Text;
            //    //vehiculos.vehiculoNumeroMotor = txtNumeroMotor.Text;
            //    //vehiculos.modeloId = int.Parse(txtPruebaModelo.Text);
            //    //vehiculos.vehiculoEstado = 1;

            //    //vehiculosNego.GuardarVehiculos(vehiculos);

            //    txtDominio.Text = String.Empty;
            //    txtAño.Text = String.Empty;
            //    txtPruebaModelo.Text = String.Empty;
            //    txtNumeroChasis.Text = String.Empty;
            //    txtNumeroMotor.Text = String.Empty;

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }
    }
}