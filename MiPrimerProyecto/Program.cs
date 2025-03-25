using System;

class Program
{
    static void Main(string[] args)
    {
        FirstSteps();
        calculateAverageGrade();
    }

    public static void FirstSteps()
    {
        Console.WriteLine("Hello World");
        Console.WriteLine('C'); // this is a character
        // to write numbers by default we use a double data type, as well we have float(f) and decimal(m), E.G. 0.35f
        string firstName = "John";
        Console.WriteLine("Hello \"World\"!"); // the same as \n, \t, \"
        Console.WriteLine("c:\\source\\repos"); // c:\source\repos
        Console.Write(@"c:\invoices"); // that takes literaly the same as we put. It's create an clean code
        // and more easily to write a string path
        Console.WriteLine($"Hello {firstName}!");

        string projectName = "First-Project";
        Console.WriteLine($@"C:\Output\{projectName}\Data");

        projectName = "ACME";
        string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
        Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

        string russianMessage =
            "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
        string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
        Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

        int first = 7;
        int second = 5;
        decimal
            quotient = (decimal)first /
                       (decimal)second; // if you dont  caste the data an opeation with integers return another one.
        Console.WriteLine(quotient);

        Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");//the syntaxis is the same as js
        Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
        // the order of parentheses is> another parentheses, exponents, multiplication, division, addition and substraction
        
        int value = 0;     // value is now 0.
        value = value + 5; // value is now 5.
        value += 5;        // value is now 10.
        value++;           // value is now 11.
        Console.WriteLine("First: " + value);
        Console.WriteLine($"Second: {value++}");
        Console.WriteLine("Third: " + value);
        Console.WriteLine("Fourth: " + (++value));
        Console.WriteLine("\n\n\n\n");
    }

    public static void calculateAverageGrade()
    {
        //first we need create a List of grades
        List<double> grades = new List<double>();
        grades.Add(1);
        grades.Add(2);
        grades.Add(3);
        
        Console.WriteLine($"The average grade is: {grades.Sum() / grades.Count()}");
    }
    
}