<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaPolizas.aspx.cs" Inherits="Presentacion.AltaPolizas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="container">

        <div class="panel panel-primary">

            <div class="panel-heading">
                Alta Polizas

            </div>

            <div class="panel-body">

                <div class="form-group">

                    <asp:Label ID="lblVehiculo" class="col-md-2 control-label" runat="server" Text="Vehiculo: "></asp:Label>

                    <div class="col-md-4">
                        <asp:DropDownList ID="ddlVehiculo" class="dropdown-header" runat="server"></asp:DropDownList>
                    </div>

                    <asp:Label ID="lblCliente" class="col-md-2 control-label" runat="server" Text="Cliente: "></asp:Label>

                    <div class="col-md-4">
                        <asp:DropDownList ID="ddlCliente" class="dropdown-header" runat="server"></asp:DropDownList>
                    </div>

                </div>
                <div class="form-group">

                    <asp:Label ID="lblCompania" class="col-md-2 control-label" runat="server" Text="Compañia: "></asp:Label>

                    <div class="col-md-4">
                        <asp:DropDownList ID="ddlcompania" class="dropdown-header" runat="server"></asp:DropDownList>
                    </div>

                    <asp:Label ID="lblFechaVigencia" class="col-md-2 control-label" runat="server" Text="Fecha Vigencia"></asp:Label>

                    <div class="col-md-4">
                        <input id="dtFechaVigencia" runat="server" type="date" name="dtFechaVigencia" />

                    </div>
                    <div class="form-group">
                        <div class="col-md-6 col-md-offset-9">
                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" type="button" class="btn btn-primary" OnClick="btnGuardar_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
