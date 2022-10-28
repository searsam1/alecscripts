
from turtle import title
import clipboard  # copy()
import re  # findall()
import os  # walk


def title_split(s):
    """
    Split a string into different words
    by title case, like: 
    
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
    return (s[0] + res).title()


def asp_link(controller, action):
    string = f"""
    <br>
        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action={action} asp-controller={controller}>
            {title_split(action)}
        </a>
"""
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
    actions = sorted(actions)
    return actions


def get_controls():
    fp = "Controllers"
    fn, _, controls = list(os.walk(fp))[0]
    string = ""

    controls = sorted(controls)
    for control in controls:
        string += (f'<details>')
        string += f"""
        <summary>
            {control.split("Controller.cs")[0].title()}
        </summary>
        """
        # for action in actions:
        #     asp = asp_link(control.split("Controller.cs")[0], action)
        #     string += asp
        #     print(action)
        string += "\n".join(asp_link(control.split("Controller.cs")
                            [0], action) for action in get_actions(fn, control))
        string += (f'</details>\n')
    return string


res = get_controls()

clipboard.copy(res)
