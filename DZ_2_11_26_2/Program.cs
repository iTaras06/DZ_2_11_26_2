using System;
using System.Collections.Generic;

namespace DZ_2_11_26_2;
public class Player
{
    public string Name;
    public int Number;
    public string Position;
    public Player(string name, int number, string position)
    {
        Name = name;
        Number = number;
        Position = position;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"#{Number}\t{Name}, Position: {Position}");
    }
}
public class FootballTeam
{
    public string TeamName;
    private List<Player> players = new List<Player>();
    public FootballTeam(string teamName)
    {
        TeamName = teamName;
    }
    public void Add(Player player)
    {
        players.Add(player);
        Console.WriteLine($"Added: {player.Name}");
    }
    public void ShowAll()
    {
        Console.WriteLine($"\t\"{TeamName}\" players:");
        if (players.Count == 0)
        {
            Console.WriteLine("The team has no players");
            return;
        }
        for (int i = 0; i < players.Count; i++)
        {
            Console.Write($"{i + 1}) ");
            players[i].ShowInfo();
        }
        Console.WriteLine($"Total: {players.Count}");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        FootballTeam team = new FootballTeam("Chornomorets Odesa");
        team.ShowAll();
        team.Add(new Player("Maksym Koval", 35, "Forward"));
        team.Add(new Player("Mahomed Kratov", 4, "Goalkeeper"));
        team.Add(new Player("Vasyl Kurko", 5, "Forward"));
        team.Add(new Player("Serhiy Korniychuk", 22, "Defender"));
        team.Add(new Player("Dmytro Klyots", 8, "Defender"));
        team.Add(new Player("Oleksandr Pshenychnyuk", 33, "Midfielder"));
        team.ShowAll();
    }
}