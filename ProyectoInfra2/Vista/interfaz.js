function confirmarSalida() {
    var ask = window.confirm("¿Está seguro? Se perderán los datos");

    if (ask) {
        document.location.href = "login.aspx";
    }

    return !ask;
}

function confirmarCierre() {
    var ask = window.confirm("¿Está seguro de cerrar sesión?");

    if (ask) {
        document.location.href = "login.aspx";
    }

    return !ask;
}
function mostrar(value_elemento) {
    var total = 3; //total de mis capas
    var elemento;
    for (var i = 1; i <= total; i++) { //desde 1 para no tomar en cuenta el primero
        elemento = document.getElementById('capa' + i);
        if (i == value_elemento) {
            elemento.style.display = "block";
        } else {
            elemento.style.display = "none";
        }
    }
}