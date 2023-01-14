function reset(h2){
    h2.style.background = "white"
    h2.textContent = h2.textContent.replace("⤷", "")
}


function copy() {
    
    let h2s = document.querySelectorAll("H2");

    h2s.forEach(h2 => {
        reset(h2)
    }); 
    
    // Get the text field
    let copyText = window.location.href
    copyText = copyText.split("#")[0]
    let ID = "#" + document.getElementById(this.id).id
    this.style.background = "rgb(255,255,0,.3)"
    
    if (!this.textContent.includes("⤷")){
        this.textContent = "⤷" + this.textContent 
    }
    else{
        this.textContent = this.textContent.replace("⤷", "")
        this.style.background = "inherit"
    }
    copyText += ID;
    // Copy the text inside the text field
    navigator.clipboard.writeText(copyText);
  }

function addH2events(){

    let h2s = document.querySelectorAll("H2");
    h2s.forEach(h2 => {
        h2.addEventListener("click", copy, false);
    });


}
addH2events();
console.info("Add h2 events")