using ChristmasChallenge;
public class Program
{
    public static void ShowDayMessage(int dayNumber)
    {
        Console.ForegroundColor= ConsoleColor.Green;
        Console.WriteLine($"\n --- DAY {dayNumber} --- ");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void Main(string[] args)
    {
        ShowDayMessage(8);
        Day8DuplicatedAddresses day8 = new Day8DuplicatedAddresses();
        day8.ShowResult();

        ShowDayMessage(9);
        Day9_VowelsCount day9 = new Day9_VowelsCount();
        day9.ShowResult();

        ShowDayMessage(10);
        Day10_ChristmasCandy day10_ = new Day10_ChristmasCandy();
        day10_.ShowResult();

        ShowDayMessage(11);
        Day11_ChooseEnvelope day11 = new Day11_ChooseEnvelope();
        day11.ShowResult();
    }
}