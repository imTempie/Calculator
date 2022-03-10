using System;

class MainClass {
  public static void Main (string[] args) {

		Console.WriteLine ("Calculator V1 by Harley");
		Console.WriteLine();
	
		string val;
		double num1;
	
		Console.WriteLine("Enter your first number:");
		val = Console.ReadLine();
		num1 = Convert.ToInt32(val);

		string val2;
			double num2;
			Console.WriteLine();
			Console.WriteLine("Enter your second 	number:");
			val2 = Console.ReadLine();
			num2 = Convert.ToInt32(val2);
	
			Console.WriteLine();
			Console.WriteLine("Number 1 = " +num1);
			Console.WriteLine("Number 2 = " +num2);
			Console.WriteLine();
			Console.WriteLine("Would you like to add, subtract, multiply or divide number 1 by 2?");
			Console.WriteLine();
				string choice = Console.ReadLine();
		
				if (choice == "add"){
					double sum = num1 + num2;
					Console.WriteLine();
					Console.WriteLine("The answer is:	" + sum);
				}
				else if (choice == "subtract"){
					double subtract = num1 - num2;
					Console.WriteLine();
					Console.WriteLine("The answer is:	" + subtract);
				}
				else if (choice == "multiply"){
					double multiply = num1 * num2;
					Console.WriteLine();
					Console.WriteLine("The answer is:	" + multiply);
				}
				else if (choice == "divide"){
					double divide = num1 / num2;
					Console.WriteLine();
					Console.WriteLine("The answer is:	" + divide);
			

		}	  
	}
}
