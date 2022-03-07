using System;

namespace Calculator
{
    internal class Program
    {
		public static void Main()
		{
			// Initialize first and second numbers for storing user input
			double firstNum = 0;
			double secondNum = 0;

			// isValid is a boolean to be used in the below do while loop to check if the users input is valid or not
			bool isValid = false;

			// initial isValid false, will try parse user input if parseable the condition will be set to true 
			do
			{
				Console.WriteLine("Enter the first number");
				// check if the number inputted by the user is parseable
				if (Double.TryParse(Console.ReadLine(), out double num))
				{
					// firstNum variable we initialized at the beginning will be assigned to the users input which is a parseable double number
					firstNum = num;
					// set to true to exit the loop since we have sucessfully captured the users input as a double
					isValid = true;
				}
				else
				{
					// if user didn't enter a parseable number inform the user to re-enter a number
					Console.WriteLine("Please enter a number");
				}
			}
			while (!isValid);

			// from the previous do while loop we set isValid to true here we are setting it back to false.
			isValid = false;
			// while isValid is not true do the following
			do
			{
				// inform user to enter a second number
				Console.WriteLine("Enter the second number");
				// check if the number inputted by the user is parseable
				if (Double.TryParse(Console.ReadLine(), out double num))
				{
					// secondNum variable we initialized at the beginning will be assigned to the users input which is a parseable double number
					secondNum = num;
					// is valid so assign true to isValid to exit loop.
					isValid = true;
				}
				else
				{
					// inform again the user if input is not parseable and re-enter a input
					Console.WriteLine("Please enter a number");
				}
			}
			while (!isValid);

			// The following is to inform the user the operations the calculator will accepts.
			Console.WriteLine("Please enter the operation type \n\t [+] for addition\n\t [-] for subtraction\n\t [/] for division\n\t [*] for multiplication");
			// user input is taken in a switch statement and each case for mathematical operations available will be checked.
			switch (Console.ReadLine())
			{
				case "+":
					Console.WriteLine("{0} + {1} = {2}",firstNum, secondNum, (firstNum + secondNum));
					break;
				case "-":
					Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, (firstNum - secondNum));
					break;
				case "/":
					Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, (firstNum / secondNum));
					break;
				case "*":
					Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, (firstNum * secondNum));
					break;
				default:
					// default meaning the user did not entered the available options above therefore default case will run meaning wrong input.
					Console.WriteLine("Entered wrong operation");
					break;
			}
		}
	}
}
