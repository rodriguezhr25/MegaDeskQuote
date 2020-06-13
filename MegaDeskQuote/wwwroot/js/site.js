// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


//alefinir 12062020
// This is the code to preload the images


function showImage() {
    var material = $('#idTMaterials').val();
    if (material != "") {
        d = $("#idTMaterials option:selected").text();
        document.getElementById("idImg").src = "../../images/" + d + "Big.jpg";
        document.getElementById("idImg").removeAttribute("hidden");
        document.getElementById("containerImg").removeAttribute("hidden");
    } else {
        document.getElementById("containerImg").setAttribute("hidden", true);
        document.getElementById("idImg").setAttribute("hidden", true);
    }
}

