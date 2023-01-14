function highlightRight() {
    // get list of sidebar links and
    // page h2's
    let rightSidebar = $("#rightSidebar li")
    let h2_s = $("h2")
    let len = rightSidebar.length
    $(window).scroll(function () {
        for (let i = 0; i < len; i++) {
            header = h2_s[i];
            rightLink = rightSidebar[i];
            if ($(header).position()["top"] - 38 < $(document).scrollTop()) {
                // rgb(255,0,255, .1)
                rightLink.style.backgroundColor = "  rgb(255, 193, 9,.2)"
                rightLink.querySelector("a").setAttribute("class", " link-dark py-2")
                if (i != 0) {
                    header = h2_s[i - 1];
                    rightLink = rightSidebar[i - 1];
                    rightLink.querySelector("a").style.color = "black"
                    rightLink.style.backgroundColor = "white"
                    rightLink.querySelector("a").setAttribute("class", "link-dark py-2")
                }
            }
            else {
                rightLink.querySelector("a").style.color = "black"
                rightLink.style.backgroundColor = "white"
                rightLink.querySelector("a").setAttribute("class", "link-dark py-2")
            }
        }
    });
}
highlightRight();
console.info("Highlight Right")