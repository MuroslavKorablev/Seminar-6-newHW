double k1, b1, k2, b2;

k1 = WorkWithUser("Введите значение k1: ");
b1 = WorkWithUser("Введите значение b1: ");
k2 = WorkWithUser("Введите значение k2: ");
b2 = WorkWithUser("Введите значение b2: ");

GigaChat(k1, k2, b1, b2);

double WorkWithUser(string message)
{
    double value;
    Console.Write(message);
    while (!double.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine("Ошибка! Введите корректное число.");
        Console.Write(message);
    }
    return value;
}

// Найдем точку пересечения двух прямых
void GigaChat(double k1, double k2, double b1, double b2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны и не имеют точек пересечения.");
    }
    else
    {
        double xIntersection = (b2 - b1) / (k1 - k2);
        double yIntersection = k1 * xIntersection + b1;
        Console.WriteLine("Точка пересечения: (" + xIntersection + ", " + yIntersection + ")");
    }
}