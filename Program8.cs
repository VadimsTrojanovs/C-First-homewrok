int a;
Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out a);
for (int i=1; i<=a; i++) 
{
    if(i%2 == 0) 
    {
        Console.Write(i + ", ");
    }
}
Console.ReadKey();