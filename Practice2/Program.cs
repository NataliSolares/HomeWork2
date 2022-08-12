// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите числа: ");
int a = int.Parse(Console.ReadLine()?? "0");
int b = int.Parse(Console.ReadLine()?? "0");
if(a == b * b)
{
    Console.WriteLine("Число: " + a + " является квадратом числа " + b);
}
else
{
    Console.WriteLine("Число: " + a + " не является квадротом числа " +b);
}
