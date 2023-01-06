Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a>b) max = a;
if (a<b) max = b;
Console.Write ("max=");
Console.Write (max);
