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
    if (e.textContent.trim(" ") == "Table of Contents"){
        return null;
    }
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
    let headers = document.getElementsByClassName("display-6")
    let toc = document.getElementsByClassName("toc-container")[0]
    let txt, child, childIsBorn;
    
    let i;
    for (header of headers){
        // https://stackoverflow.com/questions/4328500/how-can-i-strip-all-punctuation-from-a-string-in-javascript-using-regex
        txt = header.textContent.replace(/[^\w\s\']|_/g, "")
        .replace(/\s+/g, " ")
        .trim(" ")
        .replace(/\s/g, "-")

        var att = document.createAttribute("id")
        att.value = txt.trim(); // + "-" + randomByte().toString().trim();
        header.setAttributeNode(att)
        child = createTocLink(header, att.value)
        childIsBorn = child != null;
        if (childIsBorn){
            toc.appendChild(child)
        }
            
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




function applyShadowToCode(){
    
    // PREs (like multiple pre)
    let pres = document.querySelectorAll("PRE", "CODE")
    for (let pre of pres){
        pre.setAttribute("class", " shadow-sm")
        
    }

}
applyShadowToCode()


function getColorArr(x) {
    if (x == "names") {return ['AliceBlue','AntiqueWhite','Aqua','Aquamarine','Azure','Beige','Bisque','Black','BlanchedAlmond','Blue','BlueViolet','Brown','BurlyWood','CadetBlue','Chartreuse','Chocolate','Coral','CornflowerBlue','Cornsilk','Crimson','Cyan','DarkBlue','DarkCyan','DarkGoldenRod','DarkGray','DarkGrey','DarkGreen','DarkKhaki','DarkMagenta','DarkOliveGreen','DarkOrange','DarkOrchid','DarkRed','DarkSalmon','DarkSeaGreen','DarkSlateBlue','DarkSlateGray','DarkSlateGrey','DarkTurquoise','DarkViolet','DeepPink','DeepSkyBlue','DimGray','DimGrey','DodgerBlue','FireBrick','FloralWhite','ForestGreen','Fuchsia','Gainsboro','GhostWhite','Gold','GoldenRod','Gray','Grey','Green','GreenYellow','HoneyDew','HotPink','IndianRed','Indigo','Ivory','Khaki','Lavender','LavenderBlush','LawnGreen','LemonChiffon','LightBlue','LightCoral','LightCyan','LightGoldenRodYellow','LightGray','LightGrey','LightGreen','LightPink','LightSalmon','LightSeaGreen','LightSkyBlue','LightSlateGray','LightSlateGrey','LightSteelBlue','LightYellow','Lime','LimeGreen','Linen','Magenta','Maroon','MediumAquaMarine','MediumBlue','MediumOrchid','MediumPurple','MediumSeaGreen','MediumSlateBlue','MediumSpringGreen','MediumTurquoise','MediumVioletRed','MidnightBlue','MintCream','MistyRose','Moccasin','NavajoWhite','Navy','OldLace','Olive','OliveDrab','Orange','OrangeRed','Orchid','PaleGoldenRod','PaleGreen','PaleTurquoise','PaleVioletRed','PapayaWhip','PeachPuff','Peru','Pink','Plum','PowderBlue','Purple','RebeccaPurple','Red','RosyBrown','RoyalBlue','SaddleBrown','Salmon','SandyBrown','SeaGreen','SeaShell','Sienna','Silver','SkyBlue','SlateBlue','SlateGray','SlateGrey','Snow','SpringGreen','SteelBlue','Tan','Teal','Thistle','Tomato','Turquoise','Violet','Wheat','White','WhiteSmoke','Yellow','YellowGreen']; }
    if (x == "hexs") {return ['f0f8ff','faebd7','00ffff','7fffd4','f0ffff','f5f5dc','ffe4c4','000000','ffebcd','0000ff','8a2be2','a52a2a','deb887','5f9ea0','7fff00','d2691e','ff7f50','6495ed','fff8dc','dc143c','00ffff','00008b','008b8b','b8860b','a9a9a9','a9a9a9','006400','bdb76b','8b008b','556b2f','ff8c00','9932cc','8b0000','e9967a','8fbc8f','483d8b','2f4f4f','2f4f4f','00ced1','9400d3','ff1493','00bfff','696969','696969','1e90ff','b22222','fffaf0','228b22','ff00ff','dcdcdc','f8f8ff','ffd700','daa520','808080','808080','008000','adff2f','f0fff0','ff69b4','cd5c5c','4b0082','fffff0','f0e68c','e6e6fa','fff0f5','7cfc00','fffacd','add8e6','f08080','e0ffff','fafad2','d3d3d3','d3d3d3','90ee90','ffb6c1','ffa07a','20b2aa','87cefa','778899','778899','b0c4de','ffffe0','00ff00','32cd32','faf0e6','ff00ff','800000','66cdaa','0000cd','ba55d3','9370db','3cb371','7b68ee','00fa9a','48d1cc','c71585','191970','f5fffa','ffe4e1','ffe4b5','ffdead','000080','fdf5e6','808000','6b8e23','ffa500','ff4500','da70d6','eee8aa','98fb98','afeeee','db7093','ffefd5','ffdab9','cd853f','ffc0cb','dda0dd','b0e0e6','800080','663399','ff0000','bc8f8f','4169e1','8b4513','fa8072','f4a460','2e8b57','fff5ee','a0522d','c0c0c0','87ceeb','6a5acd','708090','708090','fffafa','00ff7f','4682b4','d2b48c','008080','d8bfd8','ff6347','40e0d0','ee82ee','f5deb3','ffffff','f5f5f5','ffff00','9acd32']; }
  }


  function alternateTableColor(){
    let tables = document.querySelectorAll("TABLE");

    for (let table of tables){
        let trs = table.querySelectorAll("tr")
        i = -1; 
        for (let tr of trs){
            i++; 
            if (i % 2){
                tr.style.backgroundColor = "rgb(0,0,0,.05)";
            }
            
        }
    }
}
alternateTableColor()

