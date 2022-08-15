// Определить количество цифр в числе
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int i = 0;
while (n > 0)
{
    n = n/10;
    i++;
}
Console.WriteLine("Количество цифр в числе: " + i);