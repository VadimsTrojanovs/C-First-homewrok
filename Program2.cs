int a;
int b;
Console.WriteLine("Введите первое число");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Введите второе число");
int.TryParse(Console.ReadLine(), out b);
if ( a > b){
    Console.WriteLine("Первое число больше второго");
}
else
{
    Console.WriteLine("Второе число больше первого");
}

Console.ReadKey();