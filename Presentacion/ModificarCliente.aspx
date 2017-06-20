<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarCliente.aspx.cs" Inherits="Presentacion.ModificarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="panel panel-primary">
            <div class="panel-heading">Ingrese datos a modificar del Cliente</div>
            <div class="panel-body">
                <div class="form-group">
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre:" CssClass="col-md-2 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Label ID="lblApellido" runat="server" Text="Apellido:" CssClass="col-md-2 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblDni" runat="server" Text="DNI:" CssClass="col-md-2 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtDni" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Label ID="lblModelo" runat="server" Text="Fecha de Nacimiento:" CssClass="col-md-2 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtFechaNacimiento" type="date" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblDomicilio" runat="server" Text="Domicilio:" CssClass="col-md-2 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtDomicilio" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Label ID="lblTelefono" runat="server" Text="Telefono:" CssClass="col-md-2 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblEmail" runat="server" Text="Correo electrónico:" CssClass="col-md-2 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtEmail" type="email" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                 <div class="form-group">
                </div>


                <div class="form-group">
                    <div class="col-md-4">
                    </div>
                    <div class="col-md-4">
                        <asp:Button ID="btnModificarCliente" runat="server" Text="Modificar" class="btn btn-primary" OnClick="btnModificarCliente_Click" />
                    </div>
                    <div class="col-md-4">
                    </div>
                </div>

            </div>
        </div>
</asp:Content>
