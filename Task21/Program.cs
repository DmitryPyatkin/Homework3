// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3, 6, 8); B (2, 1, -7), -> 15.84
// A (7, -5, 0); B (1, -1, 9) -> 11.53

Console.WriteLine("\n Задача 21"); // \n это управляющий символ.

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}
// Оператор return завершает выполнение метода, в котором он присутствует, и возвращает управление и результат функции (при его наличии) вызывавшему методу.

double Decision(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
// Double - это тип данных который хранит значения с плавающей запятой двойной точности в 64-разрядном двоичном формате.
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2));
} // Math. Sqrt() – математическая функция которая извлекает квадратный корень.
// Math.Pow() – возведения числа в степень. В аргументных скобках через запятую указываются два аргумента (1-ый аргумент - число, которое возводим в степень, 2-ой – степень, в которую возводим число).

double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);
// Math.Round округляет значение до ближайшего целого или указанного количества десятичных знаков.
Console.WriteLine($"Длина отрезка  {segmentLength}");