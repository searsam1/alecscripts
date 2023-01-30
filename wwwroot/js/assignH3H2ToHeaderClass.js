function assignHeadersToHeaderClass() {
    
    // assign H2 tags to `header`
    // assign h3 tags to `header header-3`
    
    let h2s = document.querySelectorAll("H2");
    let h3s = document.querySelectorAll("H3");
    
    for (let h2 of h2s) {
        
    // ignore class for example h2 tags 
    if (h2.getAttribute("class") != "ignore") {
            h2.setAttribute('class', 'header')
        }
    }
    for (let h3 of h3s) {
        if (h3.getAttribute("class") != "ignore") {
            h3.setAttribute('class', 'header header-3')
        }
    }
}

assignHeadersToHeaderClass()



