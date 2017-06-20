using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class ModificarPolizas : System.Web.UI.Page
    {
        PolizaNego polizaNego = new PolizaNego();
        ClientesNego clienteNego = new ClientesNego();
        VehiculosNego vehiculoNego = new VehiculosNego();
        CompaniaNego companiaNego = new CompaniaNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CargarCombos();
            int polizaId = int.Parse(Request["polizaId"].ToString());
            LlenarObjetoPoliza(polizaId);

        }

        private void LlenarObjetoPoliza(int polizaId)
        {
            Polizas poliza = new Polizas();

            poliza = polizaNego.LlenarObjetoPoliza(polizaId);
            txtPolizaNumero.Text = poliza.polizaNumero;
            dtFechaVigencia.Value = DateTime.Parse(poliza.polizaFechaVigencia.ToString()).ToString("yyyy-MM-dd");
            ddlCliente.SelectedValue = poliza.clienteId.ToString();
            ddlcompania.SelectedValue = poliza.companiaId.ToString();
            ddlVehiculo.SelectedValue = poliza.vehiculoId.ToString();
        }

        private void CargarCombos()
        {
            ddlCliente.DataSource = clienteNego.LlenarComboCliente();
            ddlCliente.DataTextField = "nombreCompleto";
            ddlCliente.DataValueField = "clienteId";
            ddlCliente.DataBind();
            ddlCliente.Items.Insert(0, "Seleccione un cliente");

            ddlVehiculo.DataSource = vehiculoNego.CargarComboVehiculo();
            ddlVehiculo.DataTextField = "vehiculoDominio";
            ddlVehiculo.DataValueField = "vehiculoId";
            ddlVehiculo.DataBind();
            ddlVehiculo.Items.Insert(0, "Seleccione un Vehiculo");

            ddlcompania.DataSource = companiaNego.LlenarComboCompanias();
            ddlcompania.DataTextField = "companiaDescripcion";
            ddlcompania.DataValueField = "companiaId";
            ddlcompania.DataBind();
            ddlcompania.Items.Insert(0, "Seleccione un Compañia");
        }

        private void Modificar()
        {
            Polizas poliza = new Polizas();
            poliza.polizaId = int.Parse(Request["polizaId"].ToString());
            poliza.clienteId = int.Parse(ddlCliente.SelectedItem.Value);
            poliza.vehiculoId = int.Parse(ddlVehiculo.SelectedItem.Value);
            poliza.companiaId = int.Parse(ddlcompania.SelectedItem.Value);
            poliza.polizaNumero = txtPolizaNumero.Text;
            poliza.polizaFechaVigencia = Convert.ToDateTime(dtFechaVigencia.Value);
            poliza.polizaEstado = 1;
            poliza.polizaFechaBaja = DateTime.Now;

            polizaNego.Modificar(poliza);

            Response.Redirect("ListarPolizas.aspx");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}