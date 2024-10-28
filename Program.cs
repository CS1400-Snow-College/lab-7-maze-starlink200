/***********************
* Caleb Roskelley
* Lab 7 Maze
* Date Started: 10/23
* Date Finished:
***********************/

using System.Reflection.Metadata;
using System.Diagnostics;
internal class Program
{

    private static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        Random rand = new Random();
        int randMapNum = rand.Next(1,6);
        string[] mapRows = mapChoice(randMapNum);

        programIntro();
        Console.ReadKey();
        stopwatch.Start();
        Console.Clear();

        int origRow = Console.CursorTop;
        int origCol = Console.CursorLeft;
        foreach(string row in mapRows)
        {
            Console.WriteLine(row);
        }
        Console.SetCursorPosition(origCol, origRow);

        bool goal = false;
        long seconds = 0;
        int copyCol = 0;
        int copyRow = 0;
        do
        {
            //copies of the original row and column values in case moving is invalid
            copyCol = origCol;
            copyRow = origRow;
            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.UpArrow:
                    origRow--;
                    break;
                case ConsoleKey.DownArrow:
                    origRow++;
                    break;
                case ConsoleKey.LeftArrow:
                    origCol--;
                    break;
                case ConsoleKey.RightArrow:
                    origCol++;
                    break;
            }
            if(tryMove(mapRows, origCol, origRow))
            {
                Console.SetCursorPosition(origCol, origRow);
            }
            else
            {
                origCol = copyCol;
                origRow = copyRow;
                Console.SetCursorPosition(origCol, origRow);
            }
            goal = reachedGoal(mapRows, origCol, origRow);
        }
        while(goal);

        seconds = stopwatch.ElapsedMilliseconds/1000;
        Console.WriteLine();
        stopwatch.Stop();
        Console.Clear();

        Console.WriteLine("Congratulations! You reached the end of the maze!!!");
        Console.WriteLine($"It took you {seconds} seconds to complete!");
    }
    static void programIntro()
    {
        Console.WriteLine("This program will present a maze for you to move through using directional arrows, your goal is to reach the *");
        Console.WriteLine("Goodluck! Press any button to continue");
    }

    static bool reachedGoal(string[] map, int col, int row)
    {
        if(map[row][col].Equals('*'))
        {
            return false;
        }
        return true;
    }

    //tests to make sure that where the user wants to go is valid
    //can't go past the top or bottom of maze and can't go to the left or right of the maze
    static bool tryMove(string[] map, int col, int row)
    {
        if(map[row][col].Equals('#'))
        {
            return false;
        }
        if(col < 0 || col > Console.BufferWidth ||  row < 0 || row > Console.BufferHeight)
        {
            return false;
        }
        return true;
    }
    
    //method to randomly select one of the map choices
    static string[] mapChoice(int randNum)
    {
        string[] map = new string[6];
        /*
        switch(randNum)
        {
            case 1:
                map = File.ReadAllLines("map-options/map1.txt");
                break;
            case 2:
                map = File.ReadAllLines("map-options/map2.txt");
                break;
            case 3:
                map = File.ReadAllLines($"map-options/map3.txt");
                break;
            case 4:
                map = File.ReadAllLines("map-options/map4.txt");
                break;
            default:
                map = File.ReadAllLines("map-options/map5.txt");
                break;
        }
        */
        map = File.ReadAllLines($"map-options/map{randNum}.txt");
        return map;
    }
}