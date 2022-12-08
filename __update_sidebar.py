
import re 
from bs4 import BeautifulSoup
import clipboard
import __controller_getter

fp = r"""/Users/111244rfsf/Documents/Repositories/alecscripts/Views/Shared/_Layout.cshtml"""


def get_file_text(path=fp):
    file_text = ""
    with open(path, 'r') as f:
        file_text = f.readlines()
    return file_text

def get_new_layout(path=fp):
    controllers = __controller_getter.get_controllers()
    sidebar = __controller_getter.create_sidebar(controllers)
    
    text = list( map(lambda x : x.strip(), get_file_text()) )
    start = text.index("@* Sidebar *@") + 1 
    end = text.index("@* /End Sidebar *@")
    
    text = text[:start] + [sidebar] + text[end:]
    return "\n".join(text)
    
def update_layout_with_sidebar():
    new_layout = get_new_layout()
    with open(fp, "w") as f:
        f.write(new_layout)
        print("\nNew Sidebar Added.")


