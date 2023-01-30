


function fillRightSidebar() {
    // Get the H2's from the page and 
    // add to the right sidebar 
    let sidebar = document.querySelector("#rightSideList");
    // h2 tags
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
fillRightSidebar()
console.info("Activate Right")