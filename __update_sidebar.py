import os
import platform
import __controller_getter

# Define the file path based on the current operating system
if platform.system() == 'Windows':
    fp = os.path.join(os.path.expanduser("~"), 'OneDrive', 'Documents', 'Repositories', 'alecscripts', 'Views', 'Shared', '_Layout.cshtml')
elif platform.system() == 'Darwin':
    fp = os.path.join(os.path.expanduser("~"), 'Documents', 'Repositories', 'alecscripts', 'Views', 'Shared', '_Layout.cshtml')
else:
    print('Unknown OS')
    fp = '/'


def get_sidebar_loc(text):
    start = end = None
    for idx, line in enumerate(text):
        if "@* Sidebar *@" in line:
            start = idx + 1
        if "@* /End Sidebar *@" in line:
            end = idx
            break
    return start, end

def get_new_layout(path=fp):
    # Generate the new sidebar based on the available controllers
    controllers = __controller_getter.get_controllers()
    sidebar = __controller_getter.create_sidebar(controllers)

    # Get the contents of the current file and locate the position of the sidebar
    text = get_file_text()
    start, end = get_sidebar_loc(text)

    # Replace the old sidebar with the new one
    text = text[:start] + [sidebar] + text[end:]
    text = list(map(lambda x: x.rstrip(), text))
    text = [i for i in text if i]
    text = "\n".join(text)

    return text

def update_layout_with_sidebar():
    # Update the file with the new sidebar
    new_layout = get_new_layout()
    with open(fp, "w") as f:
        f.write(new_layout)
        print("\nNew Sidebar Added.")

# Print the contents of the file for testing purposes
with open(fp, 'r') as f:
    print(f.read())
