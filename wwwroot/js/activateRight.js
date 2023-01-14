function activate_right() {
    let sidebar = document.querySelector("#rightSideList");
    let headers = document.querySelectorAll("h2")

    sidebar.style.borderLeft = "2px solid rgb(205, 205, 205)"

    for (let header of headers) {
        let link = document.createElement('A')
        let li = document.createElement('LI')
        let text = header.textContent.replace(/[^a-zA-Z]/g, '');
        link.setAttribute("class", "link-dark py-2")
        header.setAttribute('id', text)
        link.setAttribute('href', '#' + text)
        link.textContent = header.textContent
        li.appendChild(link)
        sidebar.append(li)
        if (header.textContent.trim(" ") == "^") {
            link.style.borderLeft = "none"
        }
        link.style.textTransform = "capitalize"
    }
}
activate_right()
console.info("Activate Right")