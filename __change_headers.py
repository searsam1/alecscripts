
import clipboard
import re
views_path = "/Users/111244rfsf/Documents/Repositories/alecscripts/Views/Bash/index.cshtml"

"""
Change h2 -> h3
Change h1 -> h2 
"""



with open(views_path, "r") as f:
    test_file = f.read()


res = test_file.replace("h2", "h3")
res = res.replace("h1", "h2")
clipboard.copy(res)
print(res)