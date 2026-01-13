namespace Task3;

public class Player
{
    public string Name {get; set;}=string.Empty;
    public int Number {get; set;}
    public string Position {get; set;}=string.Empty;
    public string Team {get; set;}=string.Empty;

    public void ScoreGoal(string playename)
    {
        System.Console.WriteLine($"Player {playename} scores a goal.");
    }
    public void AssistGoal(string playername)
    {
        
        System.Console.WriteLine($"Player {Name} assist a goal for {playername}");
    }

    public string GetInfo()
    {
        return $"Name: {Name} - Number: {Number} - Position: {Position} - Team: {Team} ";
    }
}
