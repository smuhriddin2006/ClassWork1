using System.Runtime.InteropServices;
using Task3;

Player player1 = new Player();
System.Console.Write("Player Name: ");
player1.Name = System.Console.ReadLine();
System.Console.Write("Player Number: ");
player1.Number = int.Parse(System.Console.ReadLine());
System.Console.Write("Player Position: ");
player1.Position = System.Console.ReadLine();
System.Console.Write("Player Team: ");
player1.Team = System.Console.ReadLine();
System.Console.Write("Player who scores: ");
player1.ScoreGoal(System.Console.ReadLine());
System.Console.Write("Player who assist: ");
player1.AssistGoal(System.Console.ReadLine());
player1.GetInfo();
