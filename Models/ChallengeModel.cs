using System;
using System.Security.Cryptography;
using System.Text;
namespace MvcAlecScripts.Models;

public class ChallengeModel
{   
    public string? Name { get; set; }
    public string? Author { get; set; }
    public string? Language { get; set; }
    public string? Description { get; set; }
    public string? Examples { get; set; }
    public string? Notes { get; set; }
    public string? Hash { get; set; }
    public string? Tests {get; set;}
    public int? ID {get; set;}

    

    public SHA256 challengeSHA256 = SHA256.Create();

    public string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i=0;i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }
    
    public string GetHash(string source){
        byte[] sSourceData = ASCIIEncoding.ASCII.GetBytes(source);
        // Compute hash based on source data.
        byte[] tmpHash = challengeSHA256.ComputeHash(sSourceData);
        string Hash = ByteArrayToString(tmpHash);
        return Hash;
    }
     


   
}
