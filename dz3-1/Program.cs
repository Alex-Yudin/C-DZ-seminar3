// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Проверка без применения строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int Prompt(string message)        // Создаем метод
// {
//     System.Console.Write($"{message} > ");
//     return Convert.ToInt32(Console.ReadLine());
// }

int howManyDigits = 5;

int InputInt(string message)
{
    System.Console.Write($"{message} > ");
       if (int.TryParse(Console.ReadLine(), out int number))
    {
        return number;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

bool validateNumber(int number)
{
    int result = Convert.ToInt32(Math.Ceiling(Math.Log10(number)));
    if(result != howManyDigits)
    {
        System.Console.WriteLine($"Ошибка: введено число не содержащее {howManyDigits} цифр.");
        return false;
    }
    return true;
}

int reversNum(int number)
{
    int reverse = 0;
    while (number > 0)
    {
        reverse = reverse * 10 + number % 10;
        number = number / 10;
    }
    return reverse;
}

int number = InputInt("Введите пятизначное число > ");
if (validateNumber(number))
{
    if (number == reversNum(number))
    {
        System.Console.WriteLine($"Число {number} является полиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не полиндром"); 
    }
}

