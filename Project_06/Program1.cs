Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number > 99){
  Console.WriteLine($"третья цифра {number % 10}");
}
else if (number < 100) {
  Console.WriteLine("В числе нет 3 цифры");
}