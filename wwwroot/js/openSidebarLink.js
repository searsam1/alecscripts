function openSidebarLink(){
    let sidebar = document.querySelector(".sidebar");
    let controllers = sidebar.querySelectorAll("details");
    let pageController = document.querySelector("#controller").textContent.trim();
    let header

    for (let c of controllers){
        header = c.querySelector("summary").textContent.trim()
        if (header == pageController){
            c.setAttribute("open", "open")
            let links = c.getElementsByClassName("link")
            for (let a of links){
                if (a.textContent.trim().split(" ").slice(1).join(" ") == '@ViewData["title"]') {
                    a.style.backgroundColor = "hotPink";
                    a.style.color = "black";
                }

                
            }
        }
    }
    
}
openSidebarLink()
console.info("Open Sidebar")