// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputInt(string message)
{
    System.Console.Write($"{message} > ");
       if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int number = InputInt("Введите число N, до которого считать кубы");

for(int i = 1; i <= number; i++)     // У цикла for три параметра: 1. int i = 1 - это инициализация; 2. i <= number - условие продолжения; 3. Команда увеличения счетчика if++ -      
{
    int cube = i * i * i;
    System.Console.Write($"{cube} ");
}