
import clipboard
from bs4 import BeautifulSoup as bs

layout = "/Users/111244rfsf/Documents/Repositories/alecscripts/Views/Shared/_Layout.cshtml"
with open(layout, "r") as f:
    html = f.read()
soup = bs(html, 'lxml')

clipboard.copy(soup.prettify())

