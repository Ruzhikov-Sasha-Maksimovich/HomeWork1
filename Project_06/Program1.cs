    Console.WriteLine("Введите число: ");
    int chislo1 = Convert.ToInt32(Console.ReadLine()!);
    Console.WriteLine("Введите число: ");
    int chislo2 = Convert.ToInt32(Console.ReadLine()!);
    int sum = Convert.ToInt32(chislo1);
for (int i = 1; i < chislo2; i++)
    {
        sum = sum * chislo1;
    }
    Console.WriteLine(sum);
