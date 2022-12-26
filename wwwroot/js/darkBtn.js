// $white:    #fff;
// $gray-100: #f8f9fa;
// $gray-200: #e9ecef;
// $gray-300: #dee2e6;
// $gray-400: #ced4da;
// $gray-500: #adb5bd;
// $gray-600: #6c757d;
// $gray-700: #495057;
// $gray-800: #343a40;
// $gray-900: #212529;
// $black:    #000;


function changeToDarkMode(){
    body = document.querySelector("body")
    ls =  body.querySelector("#leftSidebar")
    rs =  body.querySelector("#rightSidebar")
    body.setAttribute("class", "bg-dark text-light")
    ls.querySelector(".bg-white").setAttribute("class", "bg-dark")
    rs.querySelector(".bg-white").setAttribute("class", "bg-dark")
    for (let i of body.querySelectorAll(".link-dark")){
        i.setAttribute("class", i.getAttribute("class").replace("link-dark", "") + " link-light")
    }

    for (let i of body.querySelectorAll(".btn")){
        i.setAttribute("class", i.getAttribute("class") + " text-light")
    }

    for (let i of document.querySelector("#toc").querySelectorAll(".nav-link")){
        i.setAttribute("class", " text-light")
    }
}

