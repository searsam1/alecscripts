function highlightRight() {
    // get list of sidebar links and
    // page h2's
    let rightSidebar = $("#rightSidebar li")
    let h2_s = $(".header")
    let len = rightSidebar.length
    $(window).scroll(function () {
        for (let i = 0; i < len; i++) {
            header = h2_s[i];
            rightLink = rightSidebar[i];
            rightLink.querySelector("a").style.width = "100%"
            if ($(header).position()["top"] - 38 < $(document).scrollTop()) {
                rightLink.querySelector("a").style.color = "white"
                rightLink.querySelector("a").style.backgroundColor = "black"
                rightLink.querySelector("a").setAttribute('class', 'none')
                if (i != 0) {
                    header = h2_s[i - 1];
                    rightLink = rightSidebar[i - 1];
                    rightLink.querySelector("a").style.color = "black"
                    rightLink.querySelector("a").style.backgroundColor = "rgb(1,1,1,.1)"
                }
            }
            else {
                rightLink.querySelector("a").style.color = "black"
                rightLink.querySelector("a").style.backgroundColor = "white"
            }
        }
    });
}
highlightRight();