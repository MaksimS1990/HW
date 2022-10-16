Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);
if (a>b)
{
Console.WriteLine();
Console.WriteLine("max="+a);
Console.WriteLine("min="+b);
}
else
{
    Console.WriteLine();
Console.WriteLine("max="+b);
Console.WriteLine("min="+a);
}