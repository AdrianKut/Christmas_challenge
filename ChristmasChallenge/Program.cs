using ChristmasChallenge;
using ChristmasChallenge.Day_19;

public class Program
{
    public static void ShowDayMessage(int dayNumber)
    {
        Console.ForegroundColor= ConsoleColor.Green;
        Console.WriteLine($"\n\n --- DAY {dayNumber} --- ");
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

        ShowDayMessage(12);
        Day12_PrintLabels day12 = new Day12_PrintLabels();
        day12.ShowResult();

        ShowDayMessage(13);
        Day13_RevertNames day13 = new Day13_RevertNames();
        day13.ShowResult();

        ShowDayMessage(14);
        Day14_SplitPresentsList day14 = new Day14_SplitPresentsList();
        day14.ShowResult();

        ShowDayMessage(15);
        Day15_RecalculateIngredients day15 = new Day15_RecalculateIngredients();
        day15.ShowResult();

        ShowDayMessage(16);
        Day16_FindOldestAndYoungest day16 = new Day16_FindOldestAndYoungest();
        day16.ShowResult();

        //ShowDayMessage(17);
        //Day17_ChristmasBall day17 = new Day17_ChristmasBall();
        //day17.ShowResult();

        //Console.Clear();
        //ShowDayMessage(18);
        //Day18_SongPrompter day18 = new Day18_SongPrompter();
        //day18.ShowResult();

        ShowDayMessage(19);
        Day19_WrappingPaper day19 = new Day19_WrappingPaper();
        day19.ShowResult();
    }
}