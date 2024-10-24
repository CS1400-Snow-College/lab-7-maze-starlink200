internal class Program
{
    private static void Main(string[] args)
    {
        string[] mapRows = File.ReadAllLines("map.txt");
        programIntro();
        Console.ReadKey();
        Console.Clear();
        foreach(string row in mapRows)
        {
            Console.WriteLine(row);
        }
    }
    static void programIntro()
    {
        Console.WriteLine("This program will present a maze for you to move through using directional arrows, your goal is to reach the *");
        Console.WriteLine("Goodluck! Press any button to continue");
    }
}