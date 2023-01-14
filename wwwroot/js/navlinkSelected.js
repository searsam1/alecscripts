function navlinkSelected(){
    let txt;
    let navbar = document.querySelector(".collapse.navbar-collapse").querySelector("UL")
    
    // viewdataName == @viewData["Controller"]
    // from _layout.cshtml
    let controller = viewdataName.toLowerCase().replace("c&#x2b;&#x2b;", "c++").replace("js", "javascript")
    let t = '@ViewData["title"]'.trim(" ").toLowerCase()
    for (let li of navbar.querySelectorAll("LI")) {
        txt = li.textContent.trim(" ").toLowerCase();
        if (txt == controller || txt == t) {
            li.setAttribute("class", "navlinkSelected")
        }
    }
}
navlinkSelected()
console.info("Selected navbar")