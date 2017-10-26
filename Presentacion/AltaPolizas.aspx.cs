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
    public partial class AltaPolizas : System.Web.UI.Page
    {
        ClientesNego clienteNego = new ClientesNego();
        VehiculosNego vehiculoNego = new VehiculosNego();
        CompaniaNego companiaNego = new CompaniaNego();
        PolizaNego polizaNego = new PolizaNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CargarCombos();           
        }



        private void Guardar()
        {

            Polizas poliza = new Polizas();
            PolizaNego polizaNego = new PolizaNego();
   
            poliza.clienteId = int.Parse(ddlCliente.SelectedItem.Value);
            poliza.vehiculoId = int.Parse(ddlVehiculo.SelectedItem.Value);
            poliza.companiaId = int.Parse(ddlcompania.SelectedItem.Value);
            poliza.polizaNumero = txtPolizaNumero.Text;
            poliza.polizaFechaAlta = DateTime.Now;
            poliza.polizaFechaVigencia = Convert.ToDateTime(dtFechaVigencia.Value);
            poliza.polizaEstado = 1;
            poliza.polizaFechaBaja = DateTime.Now;

            polizaNego.Guardar(poliza);

            //Envio de mail confirmatorio
            Clientes cliente = clienteNego.BuscarCliente(poliza.clienteId);
            String mensaj = "Buenos días Sr/a. "+cliente.clienteApellido+ ", \nLa poliza de su vehiculo ya fue generada exitosamente, en los proximos días se la estaremos acercando a su domicilio.\n \nSaludos cordiales.\n\nPacinetes S.R.L.";
            Email mail = new Email();
            mail.enviarMail("sistemasigese@gmail.com", cliente.clienteMail, "su poliza ya está emitida", mensaj);

            txtPolizaNumero.Text = String.Empty;
            ddlCliente.SelectedIndex = 0;
            ddlcompania.SelectedIndex = 0;
            ddlVehiculo.SelectedIndex = 0;
            dtFechaVigencia.Value = new DateTime().ToString();
        }


        private void CargarCombos()
        {
            ddlCliente.DataSource = clienteNego.LlenarComboCliente();
            ddlCliente.DataTextField = "nombreCompleto";
            ddlCliente.DataValueField = "clienteId";
            ddlCliente.DataBind();
            ddlCliente.Items.Insert(0, "Seleccione un cliente");

            ddlVehiculo.DataSource = vehiculoNego.CargarComboVehiculo();
            ddlVehiculo.DataTextField = "vehiculoCompleto";
            ddlVehiculo.DataValueField = "vehiculoId";
            ddlVehiculo.DataBind();
            ddlVehiculo.Items.Insert(0, "Seleccione un Vehiculo");

            ddlcompania.DataSource = companiaNego.LlenarComboCompanias();
            ddlcompania.DataTextField = "companiaDescripcion";
            ddlcompania.DataValueField = "companiaId";
            ddlcompania.DataBind();
            ddlcompania.Items.Insert(0, "Seleccione un Compañia");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

    }
}