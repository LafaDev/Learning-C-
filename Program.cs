using System;
namespace CSBasics;

class Program {
  static void Main() {
    Greeting greeting = new Greeting();
    LightBulbCalculator lbc = new LightBulbCalculator();
    SimpleCalculator calc = new SimpleCalculator();

    string prompt = @"Hello, Which function do you want to run?
    1- Greeting
    2- LightBulbCalculator
    3- Simple Calcuator

    (1, 2, 3): ";
    Console.Write(prompt);
    string functionNumber = Console.ReadLine() ?? "";

    if (functionNumber == "1") {
      greeting.DisplayGreeting();
    } if (functionNumber == "2") {
      lbc.Calculator();
    } if (functionNumber == "3") {
      calc.SimpleCalc();
    } else {
      Console.WriteLine("Invalid input or inexistent function");
    }
  }
}
