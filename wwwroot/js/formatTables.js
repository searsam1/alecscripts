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