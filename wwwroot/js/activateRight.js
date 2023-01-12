function activate_right() {
    let sidebar = document.querySelector("#rightSideList");
    let headers = document.querySelectorAll(".header")
    for (let header of headers) {
        let link = document.createElement('A')
        let li = document.createElement('LI')
        let text = header.textContent.replace(/[^a-zA-Z]/g, '');
        link.setAttribute("class", "link-dark")
        header.setAttribute('id', text)
        link.setAttribute('href', '#' + text)
        link.textContent = header.textContent
        li.appendChild(link)
        sidebar.append(li)
        if (header.getAttribute('class') == "header header-3") {
            link.style.paddingLeft = "25px"
            link.style.borderLeft = "1px double black"
        }
        else {
            link.style.borderLeft = "2px solid black"
        }
        if (header.textContent.trim(" ") == "^") {
            link.style.borderLeft = "none"
        }
    }
}
activate_right()