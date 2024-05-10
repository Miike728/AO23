using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static int width = 20;
    static int height = 20;
    static int score = 0;
    static int speed = 10;
    static int foodX, foodY;
    static int headX, headY;
    static bool gameOver = false;
    static Random random = new Random();
    static List<int> tailX = new List<int>();
    static List<int> tailY = new List<int>();
    static ConsoleKeyInfo keyInfo;

    static void Main()
    {
        Setup();
        while (!gameOver)
        {
            Draw();
            Input();
            Logic();
            Thread.Sleep(1000 / speed);
        }
    }

    static void Setup()
    {
        Console.Title = "Snake Game";
        Console.CursorVisible = false;
        headX = width / 2;
        headY = height / 2;
        foodX = random.Next(1, width - 1);
        foodY = random.Next(1, height - 1);
    }

    static void Draw()
    {
        Console.Clear();
        for (int i = 0; i < width + 2; i++)
            Console.Write("#");
        Console.WriteLine();

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (j == 0)
                    Console.Write("#");
                if (i == headY && j == headX)
                    Console.Write("O");
                else if (i == foodY && j == foodX)
                    Console.Write("F");
                else
                {
                    bool tailDrawn = false;
                    for (int k = 0; k < tailX.Count; k++)
                    {
                        if (tailX[k] == j && tailY[k] == i)
                        {
                            Console.Write("o");
                            tailDrawn = true;
                        }
                    }
                    if (!tailDrawn)
                        Console.Write(" ");
                }

                if (j == width - 1)
                    Console.Write("#");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < width + 2; i++)
            Console.Write("#");
        Console.WriteLine();

        Console.WriteLine("Score: " + score);
    }

    static void Input()
    {
        if (Console.KeyAvailable)
        {
            keyInfo = Console.ReadKey(true);
        }
    }

    static void Logic()
    {
        int prevX = tailX.Count > 0 ? tailX.Last() : headX;
        int prevY = tailY.Count > 0 ? tailY.Last() : headY;
        int prev2X, prev2Y;
        tailX.Insert(0, headX);
        tailY.Insert(0, headY);
        if (tailX.Count > score)
        {
            tailX.RemoveAt(tailX.Count - 1);
            tailY.RemoveAt(tailY.Count - 1);
        }

        switch (keyInfo.Key)
        {
            case ConsoleKey.LeftArrow:
                headX--;
                break;
            case ConsoleKey.RightArrow:
                headX++;
                break;
            case ConsoleKey.UpArrow:
                headY--;
                break;
            case ConsoleKey.DownArrow:
                headY++;
                break;
        }

        if (headX < 0 || headX >= width || headY < 0 || headY >= height)
            gameOver = true;

        for (int i = 0; i < tailX.Count; i++)
        {
            if (tailX[i] == headX && tailY[i] == headY)
                gameOver = true;
        }

        if (headX == foodX && headY == foodY)
        {
            score++;
            foodX = random.Next(1, width - 1);
            foodY = random.Next(1, height - 1);
        }
    }
}
