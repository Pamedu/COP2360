using System;
using System.Xml.XPath;

//Try... block must be follower by one or more Catch or Finally block
//Catch... block executes when error is thrown in try block
//Finally... block executes after executions leaves try block

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int numberTwo = int.Parse(Console.ReadLine());
        try
        {
            int result = numberOne / numberTwo; //Performs Division
            Console.WriteLine("Result: " + result); //Result of Division
        }
        catch (FormatException e) //Handles Format Exception
        {
            Console.WriteLine("Enter ONLY numbers please!");
        }
        catch (DivideByZeroException e) //Handles Divide By Zero Exception
        {
            Console.WriteLine("You can not divide by zero!");
        }
        catch (OverflowException e) // Handles Overflow Exception
        {
            Console.WriteLine("Number is too large to handle.");
        }
        catch (Exception e) //Handles All Other Exceptions
        {
            Console.WriteLine("Error occurred.");
        }
        finally
        {
        Console.WriteLine("Hit any key to exit..."); //Prompt to exit
        Console.ReadKey(); //Takes user input
        }
    }
}