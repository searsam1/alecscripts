function activate_left() {
    let h2s = document.querySelectorAll("H2");
    let h3s = document.querySelectorAll("H3");
    let sidebar = document.querySelector("#rightSideList");
    for (let h2 of h2s) {
        if (h2.getAttribute("class") != "ignore") {
            h2.setAttribute('class', 'header')
        }
    }
    for (let h3 of h3s) {
        if (h3.getAttribute("class") != "ignore") {
            h3.setAttribute('class', 'header header-3')
        }
    }
    let c = document.querySelector("H1").textContent.split(":")[0]
    let btns = document.querySelector("#leftSidebar").querySelector("UL").querySelectorAll('button')
    for (let btn of btns) {
        if (btn.textContent.trim(" ") == c) {
            btn.ariaExpanded = "true"
            btn.parentElement.querySelector("div").setAttribute('class', 'collapse show')
        }
    }
    let title = document.querySelector("H1").textContent.split(":")[1].replace(/ /g, "")
    let links = document.querySelector("#leftSidebar").querySelector("UL").querySelectorAll("LI");
    for (let link of links) {
        let res = link.textContent.replace(/ /g, "").replace(/\n/g, "")
        if (c + title == res) {
            link.querySelector('a').style.background = 'rgba(0, 0, 0, .1) '
            link.querySelector('a').style.color = 'white'
            link.querySelector('a').style.fontWeight = '500 '
            link.querySelector('a').setAttribute('id', "activeLeft")
            link.querySelector('a').setAttribute('class', "none")
            link.style.borderRadius = "10px";
            link.style.background = "#000";
        }
    }
}
activate_left()

