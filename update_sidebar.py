
from __controller_getter import get_controls
import re 
import clipboard

def get_file_text(path=r"""/Users/111244rfsf/Documents/Repositories/alecscripts/Views/Shared/_Layout.cshtml"""):
    file_text = ""
    with open(path, 'r') as f:
        file_text = f.read()
    return file_text

p = r"(@\* Sidebar \*@)(.*)(@\* /Sidebar \*@)"

def text_repl(matchgroup):
    return f"""
    @* Sidebar *@ 
        <div class="sidebar pt-3 fixed-top" >
            {get_controls()} 
        </div>
    @* /Sidebar *@ """



updated_file = re.sub(p, text_repl, get_file_text(), flags=re.DOTALL)
clipboard.copy(updated_file)
print("Copied updated html")

def update_file(path=r"""/Users/111244rfsf/Documents/Repositories/alecscripts/Views/Shared/_Layout.cshtml"""):
    with open(path, 'w') as f:
        f.write(updated_file)
    print("updated _layout with fresh sidebar.")
update_file()