
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcAlecScripts.Models;
using System.Security.Cryptography;

namespace MvcMovie.Controllers
{
    public class ChallengeController : Controller
    {
        public string controllerName = "Challenge";
        // GET: /Python/

    public IActionResult Index()
    {   
        ViewData["controller"] = controllerName;
        ViewData["title"] ="Home";
    var viewModel = new ChallengeModel()
    {
        // Example Challenge
        Name = "Default Challenge",
        Author = "DefaultUser",
        Language = "Python",
        Description = "<Challenge Description>",
        Examples = @"
# Example Python Code
                    ",
        Notes = "Return [ ] if no evens are given.",
        ID = RandomNumberGenerator.GetInt32(20)

    };
        
        string sSourceData = viewModel.Name + 
                      viewModel.Author + 
                      viewModel.Language + 
                      viewModel.Description + 
                      viewModel.Examples + 
                      viewModel.Notes;

        // Create a byte array from source data.
        viewModel.Hash = viewModel.GetHash(sSourceData);
        return View(viewModel);
    }
      
    public IActionResult GetOdds()
    { 
        ViewData["controller"] = controllerName;
        var viewModel = new ChallengeModel()
            {
                // Example Challenge
                Name = "Get Odds",
                Author = "USER11881",
                Language = "Python",
                Description = "Return all odd numbers from a given array of integers.",
                Examples = @"
[1, 2, 3, 4] # [1,3]
[1658, 4221, 2929, 1046, 7862, 5006] # [4221, 2929]
                            ",
                Notes = "Return [ ] if no odds are given.",

            };
                string sSourceData = viewModel.Name + 
                            viewModel.Author + 
                            viewModel.Language + 
                            viewModel.Description + 
                            viewModel.Examples + 
                            viewModel.Notes;

                // Create a byte array from source data.
                viewModel.Hash = viewModel.GetHash(sSourceData);
                return View(viewModel);
    }

    public IActionResult drinkSoda()
    { 
        ViewData["controller"] = controllerName;
        var viewModel = new ChallengeModel()
            {
                // Example Challenge
                Name = "Drink Soda",
                Author = "USER11881",
                Language = "Python",
                Description = @"
                There are 355 mL in one can of soda. 

                Given The number of sodas one drinks per day, calculate 
                how many Liters how soda they consume per year.
                
                Return the value rounded to two decimal places and as a string with 'Liters' added to the end.
                ",
                Examples = @"

def soda(drinks):
    ...

soda(0) == '0.0 Liters'
soda(1) == '129.57 Liters'
soda(2) == '259.15 Liters'
soda(3) == '388.73 Liters'
soda(4) == '518.3 Liters'
soda(5) == '647.88 Liters'
soda(6) == '777.45 Liters'
soda(7) == '907.02 Liters'
soda(8) == '1036.6 Liters'
soda(9) == '1166.17 Liters'  
    
    ",
                Notes = "Assume they drink the same amount of soda everyday.",
                Tests = @"
assert soda(0) == '0.0 Liters'
assert soda(1) == '129.57 Liters'
assert soda(2) == '259.15 Liters'
assert soda(3) == '388.73 Liters'
assert soda(4) == '518.3 Liters'
assert soda(5) == '647.88 Liters'
assert soda(6) == '777.45 Liters'
assert soda(7) == '907.02 Liters'
assert soda(8) == '1036.6 Liters'
assert soda(9) == '1166.17 Liters'
assert soda(10) == '1295.75 Liters'
assert soda(11) == '1425.33 Liters'
assert soda(12) == '1554.9 Liters'
assert soda(13) == '1684.47 Liters'
assert soda(14) == '1814.05 Liters'
assert soda(15) == '1943.62 Liters'
assert soda(16) == '2073.2 Liters'
assert soda(17) == '2202.78 Liters'
assert soda(18) == '2332.35 Liters'
assert soda(19) == '2461.93 Liters'
assert soda(20) == '2591.5 Liters'
assert soda(21) == '2721.07 Liters'
assert soda(22) == '2850.65 Liters'
assert soda(23) == '2980.22 Liters'
assert soda(24) == '3109.8 Liters'
assert soda(25) == '3239.38 Liters'
assert soda(26) == '3368.95 Liters'
assert soda(27) == '3498.53 Liters'
assert soda(28) == '3628.1 Liters'
assert soda(29) == '3757.68 Liters'
assert soda(30) == '3887.25 Liters'
assert soda(31) == '4016.82 Liters'
assert soda(32) == '4146.4 Liters'
assert soda(33) == '4275.98 Liters'
assert soda(34) == '4405.55 Liters'
assert soda(35) == '4535.12 Liters'
assert soda(36) == '4664.7 Liters'
assert soda(37) == '4794.27 Liters'
assert soda(38) == '4923.85 Liters'
assert soda(39) == '5053.43 Liters'
assert soda(40) == '5183.0 Liters'
assert soda(41) == '5312.57 Liters'
assert soda(42) == '5442.15 Liters'
assert soda(43) == '5571.73 Liters'
assert soda(44) == '5701.3 Liters'
assert soda(45) == '5830.88 Liters'
assert soda(46) == '5960.45 Liters'
assert soda(47) == '6090.02 Liters'
assert soda(48) == '6219.6 Liters'
assert soda(49) == '6349.18 Liters'
assert soda(50) == '6478.75 Liters'
assert soda(51) == '6608.32 Liters'
assert soda(52) == '6737.9 Liters'
assert soda(53) == '6867.48 Liters'
assert soda(54) == '6997.05 Liters'
assert soda(55) == '7126.62 Liters'
assert soda(56) == '7256.2 Liters'
assert soda(57) == '7385.77 Liters'
assert soda(58) == '7515.35 Liters'
assert soda(59) == '7644.93 Liters'
assert soda(60) == '7774.5 Liters'
assert soda(61) == '7904.07 Liters'
assert soda(62) == '8033.65 Liters'
assert soda(63) == '8163.23 Liters'
assert soda(64) == '8292.8 Liters'
assert soda(65) == '8422.38 Liters'
assert soda(66) == '8551.95 Liters'
assert soda(67) == '8681.52 Liters'
assert soda(68) == '8811.1 Liters'
assert soda(69) == '8940.67 Liters'
assert soda(70) == '9070.25 Liters'
assert soda(71) == '9199.83 Liters'
assert soda(72) == '9329.4 Liters'
assert soda(73) == '9458.98 Liters'
assert soda(74) == '9588.55 Liters'
assert soda(75) == '9718.12 Liters'
assert soda(76) == '9847.7 Liters'
assert soda(77) == '9977.27 Liters'
assert soda(78) == '10106.85 Liters'
assert soda(79) == '10236.42 Liters'
assert soda(80) == '10366.0 Liters'
assert soda(81) == '10495.58 Liters'
assert soda(82) == '10625.15 Liters'
assert soda(83) == '10754.73 Liters'
assert soda(84) == '10884.3 Liters'
assert soda(85) == '11013.88 Liters'
assert soda(86) == '11143.45 Liters'
assert soda(87) == '11273.02 Liters'
assert soda(88) == '11402.6 Liters'
assert soda(89) == '11532.17 Liters'
assert soda(90) == '11661.75 Liters'
assert soda(91) == '11791.33 Liters'
assert soda(92) == '11920.9 Liters'
assert soda(93) == '12050.48 Liters'
assert soda(94) == '12180.05 Liters'
assert soda(95) == '12309.62 Liters'
assert soda(96) == '12439.2 Liters'
assert soda(97) == '12568.77 Liters'
assert soda(98) == '12698.35 Liters'
assert soda(99) == '12827.92 Liters'"

                

            };
                string sSourceData = viewModel.Name + viewModel.Author + viewModel.Language + viewModel.Description + viewModel.Examples + viewModel.Notes;
                // Create a byte array from source data.
                viewModel.Hash = viewModel.GetHash(sSourceData);
                return View(viewModel);
    }

    public IActionResult CensoredVowels() {
        
        ViewData["controller"] = controllerName;
        var viewModel = new ChallengeModel()
    {
        // Example Challenge
        Name = "Censored Vowels", 
        Author = "Alec Sears",
        Language = "csharp",
        Description = "Given a string with censored vowels (aeiou) and a string of those vowels, uncensor the string.",
        Examples = @"
        
uncensor(""Wh*r* d*d my v*w*ls g*?"", ""eeioeo"") ➞ ""Where did my vowels go?""

uncensor(""abcd"", """") ➞ ""abcd""

uncensor(""*PP*RC*S*"", ""UEAE"") ➞ ""UPPERCASE""        
        
        ",
        Notes = "",
    };
        return View(viewModel);
    }

    public IActionResult AreaOfAHexagon() {
        
        ViewData["controller"] = controllerName;
        ViewData["title"] ="Area Of Ahexagon";
        var viewModel = new ChallengeModel()
    {
        // Example Challenge
        Name = "Area of a Hexagon", 
        Author = "Alec Sears",
        Language = "JS",
        Description = "Given the side length of a regular hexagon, return the area of that hexagon rounded to one decimal place.",
        Examples = @"
areaOfHexagon(15) → 584.6
areaOfHexagon(30) → 2338.3
areaOfHexagon(45) → 5261.1
areaOfHexagon(60) → 9353.1
areaOfHexagon(75) → 14614.2
areaOfHexagon(90) → 21044.4

const areaOfHexagon = (s) => s > 0 ? 
	+(3 * 3**.5 * s*s / 2).toFixed(1):
	null;

",
        Notes = " area(s) = (3√3 * s²) / 2",
    };
        return View(viewModel);
    }


public IActionResult NumberLength() {
        
        ViewData["controller"] = controllerName;
        var viewModel = new ChallengeModel()
    {
        // Example Challenge
        Name = "Number Length", 
        Author = "Alec Sears",
        Language = "JS",
        Description = "Return the length of a given number, or how many digits it has.",
        Examples = @"
findDigitAmount(15) → 2
findDigitAmount(155) → 3
findDigitAmount(1556) → 4
findDigitAmount(15567) → 5

function findDigitAmount(num) {
	return num.toString().length;
}

",
        Notes = "Input will always be an integer.",
    };
        return View(viewModel);
    }

    public IActionResult DepthFirstSearch() {
        
        ViewData["controller"] = controllerName;
        ViewData["title"] ="Depth First Search";
        var viewModel = new ChallengeModel()
    {
        // Example Challenge
        Name = "Depth-first Search", 
        Author = "Alec Sears",
        Language = "Python",
        Description = "Return if a given number is in the tree. Use the Depth-first search method where each nested list is new level of the tree.",
        Examples = @"
tree = [ 1, [2, [4, [8, [12, 13] ,9], 5, [10, 11]]], [3, [6,7]] ]

flatten(tree, 14)
# []

flatten(tree, 11)
# [True]

flatten(tree, 13)
# [True]

# Solution
def flatten(tree, target):
    res = [] 
    for i in tree:
        if isinstance(i, list):
            if target in i: return [True]
            res += flatten(i, target)
    return res
",
        Notes = "The tree will only contain other nodes and ints.",
    };
        return View(viewModel);
    }

    public IActionResult ReverseSortANumber() {
        
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Reverse Sort Anumber";
        var viewModel = new ChallengeModel()
    {
        // Example Challenge
        Name = "Reverse Sort a Number", 
        Author = "Alec Sears",
        Language = "JS",
        Description = "Take a number in string or int form and reverse sort by its digits.",
        Examples = @"
rotateMaxNumber(123) ➞ 321

rotateMaxNumber(""003"") ➞ 300

rotateMaxNumber(989) ➞ 998

function rotateMaxNumber(num) {
    // vvv Not mine vvv
    let myFunc = num => Number(num);	
  	var intArr = Array.from(String(num), myFunc);
    // ^^^ Not mine ^^^
    
    // sort, reverse, join
	return parseInt(intArr.sort().reverse().join(""""));
}

",
        Notes = "Got the function from GeeksForGeeks and the challenge from edabit.com (https://edabit.com/challenge/NJQ64N6xhrppEMkjY)",
    };
        return View(viewModel);
    }

    public IActionResult SumOfCube() {
        
        ViewData["controller"] = controllerName;
        ViewData["title"] = "Sum Of Cube";
        var viewModel = new ChallengeModel()
    {
        // Example Challenge
        Name = "Sum of Cube", 
        Author = "Alec Sears",
        Language = "JS",
        Description = "Return the sum of 1^3 to n^3.",
        Examples = @"
sumCubes(1) -> 1
sumCubes(2) -> 9
sumCubes(123) -> 58155876
sumCubes(7) -> 784
sumCubes(9) -> 2025

function sumCubes(n) {
	let sum_ = 0;
  	while (n > 0){sum_ += n**3; n--;}
  	return sum_;
}
",
        Notes = "None",
    };
        return View(viewModel);
    }

    
    }
}
