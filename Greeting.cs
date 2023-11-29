using System;
namespace CSBasics;

public class Greeting {
  public void DisplayGreeting() {
    // input, output, null-coalescing operator and vairables in strings
    Console.Write("Type your name: ");
    string Name = Console.ReadLine() ?? "";

    Console.Write("Type your age: ");
    string Age = Console.ReadLine() ?? "";

    Console.WriteLine($"Hello, {Name}! You are {Age} old.");
  }
}