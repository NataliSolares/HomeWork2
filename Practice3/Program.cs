// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти от 1 до 4: " );
int a = int.Parse(Console.ReadLine()?? "0");
if(a==1)
{
    Console.WriteLine("диапазон 1 четверти x>0 до infinity; y>0 до infinity");
}
if(a==2)
{
   Console.WriteLine("диапазон 2 четверти x>0 до -infinity; y>0 до infinity"); 
}
if(a==3)
{
    Console.WriteLine("диапазон 3 четверти x>0 до -infinity; y>0 до -infinity");
}
if(a==4)
{
    Console.WriteLine("диапазон 4 четверти x>0 до infinity; y>0 до -infinity");
}
