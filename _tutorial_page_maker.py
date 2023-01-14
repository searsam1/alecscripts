
# program to make tutorial page for me 
# in html table format 

from clipboard import copy
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
    table = f"""<table class=" table table-hover table-striped table-dark">
    {table_body}
</table>
    """
    return table

def write_to_tutorial_file():
    file_path = "/Users/111244rfsf/Documents/Repositories/alecscripts/Views/Home/Tutorials.cshtml"
    with open(file_path, "r") as f:
        tutorial_page = f.readlines()
    for idx, line in enumerate(tutorial_page):
        if "@* a09ba98393d12f113dd9dc8a450223abb7f17608fb65ad8866eda2108df61f67 *@" in line:
            tutorial_page = tutorial_page[:idx + 1]
            break 
    tutorial_page = "".join(tutorial_page)    
    table = create_table()
    tutorial_page += table

    with open(file_path, "w") as f:
        f.write(tutorial_page)

#==============================================================================#
# def main():
#     write_to_tutorial_file()

# if __name__ == "__main__":
#     main()
#==============================================================================#

js_constants = ["Math.E        // Euler's number", 'Math.PI       // pi ', 'Math.SQRT2    // square root of 2', 'Math.SQRT1_2  // square root of 1/2', 'Math.LN2      // natural log of 2', 'Math.LN10     // natural log of 10', 'Math.LOG2E    // base 2 log of E', 'Math.LOG10E   // base 10 log of E', "Math.E        // Euler's number", 'Math.PI       // pi ', 'Math.SQRT2    // square root of 2', 'Math.SQRT1_2  // square root of 1/2', 'Math.LN2      // natural log of 2', 'Math.LN10     // natural log of 10', 'Math.LOG2E    // base 2 log of E', 'Math.LOG10E   // base 10 log of E']

# Math.PI       // pi 
# Math.SQRT2    // square root of 2
# Math.SQRT1_2  // square root of 1/2
# Math.LN2      // natural log of 2
# Math.LN10     // natural log of 10
# Math.LOG2E    // base 2 log of E
# Math.LOG10E   // base 10 log of E


#==============================================================================#









