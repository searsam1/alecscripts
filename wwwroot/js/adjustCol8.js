function adjustCol8(){
    if ($( window ).width() < 768){
        document.querySelector(".col-8.px-5.my-5").setAttribute("class", "col-8 my-5")
    }
}
adjustCol8()