// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputInt(string message)
{
    System.Console.Write($"{message} > ");
    // bool isCorrect = int.TryParse(Console.Readline(), out value);//
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

double distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    int deltaZ = z2 - z1;
    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
}
int x1 = InputInt("Введите X1");
int y1 = InputInt("Введите Y1");
int z1 = InputInt("Введите Z1");
int x2 = InputInt("Введите X2");
int y2 = InputInt("Введите Y2");
int z2 = InputInt("Введите Z2");


System.Console.WriteLine($"Расстояние между двумя точками равняется {distance(x1, y1, z1, x2, y2, z2):F3}");

