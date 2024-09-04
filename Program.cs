// See https://aka.ms/new-console-template for more information
using System.Dynamic;

Console.Clear();
Console.WriteLine("Hello, World!");
Console.BackgroundColor = ConsoleColor.Blue;
//First row of color
for(int i = 0; i < 14; i++)
{
    Console.SetCursorPosition(i+4,0);
    Console.Write("        ");
}
//Second row of color
for(int i = 0; i < 14; i++)
{
    if(i < 4 || i > 8)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(i + 4 , 1);
        Console.Write("        ");
    }
    if(i >= 4 && i <= 8)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(i + 4, 1);
        Console.Write("        ");
    }
}
//Third row of color
for(int i = 0; i < 14; i++)
{
    if(i < 3 || i > 11)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(i+4, 2);
        Console.Write("        ");
    }
    if(i >= 3 && i <= 11)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(i+4, 2);
        Console.Write("        ");
    }
}
//Fourth row of color
for(int i = 0; i < 3; i++)
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.SetCursorPosition(i+4, 3);
    Console.Write("        ");
}
for(int i = 3; i < 6; i++)
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.SetCursorPosition(i+4, 3);
    Console.Write("        ");
}
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(10, 3);
Console.Write("        ");
Console.SetCursorPosition(11, 3);
Console.Write("        ");
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(12, 3);
Console.Write("        ");
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(13, 3);
Console.Write("        ");
for(int i = 10; i < 14; i++)
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.SetCursorPosition(i+4, 3);
    Console.Write("        ");
}
//Fifth Row of color
Console.SetCursorPosition(0, 4);
Console.Write("        ");
Console.SetCursorPosition(4, 4);
Console.Write("        ");
Console.BackgroundColor = ConsoleColor.Black;
Console.SetCursorPosition(7,4);
Console.Write("        ");
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(8,4);
Console.Write("        ");
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(9,4);
Console.Write("        ");
for(int i = 0; i < 3; i++)
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(10 + i,4);
    Console.Write("        ");
}
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(12,4);
Console.Write("        ");
for(int i = 0; i < 3; i++)
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(13 + i,4);
    Console.Write("        ");
}
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(16,4);
Console.Write("        ");
//6th row of color
Console.SetCursorPosition(0,5);
Console.Write("        ");
Console.SetCursorPosition(1,5);
Console.Write("        ");
