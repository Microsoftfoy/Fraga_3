using System;

class Program
{
    static void Main()
    {
        int sum = 0; 
        
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Ange heltal nummer {i}:");
            int number = int.Parse(Console.ReadLine()); 
            sum += number;
        }

        Console.WriteLine($"Summan av de inmatade talen är: {sum}");

        Console.ReadKey();
    }
}
