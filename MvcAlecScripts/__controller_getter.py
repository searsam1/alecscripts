
from turtle import title
import clipboard  # copy()
import re  # findall()
import os  # walk


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
    return string if string != "Index" else "/"


def asp_link(controller, action):
    string = f"""
    <br>
        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action={action} asp-controller={controller}>
            {title_split(action)}
        </a>
""".replace("\n", "")
    return string


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


def get_controls():
    fp = "Controllers"
    fn, _, controls = list(os.walk(fp))[0]
    string = ""

    controls = sorted(controls)
    for control in controls:
        string += (f'<details>')
        string += f"""
        <summary>
            {control.split("Controller.cs")[0].title()}
        </summary>
        """.replace("\n", "")
        string += "".join(asp_link(control.split("Controller.cs")
                            [0], action) 
                                for action in get_actions(fn, control))
        string += (f'</details>')
    string += "<br>"
    return string


res = get_controls()

clipboard.copy(res)
### Most Recent 
# <details>        <summary>            Challenge        </summary>            <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=AreaOfAHexagon asp-controller=Challenge>            Area Of Ahexagon        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=CensoredVowels asp-controller=Challenge>            Censored Vowels        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=DepthfirstSearch asp-controller=Challenge>            Depthfirst Search        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=GetOdds asp-controller=Challenge>            Get Odds        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Index asp-controller=Challenge>            Index        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=NumberLength asp-controller=Challenge>            Number Length        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=ReverseSortANumber asp-controller=Challenge>            Reverse Sort Anumber        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=SumOfCube asp-controller=Challenge>            Sum Of Cube        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=drinkSoda asp-controller=Challenge>            Drink Soda        </a></details><details>        <summary>            Cpp        </summary>            <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Index asp-controller=Cpp>            Index        </a></details><details>        <summary>            Dotnet        </summary>            <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Index asp-controller=Dotnet>            Index        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=randomNumber asp-controller=Dotnet>            Random Number        </a></details><details>        <summary>            Home        </summary>            <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Error asp-controller=Home>            Error        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Index asp-controller=Home>            Index        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Privacy asp-controller=Home>            Privacy        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=PythonHomePage asp-controller=Home>            Python Home Page        </a></details><details>        <summary>            Html        </summary>            <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Index asp-controller=Html>            Index        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Tags asp-controller=Html>            Tags        </a></details><details>        <summary>            Java        </summary>            <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Index asp-controller=Java>            Index        </a></details><details>        <summary>            Js        </summary>            <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=BinaryArraytoDecimal asp-controller=Js>            Binary Arrayto Decimal        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Expressions_and_operators asp-controller=Js>            Expressions_And_Operators        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Index asp-controller=Js>            Index        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Json asp-controller=Js>            Json        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=ToFixed asp-controller=Js>            To Fixed        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=jsGetMonth asp-controller=Js>            Js Get Month        </a></details><details>        <summary>            Networking        </summary>            <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Index asp-controller=Networking>            Index        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=IpDataGram asp-controller=Networking>            Ip Data Gram        </a></details><details>        <summary>            Python        </summary>            <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Index asp-controller=Python>            Index        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Password asp-controller=Python>            Password        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=abs asp-controller=Python>            Abs        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=cg asp-controller=Python>            Cg        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=controllerGetter asp-controller=Python>            Controller Getter        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=funnyNumbers asp-controller=Python>            Funny Numbers        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=stringFormattingTypes asp-controller=Python>            String Formatting Types        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=swapcase asp-controller=Python>            Swapcase        </a>    <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=vars asp-controller=Python>            Vars        </a></details><details>        <summary>            Financial        </summary>            <br>        <a style="text-decoration:none; font-size:14px; padding-right: 100%" class=link asp-action=Index asp-controller=financial>            Index        </a></details>
# Views/Shared/_Layout.cshtml