using System;
using System.Collections.Generic;

class Cell
{
    public int Row { get; set; }
    public int Column { get; set; }
    public bool IsMine { get; set; }
    public bool IsRevealed { get; set; }
    public int NearbyMines { get; set; }
}

class Game
{
    private int rows;
    private int columns;
    private int mineCount;
    private List<Cell> grid;

    public Game(int rows, int columns, int mineCount)
    {
        this.rows = rows;
        this.columns = columns;
        this.mineCount = mineCount;
        grid = new List<Cell>();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                grid.Add(new Cell { Row = i, Column = j });
            }
        }
    }

    public void Start()
    {
        var rnd = new Random();
        int remainingMines = mineCount;

        while (remainingMines > 0)
        {
            int index = rnd.Next(0, grid.Count);
            if (!grid[index].IsMine)
            {
                grid[index].IsMine = true;
                remainingMines--;
            }
        }

        foreach (var cell in grid)
        {
            cell.NearbyMines = GetNearbyMines(cell);
        }
    }

    private int GetNearbyMines(Cell cell)
    {
        int count = 0;

        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                int row = cell.Row + i;
                int column = cell.Column + j;

                if (row >= 0 && row < rows && column >= 0 && column < columns)
                {
                    if (grid[row * columns + column].IsMine)
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }

    public void RevealCell(int row, int column)
    {
        if (row < 0 || row >= rows || column < 0 || column >= columns)
        {
            return;
        }

        var cell = grid[row * columns + column];

        if (cell.IsRevealed)
        {
            return;
        }

        cell.IsRevealed = true;

        if (cell.IsMine)
        {
            throw new InvalidOperationException("Game over");
        }

        if (cell.NearbyMines == 0)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    RevealCell(row + i, column + j);
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Minesweeper!");
        Console.WriteLine("Enter number of rows (e.g., 5): ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of columns (e.g., 5): ");
        int columns = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of mines (e.g., 5): ");
        int mineCount = int.Parse(Console.ReadLine());

        var game = new Game(rows, columns, mineCount);
        game.Start();

        bool isPlaying = true;

        while (isPlaying)
        {
            Console.WriteLine("Enter row (e.g., 0) and column (e.g., 0) to reveal: ");
            int inputRow = int.Parse(Console.ReadLine());
            int inputColumn = int.Parse(Console.ReadLine());

            try
            {
                game.RevealCell(inputRow, inputColumn);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Game over! Try again?");
                isPlaying = false;
            }
        }
    }
}