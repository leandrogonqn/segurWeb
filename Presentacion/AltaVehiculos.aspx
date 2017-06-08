<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaVehiculos.aspx.cs" Inherits="Presentacion.AltaVehiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="panel panel-primary">
            <div class="panel-heading">Ingrese datos del Vehiculo</div>
            <div class="panel-body">

                <div class="form-group">
                    <asp:Label ID="lblDominio" runat="server" Text="Dominio:" CssClass="control-label col-md-3"></asp:Label>
                    <div class="col-md-3">
                        <asp:TextBox ID="txtDominio" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Label ID="lblAño" runat="server" Text="Año:" CssClass="control-label col-md-3"></asp:Label>
                    <div class="col-md-3">
                        <asp:TextBox ID="txtAño" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-6">
                        <asp:dropdownlist id="ddlMarca" runat="server" enabled="true" cssclass="form-control" autopostback="true"></asp:dropdownlist>
                    </div>
                    <div class="col-md-6">
                        <asp:dropdownlist id="ddlModelo" runat="server" enabled="true" cssclass="form-control" autopostback="true"></asp:dropdownlist>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblNumeroMotor" runat="server" Text="Numero de Motor:" CssClass="control-label col-md-3"></asp:Label>
                    <div class="col-md-3">
                        <asp:TextBox ID="txtNumeroMotor" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Label ID="lblNumeroChasis" runat="server" Text="Numero de chasis:" CssClass="control-label col-md-3"></asp:Label>
                    <div class="col-md-3">
                        <asp:TextBox ID="txtNumeroChasis" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-primary" OnClick="btnGuardar_Click" />
                </div>

            </div>
        </div>
    </div>
</asp:Content>
