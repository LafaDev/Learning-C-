using System;

namespace CSBasics {
  public class SimpleCalculator {
    public void SimpleCalc() {
      Console.Write("Type your first number: ");
      decimal firstNumber;
      
      while (!decimal.TryParse(Console.ReadLine(), out firstNumber)) {
        Console.WriteLine("Invalid input. Please enter a valid decimal number.");
        Console.Write("Type your first number: ");
      }

      Console.Write("Type the operation: ");
      string operation = Console.ReadLine() ?? "";

      Console.Write("Type the second number: ");
      decimal secondNumber;

      while (!decimal.TryParse(Console.ReadLine(), out secondNumber)) {
        Console.WriteLine("Invalid input. Please enter a valid decimal number.");
        Console.Write("Type the second number: ");
      }

      decimal result = PerformCalculation(firstNumber, secondNumber, operation);
        Console.WriteLine($"Result of {firstNumber} {operation} {secondNumber} is: {result}");
      }

    private decimal PerformCalculation(decimal firstNumber, decimal secondNumber, string operation) {
      switch (operation) {
        case "+":
          return firstNumber + secondNumber;
        case "-":
          return firstNumber - secondNumber;
        case "*":
          return firstNumber * secondNumber;
        case "/":
          if (secondNumber != 0) {
            return firstNumber / secondNumber;
          } else {
            Console.WriteLine("Cannot divide by zero. Please enter a non-zero second number.");
            return 0;
          }
        case "%":
          return firstNumber % secondNumber;
        default:
          Console.WriteLine("Invalid operation. Please enter a valid operation (+, -, *, /).");
          return 0;
      }
    }
  }
}
