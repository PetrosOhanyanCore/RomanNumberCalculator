using RomanNumberCalculator;

var calculator = new RomanCalculator();

Console.WriteLine("Please write the Roman numeral expression");

var result = Console.ReadLine();
Console.WriteLine(calculator.Evaluate(result));

Console.ReadLine();