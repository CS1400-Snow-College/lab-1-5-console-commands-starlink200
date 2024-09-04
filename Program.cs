// See https://aka.ms/new-console-template for more information
using System.Dynamic;

Console.Clear();
Console.WriteLine("Hello, World!");
Console.BackgroundColor = ConsoleColor.Blue;
//First row of color
for(int i = 0; i < 14; i++)
{
    Console.SetCursorPosition(i,0);
    Console.Write("        ");
}
//Second row of color
for(int i = 0; i < 14; i++)
{
    if(i < 4 || i > 8)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(i, 1);
        Console.Write("        ");
    }
    if(i >= 4 && i <= 8)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(i, 1);
        Console.Write("        ");
    }
}
//Third row of color
for(int i = 0; i < 14; i++)
{
    if(i < 3 || i > 11)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(i, 2);
        Console.Write("        ");
    }
    if(i >= 3 && i <= 11)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(i, 2);
        Console.Write("        ");
    }
}