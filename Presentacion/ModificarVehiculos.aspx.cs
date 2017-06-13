using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class ModificarVehiculos : System.Web.UI.Page
    {
        VehiculosNego vehiculosNego = new VehiculosNego();
        ModeloNego modeloNego = new ModeloNego();
        MarcaNego marcaNego = new MarcaNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CargarCombosMarca();
            int vehiculoId = int.Parse(Request["vehiculoId"].ToString());
            LlenarCampos(vehiculoId);
        }

        private void LlenarCampos(int vehiculoId)
        {

            Vehiculos vehiculo = vehiculosNego.BuscarVehiculo(vehiculoId);
            Modelos modelos = modeloNego.BuscarModelo(vehiculo.modeloId);
            Marcas marcas = marcaNego.BuscarMarca(modelos.marcaId);
            CargarCombosModelos(marcas.marcaId);

            txtDominio.Text = vehiculo.vehiculoDominio.ToString();
            txtAño.Text = vehiculo.vehiculoAnio.ToString();
            ddlMarca.SelectedValue = marcas.marcaId.ToString();
            ddlModelo.SelectedValue = modelos.modeloId.ToString();
            txtNumeroMotor.Text = vehiculo.vehiculoNumeroMotor.ToString();
            txtNumeroChasis.Text = vehiculo.vehiculoNumeroChasis.ToString();


        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarVehiculo();
        }

        private void ModificarVehiculo()
        {
            Vehiculos vehiculos = new Vehiculos();
            vehiculos.vehiculoId = int.Parse(Request["vehiculoId"].ToString());
            vehiculos.vehiculoDominio = txtDominio.Text;
            vehiculos.vehiculoAnio = int.Parse(txtAño.Text);
            vehiculos.vehiculoNumeroChasis = txtNumeroChasis.Text;
            vehiculos.vehiculoNumeroMotor = txtNumeroMotor.Text;
            vehiculos.modeloId = int.Parse(ddlModelo.SelectedItem.Value);
            vehiculos.vehiculoEstado = 1;

            vehiculosNego.ModificarVehiculo(vehiculos);

            Response.Redirect("ListarVehiculos.aspx");
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