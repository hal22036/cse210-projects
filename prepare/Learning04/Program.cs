using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment();
        assignment.SetStudentName("Samuel Bennett");
        assignment.SetTopic("Multiplication");
        Console.WriteLine(assignment.GetSummary());

        // above can also be written like:
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        Math math = new Math();
        math.SetStudentName("Roberto Rodriguez");
        math.SetTopic("Fractions");
        math.SetTextbookSection("7.3");
        math.SetProblems("8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        // above can also be written like:
        Math math1 = new Math("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Writing writing = new Writing();
        writing.SetStudentName("Mary Waters");
        writing.SetTopic("European History");
        writing.SetTitle("The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());

        // above can also be written like:
        Writing writing1 = new Writing("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}