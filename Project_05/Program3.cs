System.Console.WriteLine("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine()!);
string chisloText = Convert.ToString(chislo);
int sum = 0;
int index = 0;

while(chislo > index)
{
    int result = chislo % 10;
    chislo = chislo / 10;
    sum = sum + result;
}
System.Console.WriteLine($"Сумма чисел числа {chisloText} равна {sum}");
