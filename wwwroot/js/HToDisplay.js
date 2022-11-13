
function editH1(){
    // Get all H1's and 
    // add .display-6 to them
    let H1Array = document.getElementsByTagName("H1");
    for (let H1 of H1Array){
        let classAttribs = H1.getAttribute("class");
        if (classAttribs == null){
            H1.setAttribute("class", "display-6")
        }
        else if (classAttribs.trim() != "display-6 fs-4 indent-1") {
            H1.setAttribute("class", "display-6")
        }
    }
}

function editH2(){
    // Get all H1's and 
    // add .display-6 to them
    let H2Array = document.getElementsByTagName("H2");
    for (let H2 of H2Array){
        H2.setAttribute("class", "display-6 fs-4 indent-1")
    }
}


editH1()
editH2()