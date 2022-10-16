Console.WriteLine("Введите три числа ");

int count = 0;
int a = int.Parse(Console.ReadLine()!);
int max = a;
int min = a;
while(count<2)
{int b = int.Parse(Console.ReadLine()!);
 if (b>max) max = b;
 if (b<min) min = b;
 count++;
 }

Console.WriteLine("max="+max);
Console.WriteLine("min="+min);
