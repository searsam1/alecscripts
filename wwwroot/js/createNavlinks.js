function createDirectory(){     
    let navbar = document.querySelector(".navbar-nav");        
    let Sidebar =  document.querySelector("#leftSidebar").querySelector("UL").querySelectorAll("li")

    let header 
    let a 
    let btn 

    for (let link of Sidebar){
        // for the headers


        if (link.querySelector("button")){
            header = document.createElement("h2")
            header.textContent = link.querySelector("button").textContent
                        
            new_nav = document.createElement("li")
            new_nav.setAttribute("class", "nav-item")
            side_a = document.createElement("a")
            side_a.setAttribute("class", "nav-link")
            side_a.textContent = header.textContent
            side_a.setAttribute("href", link.querySelector("a").getAttribute("href"))
            
            
            new_nav.appendChild(side_a)
            navbar.appendChild(new_nav)
            
        }
    }
    
    
}
createDirectory()