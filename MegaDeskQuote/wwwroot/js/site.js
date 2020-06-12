// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


//alefinir 12062020
// This is the code to preload the images
var imageList = Array();
for (var i = 1; i <= 5; i++) {
    imageList[i] = new Image(300, 300);
    imageList[i].src = "http://www.flowsim.se/picts/selec0" + i + "Big.jpg";
}

function switchImage() {
    //var selectedImage = document.myForm.switch.options[document.myForm.switch.selectedIndex].value;
    //document.myImage.src = "../../images" + selectedImage + "Big.jpg";
    d = document.getElementById("idImg").value;
    alert(d);
}


function chgImage() {
    document.getElementById("idImg").src = "../../images" + document.getElementById("idTMaterials").SelectedIndex.value + "Big.jpg";
}

function showImage() {
    d = $("#idTMaterials option:selected").text();
    document.getElementById("idImg").src = "../../images/" + d + "Big.jpg";
}