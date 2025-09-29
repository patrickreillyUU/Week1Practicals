void Task4()
{
    int year;
    Console.WriteLine("Please enter a year:");
    year = Convert.ToInt32(Console.ReadLine());

    if (year % 4 == 0)
    {
        Console.WriteLine("You have entered a leap year.");
    }
    else if (year % 100 == 0) 
    {
        Console.WriteLine("You have not entered a leap year.");
    }
    else if (year % 400  == 0) 
    {
         Console.WriteLine("You have entered a leap year.");
    }
    else if (year < 0)
    {
        Console.WriteLine("Invalid year.");
    }
    else
    {
        Console.WriteLine("You have not entered a leap year.");
    }

}

Task4();