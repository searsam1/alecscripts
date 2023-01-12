function leftScrollTop(){
    if (document.querySelector){
        let leftSidebar = document.querySelector('#leftSidebar');
        let activeLeft = document.querySelector("#activeLeft")
        let height = $( activeLeft ).position()["top"]
        leftSidebar.scrollTop = height - 5
        // messageBody.scrollTop = height.scrollHeight - height.clientHeight;
    }
}
leftScrollTop()