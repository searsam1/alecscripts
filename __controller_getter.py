
import clipboard  # copy()
import re  # findall()
import os  # walk
controller_label_g = ""


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
    string = f"""<li><a class="link-dark rounded" asp-action="{action}" asp-controller="{controller}">{controller_label} {action_label}</a></li>"""
    controller_label_g = controller_label
    return string

def html(controller, actions):
    controller = controller.split("Controller.cs")[0]
    print(controller)
    return f"""
                            <li class="mb-1">
                                <button class="btn btn-toggle align-items-center rounded collapsed"
                                    data-bs-toggle="collapse" data-bs-target="#{controller}-collapse" aria-expanded="false">
                                    {replace_specials(controller)}
                                </button>
                                <div class="collapse" id="{controller}-collapse">
                                    <ul class="btn-toggle-nav list-unstyled fw-normal pb-1 small">
                                        {actions}
                                    </ul>
                                </div>
                            </li>
"""


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


def get_controllers():
    fp = "/Users/111244rfsf/Documents/Repositories/alecscripts/Controllers"
    fn, _, controls = list(os.walk(fp))[0]

    controls = sorted(controls)
    actions = {}
    for controller in controls:
        new_action = get_actions(fn, controller)
        actions[controller] = new_action
    return actions


def create_links(controller, actions):
    actions = sorted(actions)
    links = [asp_link(controller.split("Controller.cs")[0], action) for action in actions]
    return links

def create_sidebar(controllers):
    sidebar = ""
    for controller, actions in controllers.items():
        links = "\n".join(create_links(controller, actions))
        sidebar += html(controller, links)
    return sidebar
        

controllers = get_controllers()

res = create_sidebar(controllers)
clipboard.copy(res)
