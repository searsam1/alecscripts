function createToc(){
    tocList = document.querySelector("#tocList")
    headers = document.querySelectorAll(".header")
    for (let header of headers){
    li = document.createElement("li")
    a = document.createElement("a")
    a.setAttribute("href", "#" + header.getAttribute("id"))
    a.setAttribute("class", "nav-link")
    a.textContent = header.textContent
    li.appendChild(a)
    tocList.appendChild(li)
    }
    }
createToc();