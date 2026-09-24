using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");


int hp = 100;
int hp2 = 100;

Console.WriteLine("Fighting Sim Version 2000, Nya Galna Grafiker!!");


Console.WriteLine("Tryck på Enter för att starta");
Console.ReadLine();
Console.Clear();

string Player1 = "";
string Player2 = "";
Console.WriteLine("Vad heter Player 1?");
Player1 = Console.ReadLine();
Console.WriteLine("Player 1 Heter " + Player1);
Console.ReadLine();
Console.Clear();
Console.WriteLine("Vad heter Player 2?");
Player2 = Console.ReadLine();
Console.WriteLine("Player 2 heter " + Player2);
Console.ReadLine();
Console.Clear();
Console.WriteLine(Player1 + " VS " + Player2 + " | Vem vinner?");

int Sparkdamage = Random.Shared.Next(0, 20);
int Slådamage = Random.Shared.Next(3, 10);
int Sparkdamage2 = Random.Shared.Next(0, 20);
int Slådamage2 = Random.Shared.Next(3, 10);

while (hp > 0 && hp2 > 0)
{
    Console.WriteLine(Player1 + "s HP = " + hp);
    Console.WriteLine(Player2 + "s HP = " + hp2);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Vad vill " + Player1 + " Göra?");
    Console.WriteLine("Sparka eller Slå?");
    string Player1Hit = "";
    Player1Hit = Console.ReadLine();
    if (Player1Hit == "Sparka")
    {
        hp2 -= Sparkdamage;
    }
    else
    {
        hp2 -= Slådamage;
    }
    Console.WriteLine("Vad Vill " + Player2 + " Göra?");
    Console.WriteLine("Sparka eller Slå?");
    string Player2Hit = "";
    Player2Hit = Console.ReadLine();
    if (Player2Hit == "Sparka")
    {
        hp -= Sparkdamage2;
    }
    else
    {
        hp -= Slådamage2;
    }
    if (Player1Hit == "Sparka")
    {
        Console.WriteLine(Player2 + " Tog " + Sparkdamage);
    }
    else
    {
        Console.WriteLine(Player2 + " Tog " + Slådamage);
    }
    if (Player2Hit == "Sparka")
    {
        Console.WriteLine(Player1 + " Tog " + Sparkdamage2);
    }
    else
    {
        Console.WriteLine(Player1 + " Tog " + Slådamage2);
    }
    Console.ReadLine();
    Console.Clear();
}
Console.WriteLine("--- MATCHEN ÄR SLUT ---");
Console.WriteLine(Player1 + " HP: " + hp);
Console.WriteLine(Player2 + " HP: " + hp2);
Console.WriteLine();

if (hp <= 0 && hp2 <= 0)
{
    Console.WriteLine("Det blev OAVGJORT! Båda slogs ut samtidigt.");
}
else if (hp <= 0)
{
    Console.WriteLine(Player2 + " VAN MATCHEN!");
}
else
{
    Console.WriteLine(Player1 + " VAN MATCHEN!");
}

Console.ReadLine();
