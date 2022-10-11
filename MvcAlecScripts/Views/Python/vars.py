
# example 2

def foo():
    """
    Outputs:
    
    {
        'bar': 'foobar', 
        'key': 'value'
    }
    """
    bar = [1,2,3]
    key = "value"
    return vars()
print(foo())