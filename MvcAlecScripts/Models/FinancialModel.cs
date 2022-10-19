namespace MvcAlecScripts.Models;
public class FinancialModel{
    public string? Name { get; set; }

    public int func(string a){
        return   Int32.Parse(a) * 2;
    }
}