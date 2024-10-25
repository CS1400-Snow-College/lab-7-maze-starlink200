internal class Program
{
    private static void Main(string[] args)
    {
        Random rand = new Random();
        int randMapNum = rand.Next(1,6);
        string[] mapRows = mapChoice(randMapNum);
        programIntro();
        Console.ReadKey();
        Console.Clear();
        int origRow = Console.CursorTop;
        int origCol = Console.CursorLeft;
        foreach(string row in mapRows)
        {
            Console.WriteLine(row);
        }
        Console.SetCursorPosition(origCol, origRow);
        bool goal = false;
        do
        {
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
            goal = reachedGoal(mapRows, origCol, origRow);
        }
        while(goal);
        Console.WriteLine();
        Console.Clear();
        Console.WriteLine("Congratulations! You reached the end of the maze!!!");
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
    static bool tryMove(string[] map, int col, int row)
    {
        if(row >= 0 && (row < Console.BufferHeight || row < map.Length) && (col >= 0 && col < Console.BufferWidth))
            return true;
        return false;
    }
    static string[] mapChoice(int randNum)
    {
        string[] map = new string[6];
        switch(randNum)
        {
            case 1:
                map = File.ReadAllLines("map1.txt");
                break;
            case 2:
                map = File.ReadAllLines("map2.txt");
                break;
            case 3:
                map = File.ReadAllLines("map3.txt");
                break;
            case 4:
                map = File.ReadAllLines("map4.txt");
                break;
            default:
                map = File.ReadAllLines("map5.txt");
                break;
        }
        return map;
    }
}