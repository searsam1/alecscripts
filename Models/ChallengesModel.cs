namespace MvcAlecScripts.Models;

public class ChallengesModel
{
    public string? Id { get; set; }
    
    // Instructions
    public string? InstructionsTitle { get; set; }
    public string? Subheader { get; set; }
    public string? Tags { get; set; }
    public string? InstructionsInstructions { get; set; }
    public string? InstructionsExamples { get; set; }
    public string? InstructionsNotes { get; set; }

    public string? HelpLinks { get; set; }
    
}