// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
PrdoubleTask();
double b1 = InputValue("b1");
double k1 = InputValue("k1");
double b2 = InputValue("b2");
double k2 = InputValue("k2");
double x = GetX(b1, k1, b2, k2);
double y = GetY(b1, k1, x);
PrdoubleResult(b1, k1, b2, k2, x, y);

void PrdoubleTask() {
    Console.WriteLine("Программа находит точку пересечения двух прямых,\n" +
    "заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.\n"+
    "Значения b1, k1, b2 и k2 задаются пользователем.\n");
}

double InputValue(string point) {
        Console.Write($"Введите значение {point} : ");
        double.TryParse(Console.ReadLine(), out double value);
        return value;    
}

double GetX(double b1, double k1, double b2, double k2) {
    double x = (b2 - b1)/(k1 - k2);
    return x;
}

double GetY(double b1, double k1, double x) {
    double y = k1 * x + b1;
    return y;
}

void PrdoubleResult(double b1, double k1, double b2, double k2, double x, double y) {
    Console.WriteLine();
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x:N1}; {y:N1})\n");
}