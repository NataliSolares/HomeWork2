// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число от 1 до 7");
int n = int.Parse(Console.ReadLine());
if (n < 6)
{
    Console.WriteLine("Будний день ");
}
else
{
    Console.WriteLine("Выходной день ");
}