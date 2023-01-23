
function callbackOVER(){
    this.setAttribute(
        "class", 
            this.getAttribute("class")
                .replace("text-muted", "text-light")  
                .replace("border-bottom border-secondary", "border-bottom border-warning")  
            )
}

function callbackOUT(){
    this.setAttribute(
        "class", 
            this.getAttribute("class")
                .replace("text-light", "text-muted")
                .replace("border-bottom border-warning", "border-bottom border-secondary", )
                )
}

function hoverFooterLinks(){
    let theFootLinks = document.querySelector(".thefoot").querySelectorAll('a'); 
    theFootLinks.forEach(c => c.addEventListener("mouseover", callbackOVER))
    theFootLinks.forEach(c => c.addEventListener("mouseout", callbackOUT))
}
hoverFooterLinks()
