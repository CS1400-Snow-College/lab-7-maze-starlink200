internal class Program
{
    private static void Main(string[] args)
    {
        int origRow = Console.CursorTop;
        int origCol = Console.CursorLeft;
        string[] mapRows = File.ReadAllLines("map.txt");
        programIntro();
        Console.ReadKey();
        Console.Clear();
        foreach(string row in mapRows)
        {
            Console.WriteLine(row);
        }
        Console.SetCursorPosition(origCol, origRow);
        for(int i = 0; i < 20; i++)
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
        }
    }
    static void programIntro()
    {
        Console.WriteLine("This program will present a maze for you to move through using directional arrows, your goal is to reach the *");
        Console.WriteLine("Goodluck! Press any button to continue");
    }
}