# MAS

class Item:
    def __init__(self, name="grocery item", price=1) -> None:
        self.name = name
        self.price = price

        if isinstance(price, int) or isinstance(price, float):
            self.price = price
        else: self.price = 0

        if isinstance(name, str): self.name = name
        else: self.name = ""



class ShoppingList:
    def __init__(self) -> None:
        self.bag = {}

    def add_item(self, item: Item):
        self.bag[item.name] = item.price

    def clear(self):
        self.bag = {}

    def sum_(self):
        return sum(self.bag.values())
    
    def __repr__(self) -> str:
        return "\n".join(str(self.bag).split(", "))

lst = ShoppingList()
lst.add_item(Item(input("Add Item name: "), float(input("Price: "))))
fp = "/Users/111244rfsf/Documents/Repositories/alecscripts/MvcAlecScripts/Views/Shared/shopping_list.py"
with open(fp, "a") as f:
    f.write("\n")
    f.write(str(lst.bag))
print(lst)

{'t': 1.0}