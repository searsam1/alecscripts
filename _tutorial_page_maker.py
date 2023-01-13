
# program to make tutorial page for me 
# in html table format 

import clipboard
import re 
import os 


def create_row(link):
    res = f"""  <tr>
      <td> {link} </td>
  </tr>"""
    return res

def create_header(controller):
    link = f"""  <tr style="top: 40px;" class="sticky-top text-center table-light">
    <td>
      <a class="link-dark text-decoration-none" asp-controller="{controller}" asp-action="Index">
        {controller}
      </a>
  </tr>"""
    return link

def create_link(controller, action):
    link = f"""<a class="link-light text-decoration-none" asp-controller="{controller}" asp-action="{action}"> {action}  </a>"""
    return link

def get_all_controller_files():
    walked = os.walk("/Users/111244rfsf/Documents/Repositories/alecscripts/Controllers")
    file_path, _, controller_files = list(walked)[0]
    return [file_path, controller_files]

def scrap_controllers():
    
    def getPublicIAction(txt):
        pattern = r"public IActionResult (\w+)"
        m = re.findall(pattern, txt)
        return m
    
    langs = {} 
    file_path, controller_files = get_all_controller_files()
    for controller_file in controller_files:
        controller_file_path = f"{file_path}/{controller_file}"
        with open(controller_file_path, "r") as f:
            publicIAction = getPublicIAction(f.read())
            lang = controller_file.split("Controller.cs")[0]
            langs[lang] = publicIAction
    return langs
            
langs = scrap_controllers()
table_body = [] 

for controller, actions in langs.items():
    links = [create_link(controller, action) for action in actions]
    table_body.append(create_header(controller))
    for link in links:
        new_row = create_row(link)
        table_body.append(new_row)

def create_table(table_body=table_body):
    table_body = "\n".join(table_body)
    res = f"""<table class=" table table-hover table-striped table-dark">
    {table_body}
</table>
    """
    clipboard.copy(res)

create_table()
