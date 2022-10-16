Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
if (a<1) Console.WriteLine("Число должно быть больше 1");
int count = 1;
int b = 0;
while (count<=a)
     {
          b = (count%2);
    if (b == 0) Console.Write(count+" ");
   
     
    count++;
     }