Console.WriteLine("STUDENT NAME: SYEDA SUMBUL FAISAL || STUDENT ID: 66552 || SUBMITTION DATE: 28/10/26");
Console.Write("Enter a year: ");
if (int.TryParse(Console.ReadLine(), out int year))
{
    bool isLeap = false;

    if (year % 400 == 0)
    {
        isLeap = true;
    }
    else if (year % 100 == 0)
    {
        isLeap = false;
    }
    else if (year % 4 == 0)
    {
        isLeap = true;
    }
    else
    {
        isLeap = false;
    }

    if (isLeap)
    {
        Console.WriteLine($"{year} is a leap year.");
    }
    else
    {
        Console.WriteLine($"{year} is not a leap year.");
    }
}
else
{
    Console.WriteLine("Invalid input.");
}
