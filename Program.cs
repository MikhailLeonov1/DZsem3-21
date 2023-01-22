// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = ReadInt("Введите первую координату X : ");
int x2 = ReadInt("Введите вторую координату X : ");
int y1 = ReadInt("Введите первую координату Y : ");
int y2 = ReadInt("Введите вторую координату Y : ");
int z1 = ReadInt("Введите первую координату Z : ");  // Ввод координат
int z2 = ReadInt("Введите вторую координату Z : ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double rass = Math.Sqrt(A * A + B * B + C * C); // Формула нахождения расстояния координат 
Console.WriteLine($"Расстояние между точками {rass}");

int ReadInt(string message) // Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}