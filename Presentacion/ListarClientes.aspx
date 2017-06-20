<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListarClientes.aspx.cs" Inherits="Presentacion.ListarClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-group">
            <asp:GridView ID="gdvClientes" runat="server" CssClass="table table-striped" AutoGenerateColumns="false" OnRowCommand="gdvClientes_RowCommand">

                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="clienteId" />
                    <asp:BoundField HeaderText="Apellido" DataField="clienteApellido" />
                    <asp:BoundField HeaderText="Nombre" DataField="clienteNombre" />
                    <asp:BoundField HeaderText="DNI" DataField="clienteDni" />
                    <asp:BoundField HeaderText="Fecha de Nacimiento" DataField="clienteFechaNacimiento" />
                    <asp:BoundField HeaderText="Domicilio" DataField="clienteDomicilio" />
                    <asp:BoundField HeaderText="Telefono" DataField="clienteTelefono" />
                    <asp:BoundField HeaderText="Mail" DataField="clienteMail" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton  runat="server" ImageUrl="~/img/edit.png" CommandName="Modificar" CommandArgument='<%# Eval("clienteId")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton  runat="server" ImageUrl="~/img/delete.png" CommandName="Borrar" CommandArgument='<%# Eval("clienteId")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
