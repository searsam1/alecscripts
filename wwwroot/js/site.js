// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let hidden = document.getElementsByClassName("hidden");

for (const cls of hidden){
    cls.style.display = "none";
}


function showClass(className){
    let cls = document.querySelector(`.${className}`)
    let display = cls.style.display
    // check == "" to see if there is no display element 
    // if its none and btn is clicked, display in block
    // if its block, hide it with setting display to "none"
    cls.style.display = display == "" ? "block" : display == "none" ? "block" : "none"

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

    let classes = e.className.split(' ')


    if (classes[1] == "fs-4"){
        var indent = document.createAttribute("style")
        indent.value = "padding-left: 5%; font-size: 90%;"
        a.setAttributeNode(indent)
        li.setAttribute("style", "list-style-type: none; ")
    }

    href.value = `#${id_}`
    a.setAttributeNode(href)
    
    if (classes[1] == "fs-4"){
        a.setAttribute("class", "link link-inner")
    }
    else{
        a.setAttribute("class", "link")
    }   

    a.textContent += e.textContent.trim(" ")
    li.appendChild(a)
    return li;
}


function randomByte(){
    return Math.floor(Math.random() * 1048576);
}


function createTOC(){
    headers = document.getElementsByClassName("display-6")
    toc = document.getElementsByClassName("toc-container")[0]
    let txt;
    
    let i;
    for (header of headers){
        // https://stackoverflow.com/questions/4328500/how-can-i-strip-all-punctuation-from-a-string-in-javascript-using-regex
        txt = header.textContent.replace(/[^\w\s\']|_/g, "")
        .replace(/\s+/g, " ")
        .trim(" ")
        .replace(/\s/g, "-")

        var att = document.createAttribute("id")
        att.value = txt.trim() + "-" + randomByte().toString().trim();
        header.setAttributeNode(att)
        toc.appendChild(createTocLink(header, att.value))
            
    }
}
createTOC();





function createSidebar(){
    let sidebar = document.getElementById("sidebar");
    
    let pageHeader = document.getElementsByClassName("display-4")[0].textContent
    let nav = document.createElement("NAV");
    nav.textContent = pageHeader
    nav.setAttribute("style", "font-family: 'Poppins', sans-serif; color: crimson;")


    headers = document.getElementsByClassName("display-6");

    let i = 0;
    for (let header of headers){
        let p = document.createElement("P");
        let a = document.createElement("A");
        a.textContent = header.textContent;
        a.setAttribute("href", `#${i}`);
        a.setAttribute("class", "sidebar-link");
        p.appendChild(a);
        nav.appendChild(p);

        i += 1;
    }
    sidebar.appendChild(nav);

    return nav;
    // <nav><a></a></nav>
}
// createSidebar()


function formatLinks(){
    allLinks = document.getElementsByTagName("a");
    for (let link of allLinks){
        link.setAttribute("title", link.href);
    }
}


function alternateTableColor(){
    let tables = document.querySelectorAll("TABLE");

    for (let table of tables){
        let trs = table.querySelectorAll("tr")
        i = -1; 
        for (let tr of trs){
            i++; 
            if (i % 2){
                tr.style.backgroundColor = "rgb(255,1,200, .2)";
            }
            
        }
    }
}
alternateTableColor()

function applyShadowToCode(){
    
    // PREs (like multiple pre)
    let pres = document.querySelectorAll("PRE", "CODE")
    for (let pre of pres){
        pre.setAttribute("class", " shadow-sm")
        console.log(pre)
    }

}
applyShadowToCode()