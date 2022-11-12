
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


def asp_link(controller, action):
    string = f"""
    
        <a class="sidebar-link" asp-action={action} asp-controller={controller}>
            {controller} {title_split(action)}
        </a>
        <br>
""".replace("\n", "")
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
    fp = "Controllers"
    fn, _, controls = list(os.walk(fp))[0]
    string = ""
    lst = []

    controls = sorted(controls)
    for control in controls:
        string += (f'<details>')
        string += f"""
        <summary>
            {control.split("Controller.cs")[0].title()}
        </summary>
        """.replace("\n", "")
        string += "".join(asp_link(control.split("Controller.cs")
                            [0], action) 
                                for action in get_actions(fn, control))
        string += (f'</details>')
        lst.append(string)
        string = ""
    lst = list(map(lambda x: " ".join(x),map(lambda x: x.split(), lst)))
    return " ".join(lst)


res = get_controls()
new_sidebar = res

# clipboard.copy(res)

