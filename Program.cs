// See https://aka.ms/new-console-template for more information
using System.Dynamic;

Console.Clear();
Console.WriteLine("Hello, World!");
Console.BackgroundColor = ConsoleColor.Blue;
/********************************
* First row of color            *
*                               *
********************************/
Console.SetCursorPosition(0,0);
Console.Write("          ");
for(int i = 1; i < 14; i++)
{
    Console.SetCursorPosition(i*10,0);
    Console.Write("            ");
}
/********************************
* Second row of color            *
*                               *
********************************/
Console.SetCursorPosition(0,1);
Console.Write("          ");
for(int i = 1; i < 14; i++)
{
    //This if statement will print the blue before and after the mario figure
    if(i < 4 || i > 8)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(i*10 , 1);
        Console.Write("          ");
    }
    //This if statement prints the top part of marios hat
    if(i >= 4 && i <= 8)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(i*10, 1);
        Console.Write("          ");
    }
}
/********************************
* Third row of color            *
*                               *
********************************/
Console.SetCursorPosition(0,3);
Console.Write("          ");
for(int i = 1; i < 14; i++)
{
    //this if statement prints the blue before and after mario
    if(i < 3 || i > 11)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(i*10, 2);
        Console.Write("          ");
    }
    //this if statement will make the bottom part of marios hat
    if(i >= 3 && i <= 11)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(i*10, 2);
        Console.Write("          ");
    }
}
/********************************
* Fourth row of color           *
*                               *
********************************/
for(int i = 0; i < 3; i++)
{
    //prints 3 blue sqaures
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.SetCursorPosition(i*10, 3);
    Console.Write("          ");
}
//prints 3 black blocks, marios hair
for(int i = 3; i < 6; i++)
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.SetCursorPosition(i*10, 3);
    Console.Write("          ");
}
//prints 2 squares of marios skin
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(60, 3);
Console.Write("          ");
Console.SetCursorPosition(70, 3);
Console.Write("          ");
//prints 1 sqaure of black, marios eye
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(80, 3);
Console.Write("          ");
//prints 1 square of yellow, marios skin
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(90, 3);
Console.Write("          ");
//prints 4 squares of blue after mario
for(int i = 10; i < 14; i++)
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.SetCursorPosition(i*10, 3);
    Console.Write("            ");
}
/********************************
* Fifth row of color            *
*                               *
********************************/
//Prints 2 sqaures of blue before mario
Console.SetCursorPosition(0, 4);
Console.Write("          ");
Console.SetCursorPosition(10, 4);
Console.Write("          ");
//Prints 1 square of black, marios hair
Console.BackgroundColor = ConsoleColor.Black;
Console.SetCursorPosition(20,4);
Console.Write("          ");
//Prints 1 sqaure of yellow, marios ear
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(30,4);
Console.Write("          ");
//Prints 1 sqaure of black, marios hair
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(40,4);
Console.Write("          ");
//prints 3 squares of yellow, marios skin
/*must start at the value of 5 so that when multiplied it
is equivalent to 50 continueing the block pattern */
for(int i = 5; i < 8; i++)
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(10*i,4);
    Console.Write("          ");
}
//Prints 1 sqaure of black, marios eye
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(80,4);
Console.Write("          ");
//prints 3 squares of yellow, part of marios nose
/*i must have an initial value of 9 so that when
it is multiplied by 10 it continues the patter
of sqaures being 10 spaces apart*/
for(int i = 9; i < 12; i++)
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(10*i,4);
    Console.Write("          ");
}
//Prints block of blue after mario
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(120,4);
Console.Write("          ");
Console.SetCursorPosition(130,4);
Console.Write("          ");
/********************************
* Sixth row of color            *
*                               *
********************************/
//Print 2 squares of blue before mario
Console.SetCursorPosition(0,5);
Console.Write("          ");
Console.SetCursorPosition(10,5);
Console.Write("          ");
//Print 1 black square, marios hair
Console.BackgroundColor = ConsoleColor.Black;
Console.SetCursorPosition(20,5);
Console.Write("          ");
//Print 1 yellow square, marios ear
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(30,5);
Console.Write("          ");
//Print 2 black squares, marios hair
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(40,5);
Console.Write("          ");
Console.SetCursorPosition(50,5);
Console.Write("          ");
//Print 3 yellow squares, marios face
/*initial value of i will be 6 so that
a pattern can be maintained*/
for(int i = 6; i < 9; i++)
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(10*i,5);
    Console.Write("          ");
}
//Print 1 black square, start of marios mustache
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(90,5);
Console.Write("          ");
//Print 3 yellow squares, bottom of nose
/*i must have an initial value of 10 so that when
it is multiplied by 10 it continues the patter
of sqaures being 10 spaces apart*/
for(int i = 10; i < 13; i++)
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(10*i,5);
    Console.Write("          ");
}
//Print 1 blue square after marios face
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(130,5);
Console.Write("           ");
/********************************
* Seventh row of color          *
*                               *
********************************/
//Print 2 blue squares
Console.SetCursorPosition(0,6);
Console.Write("          ");
Console.SetCursorPosition(10,6);
Console.Write("          ");
//Print 2 black squares
Console.BackgroundColor = ConsoleColor.Black;
Console.SetCursorPosition(20,6);
Console.Write("          ");
Console.SetCursorPosition(30,6);
Console.Write("          ");
//Print 4 yellow squares, marios face
/*To continue the pattern of every 10,
i will have the initial value of 4*/
for(int i = 4; i < 8; i++)
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(10*i,6);
    Console.Write("          ");
}
//Print 4 black squares, marios mustaches
/*To continue the pattern of every 10,
i will have the initial value of 8*/
for(int i = 8; i < 12; i++)
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.SetCursorPosition(i*10,6);
    Console.Write("          ");
}
//Print 2 blue squares
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(120,6);
Console.Write("          ");
Console.SetCursorPosition(130,6);
Console.Write("          ");
/********************************
* Eigth row of color            *
*                               *
********************************/
//Print 4 blue Squares
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,7);
Console.Write("          ");
for(int i = 1; i < 4; i++)
{
    Console.SetCursorPosition(10*i, 7);
    Console.Write("          ");
}
//print 7 yellow squares, bottom of marios face
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.White;
/*To keep the pattern of each row being 10
spaces long, i will be initialized at 4*/
for(int i = 4; i < 11; i++)
{
    Console.SetCursorPosition(10*i, 7);
    Console.Write("          ");
}
//Print 3 blue squares
Console.BackgroundColor = ConsoleColor.Blue;
for(int i = 11; i < 14; i++)
{
    Console.SetCursorPosition(10*i, 7);
    Console.Write("          ");
}
/********************************
* Ninth row of color            *
*                               *
********************************/
//Print 3 blue squares before mario
Console.BackgroundColor = ConsoleColor.Blue;
for(int i = 0; i < 3; i++)
{
    Console.SetCursorPosition(10*i,8);
    Console.Write("          ");
}
//Print 2 dark blue squares marios shirt
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(30,8);
Console.Write("          ");
Console.SetCursorPosition(40,8);
Console.Write("          ");
//Print 1 red square, marios overalls
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(50,8);
Console.Write("          ");
//print 3 dark blue squares, marios shirt
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(60,8);
Console.Write("          ");
Console.SetCursorPosition(70,8);
Console.Write("          ");
Console.SetCursorPosition(80,8);
Console.Write("          ");
//print 5 blue squares, after mario
Console.BackgroundColor = ConsoleColor.Blue;
for(int i = 0; i < 5; i++)
{
    //adding 90 because that is where the pattern left off before
    Console.SetCursorPosition((10*i)+90,8);
    Console.Write("          ");
}
/********************************
* Tenth row of color            *
*                               *
********************************/
//1 blue Square
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,9);
Console.Write("          ");
Console.SetCursorPosition(10,9);
Console.Write("          ");
//3 dark blue squares marios shirt
Console.BackgroundColor = ConsoleColor.DarkBlue;
for(int i = 0; i < 3; i++)
{
    Console.SetCursorPosition(20+i*10,9);
    Console.Write("          ");
}
//1 red square, marios overalls
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(50,9);
Console.Write("          ");
//2 dark blue squares, marios shirt
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(60,9);
Console.Write("          ");
Console.SetCursorPosition(70,9);
Console.Write("          ");
// 1 red square marios overall
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(80,9);
Console.Write("          ");
//3 dark blue squares marios shirt
Console.BackgroundColor = ConsoleColor.DarkBlue;
for(int i = 0; i < 3; i++)
{
    Console.SetCursorPosition(90 + (i*10),9);
    Console.Write("          ");
}
//2 blue squares after mario
Console.SetCursorPosition(120,9);
Console.Write("          ");
Console.SetCursorPosition(130,9);
Console.Write("          ");
/********************************
* Eleventh row of color         *
*                               *
********************************/
//1 blue square
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,10);
Console.Write("          ");
//4 dark blue squares
Console.BackgroundColor = ConsoleColor.DarkBlue;
for(int i = 0; i < 4; i++)
{
    Console.SetCursorPosition(10+i*10,10);
    Console.Write("          ");
}
//1 red square
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(50,10);
Console.Write("          ");
//2 dark blue squares
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(60,10);
Console.Write("          ");
Console.SetCursorPosition(70,10);
Console.Write("          ");
//1 red square
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(80,10);
Console.Write("          ");
//4 dark blue squares
Console.BackgroundColor = ConsoleColor.DarkBlue;
for(int i = 0; i < 4; i++)
{
    Console.SetCursorPosition(90+i*10,10);
    Console.Write("          ");
}
//1 blue square
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(130,10);
Console.Write("          ");
/********************************
* Twelfth row of color          *
*                               *
********************************/
//1 blue square
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,11);
Console.Write("          ");
//2 yellow squares
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(10,11);
Console.Write("          ");
Console.SetCursorPosition(20,11);
Console.Write("          ");
//2 dark blue squares
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(30,11);
Console.Write("          ");
Console.SetCursorPosition(40,11);
Console.Write("          ");
//4 red squares
Console.BackgroundColor = ConsoleColor.Red;
for(int i = 0; i < 4; i++)
{
    Console.SetCursorPosition(50+i*10,11);
    Console.Write("          ");
}
//2 dark blue squares
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(90,11);
Console.Write("          ");
Console.SetCursorPosition(100,11);
Console.Write("          ");
//2 yellow squares
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(110,11);
Console.Write("          ");
Console.SetCursorPosition(120,11);
Console.Write("          ");
//1 blue square
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(130,11);
Console.Write("          ");
/********************************
* Thirteenth row of color       *
*                               *
********************************/
//1 blue square
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0, 12);
Console.Write("          ");
//3 yellow squares, marios hand
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(10, 12);
Console.Write("          ");
Console.SetCursorPosition(20, 12);
Console.Write("          ");
Console.SetCursorPosition(30, 12);
Console.Write("          ");
//1 red square
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(40, 12);
Console.Write("          ");
//1 gold square, marios button
Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.SetCursorPosition(50, 12);
Console.Write("          ");
//2 red squares
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(60, 11);
Console.Write("          ");
Console.SetCursorPosition(70, 12);
Console.Write("          ");
//1 gold square, marios button
Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.SetCursorPosition(80, 12);
Console.Write("          ");
//1 red square
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(90, 12);
Console.Write("          ");
//3 yellow squares, marios hand
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(100, 12);
Console.Write("          ");
Console.SetCursorPosition(110 , 12);
Console.Write("          ");
Console.SetCursorPosition(120, 12);
Console.Write("          ");
//1 blue square
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(130, 12);
Console.Write("          ");
/********************************
* Fourteenth row of color       *
*                               *
********************************/
//1 blue square
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0, 13);
Console.Write("          ");
//2 yellow square, marios hand
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(10, 13);
Console.Write("          ");
Console.SetCursorPosition(20, 13);
Console.Write("          ");
//8 red squares
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Black;
for(int i = 0; i < 8; i++)
{
    Console.SetCursorPosition(30+i*10,13);
    Console.Write("          ");
}
//2 yellow squares, marios hand
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(110, 13);
Console.Write("          ");
Console.SetCursorPosition(120, 13);
Console.Write("          ");
//1 blue square
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(130, 13);
Console.Write("          ");