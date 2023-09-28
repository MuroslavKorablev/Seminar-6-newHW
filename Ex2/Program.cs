WorkWithUser("Введите значение k1: ");
WorkWithUser("Введите значение b1: "); // Ваши действия с k1, b1, k2 и b2 здесь
WorkWithUser("Введите значение k2: ");
WorkWithUser("Введите значение b2: ");
GigaChat(k1, k2, b1, b2);
 
void WorkWithUser(string message)
{
 Console.Write(message);
 double value = double.Parse(Console.ReadLine());
 // Здесь вы можете что-то делать с value, если необходимо
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