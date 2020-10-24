using System;

namespace LogFileSample
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Logging sample!");
            Console.WriteLine("Enter the first number..");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number..");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            AddNumber addNumber = new AddNumber();
            int sum = addNumber.Add(firstNumber, secondNumber);
            Console.WriteLine("sum " + sum);

            
            
        }
    }
}
