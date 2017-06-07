<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarVehiculos.aspx.cs" Inherits="Presentacion.ModificarVehiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="container">
        <div class="panel panel-primary">
            <div class="panel-heading">Ingrese datos a modificar del Vehiculo</div>
            <div class="panel-body">

                <div class="form-group">
                    <asp:label id="lblDominio" runat="server" text="Dominio:" cssclass="control-label col-md-3"></asp:label>
                    <div class="col-md-3">
                        <asp:textbox id="txtDominio" runat="server" cssclass="form-control"></asp:textbox>
                    </div>
                    <asp:label id="lblAño" runat="server" text="Año:" cssclass="control-label col-md-3"></asp:label>
                    <div class="col-md-3">
                        <asp:textbox id="txtAño" runat="server" cssclass="form-control"></asp:textbox>
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
                    <asp:label id="lblNumeroMotor" runat="server" text="Numero de Motor:" cssclass="control-label col-md-3"></asp:label>
                    <div class="col-md-3">
                        <asp:textbox id="txtNumeroMotor" runat="server" cssclass="form-control"></asp:textbox>
                    </div>
                    <asp:label id="lblNumeroChasis" runat="server" text="Numero de chasis:" cssclass="control-label col-md-3"></asp:label>
                    <div class="col-md-3">
                        <asp:textbox id="txtNumeroChasis" runat="server" cssclass="form-control"></asp:textbox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:button id="btnModificar" runat="server" text="Modificar" class="btn btn-primary" OnClick="btnModificar_Click"   />
                </div>

            </div>
        </div>
    </div>
</asp:Content>
