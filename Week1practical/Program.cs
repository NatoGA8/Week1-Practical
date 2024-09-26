// See https://aka.ms/new-console-template for more information
//BuildWeek1practicalTask1();
//BuildWeek1practicalTask2();
//BuildWeek1practicalTask3();
//BuildWeek1practicalTask4();
BuildWeek1practicalTask5();

void BuildWeek1practicalTask1()
{
    Console.WriteLine("Please enter your name: ");
    string name = Console.ReadLine();

    Console.WriteLine("Please enter your age? ");
        int age =
    int.Parse(Console.ReadLine());

    int futureAge = age + 5;

    Console.WriteLine($"Hello {name}, you will be {futureAge} in 5 years.");

        }
void BuildWeek1practicalTask2()
{
    Console.Write("Please enter your age: ");
    int age =
int.Parse(Console.ReadLine());

    if (age < 0 || age > 110)
    {
        Console.WriteLine("Invalid age entered. Please enter a vaild age between0 and 110.");
    }
    else

                    if (age < 13)
    {
        Console.WriteLine("You are a child.");
    }
    else if (age >= 13 && age <= 19)
    {
        Console.WriteLine("You are a teenager");

    }
    else
    {
        Console.WriteLine("You are an adult.");
    }
}
        
void BuildWeek1practicalTask3() 
    
    {
    Console.Write("Please enter an integer: ");
    int integer =
int.Parse(Console.ReadLine());

    if (integer < 0)
    {
        Console.WriteLine("This is a negative number.");
    }
    else if (integer == 0)
    {
        Console.WriteLine("This is Zero.");
    }

    else
    {
        Console.WriteLine("This is a positive number.");
    }
}
void BuildWeek1practicalTask4()
{
    Console.Write("Please enter a year: ");

    // Ensure we parse the input correctly
    if (int.TryParse(Console.ReadLine(), out int year))
    {
        if (year < 0)
        {
            Console.WriteLine("This is a negative year. Please enter a year:");
        }
        else if (year == 0)
        {
            Console.WriteLine("This is year Zero.");
        }
        else if (year % 4 == 0) // Corrected the leap year condition
        {
            if (year % 100 == 0 && year % 400 != 0)
            {
                Console.WriteLine($"This is not a leap year: {year}");
            }
            else
            {
                Console.WriteLine($"This is a leap year: {year}");
            }
        }
        else
        {
            Console.WriteLine($"This is not a leap year: {year}");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid year.");
    }
}
void BuildWeek1practicalTask5()
{
    Console.Write("Please enter a number: ");

    // Parse the input safely
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number == 0)
        {
            Console.WriteLine("This is Zero.");
        }
        else if (number % 2 == 0) // Check if the number is even
        {
            Console.WriteLine("This is an even number.");
        }
        else // If it's not even, it must be odd
        {
            Console.WriteLine("This is an odd number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
}

