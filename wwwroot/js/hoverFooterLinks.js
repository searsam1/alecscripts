


function callbackOVER(){
    this.setAttribute(
        "class", 
            this.getAttribute("class")
                .replace("text-white", "text-warning")  
                .replace("border-bottom", "")  
            )
}

function callbackOUT(){
    this.setAttribute(
        "class", 
            this.getAttribute("class")
                .replace("text-warning", "text-white")
                + " border-bottom"
                )
}

function hoverFooterLinks(){
    let theFootLinks = document.querySelector(".thefoot").querySelectorAll('a'); 
    theFootLinks.forEach(c => c.addEventListener("mouseover", callbackOVER))
    theFootLinks.forEach(c => c.addEventListener("mouseout", callbackOUT))
}
hoverFooterLinks()