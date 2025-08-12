function ShowApto() {
    let show = document.getElementById("addDiv");
    let alertBox = document.querySelector(".alert");
 

    show.removeAttribute("hidden");

   document.getElementById("numero").value = '';
   document.getElementById("bloco").value = '';
   document.getElementById("vaga").value = false;
   document.getElementById("situacao").value = 0;

    if(alertBox){
        alertBox.style.display = "none";
    }   
    

}