$(document).ready(function () {
    loadData();
});

function loadData() {
    $.ajax({
        url: "/Sedes/List",
        //data: '1',
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.NOMBRE_SEDE + '</td>';
                html += '<td><center><a href="#" onclick="return getbyID(' + item.ID_SEDE + ')">Editar</a>    |    <a href="#" onclick="Delete(' + item.ID_SEDE + ')">Eliminar</a></center></td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}