
function editOpacity(iter, text){
    
    iter.forEach(element => {
        if (! element.textContent.toLowerCase().includes(text.toLowerCase())){
            element.style.opacity = "20%"
            element.style.background = "white"
        }
        else {
            element.style.background = "yellow"
            element.style.opacity = "100%"
        }
    });
}

function f() {
    let allP = document.querySelectorAll("P");
    let allH2 = document.querySelectorAll("H2");
    let allH3 = document.querySelectorAll("H3");
    let allCode = document.querySelectorAll("PRE");
    let text = this.value;
    if (!text){
        location.reload();
        return;
    }

    editOpacity(allP, text)
    editOpacity(allH2, text)
    editOpacity(allH3, text)
    editOpacity(allCode, text)
}

function pageSearch(){

    let searchBar = document.querySelector("#searchBar")
    searchBar.addEventListener("change", f, false)
}
pageSearch()