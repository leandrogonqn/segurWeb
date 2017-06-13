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
        ModeloNego modeloNego = new ModeloNego();
        MarcaNego marcaNego = new MarcaNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CargarCombosMarca();
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
            vehiculos.modeloId = int.Parse(ddlModelo.SelectedItem.Value);
            vehiculos.vehiculoEstado = 1;

            vehiculoNego.GuardarVehiculos(vehiculos);

            txtDominio.Text = String.Empty;
            txtAño.Text = String.Empty;
            txtNumeroChasis.Text = String.Empty;
            txtNumeroMotor.Text = String.Empty;

        }

        private void CargarCombosMarca()
        {

            ddlMarca.DataSource = marcaNego.CargarComboMarca();
            ddlMarca.DataTextField = "marcaDescripcion";
            ddlMarca.DataValueField = "marcaId";
            ddlMarca.DataBind();
            ddlMarca.Items.Insert(0, "Seleccione una marca");

        }

        private void CargarCombosModelos(int marcaId)
        {
            ddlModelo.DataSource = modeloNego.CargarComboModelo(marcaId);
            ddlModelo.DataTextField = "modeloDescripcion";
            ddlModelo.DataValueField = "modeloId";
            ddlModelo.DataBind();
            ddlModelo.Items.Insert(0, "Seleccione un modelo");

        }

        protected void ddlMarca_TextChanged(object sender, EventArgs e)
        {
            int marcaId = int.Parse(ddlMarca.SelectedItem.Value);
            CargarCombosModelos(marcaId);
            ddlModelo.Enabled = true;
        }
    }
}