document.addEventListener("DOMContentLoaded", function () {
    var btnhospitales = document.querySelector("#btnhospitales");
    var detallehospitales = document.querySelector("#detallehospitales");
    var btnlenguajes = document.querySelector("#btnlenguajes");
    var detallelenguajes = document.querySelector("#detallelenguajes");
    //var detallespersonasId = document.getElementById("#btnpersonas");
    // Inicialmente ocultar detallespersonas
    detallehospitales.style.display = "none";
    // Guardar el valor original de detallepersonas y detallelenguajes
    var detallepersonasOriginal = detallehospitales.innerHTML;
    var detallelenguajesOriginal = detallelenguajes.innerHTML;

    btnhospitales.addEventListener("click", function () {
        console.log("click!");
        if (detallehospitales.style.display === "none") {
            detallehospitales.style.display = "block";
            if (detallehospitales.innerHTML === detallepersonasOriginal) {
                var xhttp = new XMLHttpRequest();
                xhttp.onreadystatechange = function () {
                    if (this.readyState == 4 && this.status == 200) {
                        detallehospitales.innerHTML = this.responseText;
                    }
                };
                xhttp.open("GET", "/Detalles/RecuperarPersonas", true);
                xhttp.send();
            }
        } else {
            detallehospitales.style.display = "none";
            // Restablecer al valor original
            detallehospitales.innerHTML = detallepersonasOriginal;
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
