var table
$(document).ready(function () {
    CargarDatosPack();
    $.fn.dataTable.ext.errMode = 'throw'
    table = $('#table-pack').dataTable({
        'bJQueryUI': true,
        'bLengthChange': true,
        'scrollCollapse': true,
        'bPaginate': true,
        'bFilter': true,
        "paging": true,
        "ordering": true,
        "info": true,
        'iDisplayLength': 10, //Paginacion
        'oLanguage': {
            'sZeroRecords': "No hay recursos que mostrar.",
            'sInfo': "Registros _START_ al _END_ de _TOTAL_",
            'sInfoEmpty': "Registros 0 a 0 de 0",
            'sInfoFiltered': "(encontrados en _MAX_ registros totales)",
            'sProcessing': "Procesando...",
            'sInfoThousands': ".",
            "sSearch": "Buscar:",
            'oPaginate': {
                'sPrevious': "Anterior",
                'sNext': "Siguiente"
            }
        },

        "columns": [
            { "data": "idProveedorVenta", "sClass": "text-left" },
            { "data": "email", "sClass": "text-left" },
            { "data": "USD", "sClass": "text-left" },
            { "data": "descripcion", "sClass": "text-left" },
            { "data": "nombreEstado", "sClass": "text-left" },
            {
                "data": "idProveedorVenta", fnCreatedCell: function (nTd, sData, oData, iRow, iCol) {
                    $(nTd).html("<button class = 'btn btn-danger btn-sm'><i class= 'fa fa-trash'></i></button>");
                }
            }
        ]
    });
});

function CargarDatosPack() {
    $.ajax({
        dataType: "json",
        type: "POST",
        url: "/Home/ListarPack",
        async: true,
        success: function (result) {
            LlenarDatosPack(result);
        },
        error: function (x, y, z) {
            //swal("Error detectado!", "Por favor vuelva a intentarlo", "error");
            console.log("Error al listar los pack")
        }
    });
}

function LlenarDatosPack(respuesta) {
    table.fnClearTable();
    table.fnAddData(respuesta);
}