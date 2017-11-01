<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListarVehiculos.aspx.cs" Inherits="Presentacion.ListarVehiculos" %>

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
                    <th data-field="vehiculoId">Código vehiculo</th>
                    <th data-field="vehiculoDominio">Dominio</th>
                    <th data-field="marcaDescripcion">Marca</th>
                    <th data-field="modeloDescripcion">Modelo</th>
                    <th data-field="vehiculoAnio">Año</th>
                    <th data-field="vehiculoNumeroChasis">N° de chasis</th>
                    <th data-field="vehiculoNumeroMotor">N° motor</th>
                    <th data-field="tipoVehiculoDescripcion">Vehiculo</th>
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
