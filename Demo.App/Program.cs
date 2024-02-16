// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please type in some number");
var nStr = Console.ReadLine();

if (!int.TryParse(nStr, out n)){
    Console.WriteLine("It is not a number!");
}
Console.WriteLine($"Your number is {n}");
