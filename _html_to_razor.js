

function convert_lt(str){
    str = str.replaceAll("<", "&lt;");
    str = str.replaceAll(">", "&gt;");
    return str; 
}






console.log(convert_lt(`<!DOCTYPE html>
<html>
    <body>

    <h1>My First Web Page</h1>
    <p>
        My First Paragraph
    </p>

    <p id="demo">

    </p>

    <script>
        document.getElementById("demo").innerHTML = 5 + 6;
    </script>

    </body>
</html>`))
