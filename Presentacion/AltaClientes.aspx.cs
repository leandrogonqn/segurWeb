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
    public partial class AltaClientes : System.Web.UI.Page
    {
        ClientesNego clientesNego = new ClientesNego();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            GuardarCliente();
        }

        private void GuardarCliente()
        {
            Clientes clientes = new Clientes();
            clientes.clienteNombre = txtNombre.Text;
            clientes.clienteApellido = txtApellido.Text;
            clientes.clienteDni = int.Parse(txtDni.Text);
            clientes.clienteFechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            clientes.clienteDomicilio = txtDomicilio.Text;
            clientes.clienteTelefono = txtTelefono.Text;
            clientes.clienteMail = txtEmail.Text;
            clientes.clienteEstado = 1;

            clientesNego.GuardarClientes(clientes);

        }
    }
}