

import clipboard  # copy()
import re  # findall()
import os  # walk


def title_split(s):
    """
    Split a string into different words
    by title case:
    ThisIsAmerica 
    ->
    "This Is America"
    """
    res = ''
    for i in range(1, len(s)):
        if s[i-1].islower() and s[i].isupper():
            res += " "
        res += s[i]
    # Split into an array of words, make them into title case, 
    # then join back together by spaces
    string = (s[0] + res).title() 
    return string if string != "Index" else "Home"

def replace_specials(txt):
    """
    Replace normal characters with special characters for display. 
    
    Ex. 
    Cpp -> C++
    
    """

    specials = {
        "Cpp" : "C++", 
        "Dotnet" : ".NET", 
    }
    for k,v in specials.items():
        txt = txt.replace(k, v)
    return txt 

def asp_link(controller, action):
    controller_label = replace_specials(controller)
    action_label = replace_specials(title_split(action))
    string = f"""
<a class="btn btn-light m-2" asp-action={action} asp-controller={controller}>
    {controller_label} {action_label}
</a>"""
    return string


def get_actions(fn, control):
    """
    Search for razor controllers
    that are C# methods with type IActionResult
    """
    actions = []
    p = r"IActionResult (\w+)"
    fp = fn + "/" + control
    with open(fp, "r") as f:
        lines = f.readlines()
    for line in lines:
        # Find actions
        matches = re.findall(p, line)
        if matches:
            actions.append(matches[0])
    # actions = sorted(actions)
    return actions


def get_controls():

    def pages(filename, controller):
        return "".join(asp_link(controller.split("Controller.cs")[0], action) 
            for action in get_actions(filename, controller))

    def sort_controllers(controllers):
        # sort controllers 
        controllers = sorted(controllers)
        # move home to the top
        controllers.pop(controllers.index("HomeController.cs"))
        controllers = ["HomeController.cs"] + controls
        return controllers
    
    fp = "/Users/111244rfsf/Documents/Repositories/alecscripts/Controllers"
    fn, _, controls = list(os.walk(fp))[0]
    d = {} 

    controls = sort_controllers(controls)
    for control in controls:
        d[replace_specials(control.split("Controller.cs")[0].title())] = pages(fn, control)
    
    return d


html = []

d = get_controls()
for controller, pages in d.items():
    c = f"<h2><button class=\"btn btn-dark\" >{controller}</button></h2>"
    html.append(c + pages)
html = "\n".join(html)


clipboard.copy(html)


