// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let hidden = document.getElementsByClassName("hidden");

for (const cls of hidden){
    cls.style.display = "none";
}


function showID(id){
    let ele = document.getElementById(id);
    let screenWidth = document.getElementsByTagName("body")[0].clientWidth;

    if (!ele.style.display){
        if (screenWidth > 1250){
            ele.style.display = "block";
        }
        else{
            ele.style.display = "none";
        }
    }
    let visible = ele.style.display === "none" ? "block" : "none";
    ele.style.display = visible;

}
function flip(id){
    let ele = document.getElementById(id)
    // console.log(ele.style.transform)

    if ( !ele.style.transform){
        ele.style.transform = 'rotate(90deg)'    
    }
    else if ( ele.style.transform === "rotate(90deg)" ){
        ele.style.transform = 'rotate(0deg)'
    }
    else if ( ele.style.transform === "rotate(0deg)" ){
        ele.style.transform = 'rotate(90deg)'
    }
}
function flip2(id){
    let ele = document.getElementById(id)
    // console.log(ele.style.transform)

    if ( !ele.style.transform){
        ele.style.transform = 'rotate(90deg)'    
    }
    else if ( ele.style.transform === "rotate(90deg)" ){
        ele.style.transform = 'rotate(0deg)'
    }
    else if ( ele.style.transform === "rotate(0deg)" ){
        ele.style.transform = 'rotate(90deg)'
    }
}
function darkMode(){
    let body = document.getElementsByTagName("body")[0];
    let bg = body.style.backgroundColor;
    if (bg === "black"){
        body.style.backgroundColor = "white";
        
    }
    if (bg != "black"){
        body.style.backgroundColor = "black";
        
    }
}

function createTocLink(e, id_){
    var li = document.createElement("li");
    var a = document.createElement("a");
    var href = document.createAttribute("href")
    href.value = `#${id_}`
    a.setAttributeNode(href)
    a.setAttribute("class", "link")
    a.textContent = e.textContent.trim(" ")
    li.appendChild(a)
    return li;
}

function createTOC(){
    headers = document.getElementsByClassName("display-6")
    toc = document.getElementsByClassName("toc-container")[0]
    console.log(toc)

    var i = 0;
    for (header of headers){
        var att = document.createAttribute("id")
        att.value = i;
        i++;
        header.setAttributeNode(att)
        toc.appendChild(createTocLink(header, att.value))
            
    }
}
createTOC();

function copyToClip(){
    
}