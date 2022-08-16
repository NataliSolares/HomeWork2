// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine() ?? "0");
int s = 0;
while (n > 0)
    {
        s = s + (n % 10);
        n = n / 10;
    }
Console.WriteLine(s);
