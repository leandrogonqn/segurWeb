<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListarPolizas.aspx.cs" Inherits="Presentacion.ListarPolizas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:GridView ID="gdvPoliza" runat="server" CssClass=" table table-hover" AutoGenerateColumns="false" OnRowCommand="gdvPoliza_RowCommand" OnRowDataBound="gdvPoliza_RowDataBound" >
            <Columns>

                <asp:BoundField HeaderText="Número Poliza" DataField="polizaNumero" />
                <asp:BoundField HeaderText="Poliza Fecha Vigencia" DataField="polizaFechaVigencia" />
                <asp:BoundField HeaderText="Vehículo" DataField="vehiculoDominio" />
                <asp:BoundField HeaderText="Cliente Nombre" DataField="clienteNombre" />
                <asp:BoundField HeaderText="Cliente Apellido" DataField="clienteApellido" />
                <asp:BoundField HeaderText="Poliza Estado" DataField="polizaEstado" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton runat="server" ImageUrl="~/img/edit.png" CommandName="btnEditar" CommandArgument='<%#Eval("polizaId") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton runat="server" ImageUrl="~/img/delete.png" CommandName="bntEliminar" CommandArgument='<%#Eval("polizaId") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
