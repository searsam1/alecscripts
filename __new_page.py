from datetime import datetime as dt
import datetime
from gc import collect
import os
import __update_sidebar

def get_creation_date():
    tz = datetime.timezone(offset=datetime.timedelta(hours=-7), name="GMT-7")
    time_date = dt.now(tz)
    time_date = time_date.strftime("%c (%Z)")
    return time_date

def title_case(string):
    return "".join(map(lambda x: x.title(), string.split()))

def collect_page_name():
    try:
        name = input("New Page Name? : ").strip()
    except KeyboardInterrupt:
        os.system.exit()
    return name.strip()

def collect_controller_name():
    try:
        name = input("New Page Controller? : ").strip()
    except KeyboardInterrupt:
        os.system.exit()
    return name.strip()

def create_new_iaction(page_name):
    title = title_case(page_name)
    page_name = title_case(page_name).replace(" ", "")
    text = f"""public IActionResult {page_name}()
    {{
        ViewData["creationDate"] = "{get_creation_date()}";
        ViewData["controller"] = controllerName;
        ViewData["title"] = "{title}";
        return View();
    }}"""
    return text, page_name

def get_controller_file(controller_name):
    controller_filename = f"{controller_name}Controller.cs"
    controller_path = os.path.join("Controllers", controller_filename)
    with open(controller_path, "r") as f:
        file_contents = f.read()
    return file_contents, controller_path

def update_controller_file(controller_name, page_name):
    file_contents, controller_path = get_controller_file(controller_name)
    file_contents = file_contents.rstrip(" \t\n").rstrip("}").rstrip(" \t\n").rstrip("}")
    new_iaction, page_name = create_new_iaction(page_name)
    file_contents += new_iaction
    file_contents += "\n    }\n}"
    with open(controller_path, "w") as f:
        f.write(file_contents)
    print(f"Wrote to {controller_path}")
    os.chdir(os.path.join("Views", controller_name))
    os.system(f"touch {page_name}.cshtml")
    os.system(f"code {page_name}.cshtml")
    os.system(f"open -a Safari https://localhost:7290/{controller_name}/{page_name}")
    print(f"Created Views/{controller_name}/{page_name}.cshtml")

update_controller_file(collect_controller_name(), collect_page_name())
__update_sidebar.update_layout_with_sidebar()
