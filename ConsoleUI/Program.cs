using CalculatorLibrary;

Console.Write("Enter the first value: ");
string? firstOperand = Console.ReadLine();

Console.Write("Enter the second value: ");
string? secondOperand = Console.ReadLine();

Console.Write("Enter the operation (+, -, * or /): ");
string? operation = Console.ReadLine();

Console.WriteLine($"The result is: {Calculator.Compute(firstOperand, secondOperand, operation)}");