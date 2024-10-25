internal class Program
{
    private static void Main(string[] args)
    {
        string[] mapRows = File.ReadAllLines("map.txt");
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
            Console.SetCursorPosition(origCol, origRow);
            goal = reachedGoal(mapRows, origCol, origRow);
        }
        while(goal);
        Console.WriteLine();
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
}