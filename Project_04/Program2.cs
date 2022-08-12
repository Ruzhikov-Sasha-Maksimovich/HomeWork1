System.Console.Clear();

System.Console.WriteLine("Введите свое число: ");
int number = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine($"Ваше чиcло {(number % 100) / 10}");