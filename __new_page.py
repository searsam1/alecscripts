
import time 
import os
import __update_sidebar

def title_split(string):
    return "".join(map(lambda x: x.title(), string.split())) 

def create_new_publicIAction(new_page=None):
    if not new_page:
        new_page = input("New Page Name? : ").strip()
    title = new_page.title()
    new_page = title_split(new_page)
    text = """public IActionResult {0}()
    {1}   
        ViewData["controller"] = controllerName;
        ViewData["title"] = "{3}";
        return View();
    {2}
    """.format(new_page, "{", "}", title)
    return text, new_page

create_new_publicIAction("loops")


def get_controller_name(controller=None):
    if not controller:
        controller = input("Controller Name? : ").title().strip()
    controller = title_split(controller)
    controller_name = controller
    controller += "Controller"
    fp = "Controllers/{0}".format(controller) + ".cs"    
    with open(fp, "r") as f:
        file_ = f.read()
    return file_, fp, controller_name
    
def change_controller_file(controller_name=None, page_name=None):
    
    f, controller_fp, controller_name = get_controller_name(controller_name)
    res = f.rstrip(" \t\n").rstrip("}").rstrip(" \t\n").rstrip("}")
    new_iAction, page_name = create_new_publicIAction(page_name)
    res += new_iAction
    res += "\n    }\n}"
    
    with open(controller_fp, "w") as f:
        f.write(res)
    print("Wrote to {}".format( controller_fp))
    
    def make_new_file():
        os.chdir("Views/{}".format(controller_name))
        os.system("touch {}.cshtml".format(page_name))
        os.system("code {}.cshtml".format(page_name))
        
        print("waiting for page to update...")
        time.sleep(5)
        os.system("open -a Safari https://localhost:7290/{}/{}".format(controller_name, page_name))
        
        print("Created Views/{}/{}.cshtml".format(controller_name,page_name))

    make_new_file()    

change_controller_file()
__update_sidebar.update_file()