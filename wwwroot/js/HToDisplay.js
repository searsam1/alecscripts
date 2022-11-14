
function editH2(){
    // Get all H2's and 
    // add .display-6 to them
    let H2Array = document.getElementsByTagName("H2");
    for (let H2 of H2Array){
        let classAttribs = H2.getAttribute("class");
        if (classAttribs == null){
            H2.setAttribute("class", "display-6")
        }
        else if (classAttribs.trim() != "display-6 fs-4 indent-1") {
            H2.setAttribute("class", "display-6")
        }
    }
}

function editH3(){
    // Get all H3's and 
    // add .display-6 to them
    let H3Array = document.getElementsByTagName("H3");
    for (let H3 of H3Array){
        H3.setAttribute("class", "display-6 fs-4 indent-1")
    }
}


editH2()
editH3()