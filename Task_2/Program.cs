// Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

int InputInt(string msg)
{
    System.Console.Write(msg + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

double b1 = InputInt("Введите значение для b1");
double k1 = InputInt("Введите значение для k1");
double b2 = InputInt("Введите значение для b2");
double k2 = InputInt("Введите значение для k2");

double FindX()
{
    return (-b2 + b1) / (-k1 + k2);
}

double FindY()
{
    double x = (-b2 + b1) / (-k1 + k2);
    return k2 * x + b2;
}

double X = FindX();
double Y = FindY();
System.Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {X}, Y: {Y}");