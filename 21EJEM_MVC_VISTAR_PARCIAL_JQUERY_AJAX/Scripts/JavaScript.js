document.addEventListener("DOMContentLoaded", function () {
    var btnpersonas = document.querySelector("#btnpersonas");
    var detallepersonas = document.querySelector("#detallepersonas");
    var btnlenguajes = document.querySelector("#btnlenguajes");
    var detallelenguajes = document.querySelector("#detallelenguajes");
    //var detallespersonasId = document.getElementById("#btnpersonas");
    // Inicialmente ocultar detallespersonas
    detallepersonas.style.display = "none";
    // Guardar el valor original de detallepersonas y detallelenguajes
    var detallepersonasOriginal = detallepersonas.innerHTML;
    var detallelenguajesOriginal = detallelenguajes.innerHTML;

    btnpersonas.addEventListener("click", function () {
        if (detallepersonas.style.display === "none") {
            detallepersonas.style.display = "block";
            if (detallepersonas.innerHTML === detallepersonasOriginal) {
                var xhttp = new XMLHttpRequest();
                xhttp.onreadystatechange = function () {
                    if (this.readyState == 4 && this.status == 200) {
                        detallepersonas.innerHTML = this.responseText;
                    }
                };
                xhttp.open("GET", "/Detalles/RecuperarPersonas", true);
                xhttp.send();
            }
        } else {
            detallepersonas.style.display = "none";
            // Restablecer al valor original
            detallepersonas.innerHTML = detallepersonasOriginal;
        }
    });

    btnlenguajes.addEventListener("click", function () {
        if (detallelenguajes.innerHTML === detallelenguajesOriginal) {
            var xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {
                    detallelenguajes.innerHTML = this.responseText;
                }
            };
            xhttp.open("GET", "/Detalles/RecuperarLenguajes", true);
            xhttp.send();
        } else {
            // Restablecer al valor original
            detallelenguajes.innerHTML = detallelenguajesOriginal;
        }
    });
});
