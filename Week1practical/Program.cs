// See https://aka.ms/new-console-template for more information
BuildWeek1practical();

void BuildWeek1practical ()
{
    Console.WriteLine("Please enter your name: ");
    string name = Console.ReadLine();

    Console.WriteLine("Please enter your age? ");
        int age =
    int.Parse(Console.ReadLine());

    int futureAge = age + 5;

    Console.WriteLine($"Hello {name}, you will be {futureAge} in 5 years.");

        }