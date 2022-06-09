// Одно число должно быть квадратом второго
Console.WriteLine("Введите число 1");
int Number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int Number2 = int.Parse(Console.ReadLine());
if (Number1 == Number2 * Number2)
{
    Console.WriteLine("Вероно");
}
else
{
    Console.WriteLine("Не верно");
}