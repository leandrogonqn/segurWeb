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
    public partial class ModificarCliente : System.Web.UI.Page
    {
        ClientesNego clientesNego = new ClientesNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            int clienteId = int.Parse(Request["clienteId"].ToString());
            LlenarCampos(clienteId);
        }

        private void LlenarCampos(int clienteId)
        {
            Clientes clientes = clientesNego.BuscarCliente(clienteId);

            txtApellido.Text = clientes.clienteApellido.ToString();
            txtNombre.Text = clientes.clienteNombre.ToString();
            txtDni.Text = clientes.clienteDni.ToString();
            txtFechaNacimiento.Text = DateTime.Parse(clientes.clienteFechaNacimiento.ToString()).ToString("yyyy-MM-dd");
            txtDomicilio.Text = clientes.clienteDomicilio;
            txtTelefono.Text = clientes.clienteTelefono.ToString();
            txtEmail.Text = clientes.clienteMail.ToString();
        }

        protected void btnModificarCliente_Click(object sender, EventArgs e)
        {
            BotonModificarCliente();
        }

        private void BotonModificarCliente()
        {
            Clientes clientes = new Clientes();
            clientes.clienteId = int.Parse(Request["clienteId"].ToString());
            clientes.clienteApellido = txtApellido.Text;
            clientes.clienteNombre = txtNombre.Text;
            clientes.clienteDni = int.Parse(txtDni.Text);
            clientes.clienteFechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            clientes.clienteDomicilio = txtDomicilio.Text;
            clientes.clienteTelefono = txtTelefono.Text;
            clientes.clienteMail = txtEmail.Text;

            clientesNego.ModificarCliente(clientes);

            Response.Redirect("ListarClientes.aspx");
        }
    }
}