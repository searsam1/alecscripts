// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let hidden = document.getElementsByClassName("hidden");

for (const cls of hidden){
    cls.style.display = "none";
}

console.log(hidden);


function showID(id){
    let ele = document.getElementById(id);
    let screenWidth = document.getElementsByTagName("body")[0].clientWidth;
    console.log(screenWidth);

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