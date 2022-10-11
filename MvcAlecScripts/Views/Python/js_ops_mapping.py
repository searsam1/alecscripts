import clipboard


ops = """Operator	Description	Examples returning true
Equal (==)	Returns true if the operands are equal.	3 == var1
"3" == var1

3 == '3'
Not equal (!=)	Returns true if the operands are not equal.	var1 != 4
var2 != "3"
Strict equal (===)	Returns true if the operands are equal and of the same type. See also Object.is and sameness in JS.	3 === var1
Strict not equal (!==)	Returns true if the operands are of the same type but not equal, or are of different type.	var1 !== "3"
3 !== '3'
Greater than (>)	Returns true if the left operand is greater than the right operand.	var2 > var1
"12" > 2
Greater than or equal (>=)	Returns true if the left operand is greater than or equal to the right operand.	var2 >= var1
var1 >= 3
Less than (<)	Returns true if the left operand is less than the right operand.	var1 < var2
"2" < 12
Less than or equal (<=)	Returns true if the left operand is less than or equal to the right operand.	var1 <= var2
var2 <= 5""".split("\n")

def output_td(s):
    if s.replace(" ", "").strip("\t").isalpha():
        return f"     <td> {s} </td>"    
    return f"     <td><code> {s} </code></td>"

ops = list(map(lambda x: x.replace("f()", "1"), ops))
ops = [ ["<tr>"] +  list( map( output_td, op.split("\t") ) ) + ["</tr>"] for op in ops]
ops = list( map(lambda x: "\n".join(x), ops) )

ops = "\n\n".join(ops)
clipboard.copy(ops)



