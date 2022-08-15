// Найти сумму чисел от 1 до А
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Сумма чисел " + A * (A + 1) / 2);
