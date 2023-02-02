function activate_left() {
    
    /* 
        Open the left sidebar to the right section, 
        and highlight the right page

        Ex. 
            Section -> CSS
            Page -> CSS Home    
    */ 
    
    // controller (java, css, etc..)
    let c = document.querySelector("H1").textContent.split(":")[0]
    let btns = document.querySelector("#leftSidebar").querySelector("UL").querySelectorAll('button')
    for (let btn of btns) {
        if (btn.textContent.trim(" ") == c) {
            // open sidebar
            btn.ariaExpanded = "true"
            btn.parentElement.querySelector("div").setAttribute('class', 'collapse show')
        }
    }
    // get title of the page to 
    // activate on the left sidebar
    let title = document.querySelector("H1").textContent.split(":")[1].replace(/ /g, "")
    let links = document.querySelector("#leftSidebar").querySelector("UL").querySelectorAll("LI");
    for (let link of links) {
        let a  = link.querySelector('a')
        
        // get rid of spaces and newlines
        let res = link.textContent.replace(/ /g, "").replace(/\n/g, "")
        if (title == res) {
            link.style.borderBottom = "1px solid #f1f1f1"
            a.style.color = 'black'
            a.style.fontWeight = '500 '
            a.setAttribute('id', "activeLeft")
            a.setAttribute('class', "activeLeft")            
        }
    }
}
activate_left()
