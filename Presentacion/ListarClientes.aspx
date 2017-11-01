<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListarClientes.aspx.cs" Inherits="Presentacion.ListarClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
<table id="table"
                data-search="true"
                data-toogle="table"
                data-pagination="true"
                data-click-to-select="true"
                data-toolbar="#toolbar"
                data-show-toggle="true"
                data-show-columns="true"
                data-show-export="true"
                data-minimum-count-columns="2"
                data-page-list="[10, 25, 50, 100, ALL]"
                data-id-field="vehiculoId"
                data-show-footer="false">
                <thead>
                    <tr>
                        <th data-field="clienteId">Código cliente</th>
                        <th data-field="clienteApellido">Apellido</th>
                        <th data-field="clienteNombre">Nombre</th>
                        <th data-field="clienteDni">Dni</th>
                        <th data-field="clienteFechaNacimiento">FechaNacimiento</th>
                        <th data-field="clienteDomicilio">Domicilio</th>
                        <th data-field="clienteTelefono">Telefono</th>
                        <th data-field="clienteMail">Mail</th>
                        <th data-field="clienteEstado">Estado</th>
                        <th data-field="operate" data-formatter="operateFormatter" data-events="operateEvents" data-align="center" data-width="100">Acciones</th>
                    </tr>
                </thead>
            </table>

    </div>
    <script>
        $('#table').bootstrapTable({
            data: <%= pasarAJson() %>,
        });
        var scripts = [
                      location.search.substring(1) || 'bootstrap-table-master/src/bootstrap-table.js',
                      'bootstrap-table-master/src/extensions/export/bootstrap-table-export.js',
                      'http://rawgit.com/hhurz/tableExport.jquery.plugin/master/tableExport.js',
                      'bootstrap-table-master/src/extensions/editable/bootstrap-table-editable.js',
                      'http://rawgit.com/vitalets/x-editable/master/dist/bootstrap3-editable/js/bootstrap-editable.js'
                      
        ]
 

        function operateFormatter(value, row, index) {
            return [
        
                '<a href="javascript:void(0)" title="Editar">',
                    '<i class="glyphicon glyphicon-edit"></i>',
                '</a>',
                '<a href="javascript:void(0)" title="Eliminar">',
                    '<i class="glyphicon glyphicon-remove"></i>',
                '</a>'
            ].join('');
        }

        window.operateEvents = {
            'click .editar': function (e, value, row, index) {
                alert('Prueba');
            },
            'click .eliminar': function (e, value, row, index) {
                $table.bootstrapTable('remove', {
                    field: 'vehiculoId',
                    values: [row.vehiculoId]
                });
            }
        }

    </script>
</asp:Content>
