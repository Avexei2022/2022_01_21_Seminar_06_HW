// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
PrintTask();
int[] myArray = CreateArray();
FillArray(myArray);
int result = GetResult(myArray);
PrintResult(myArray, result);

void PrintTask() {
    Console.WriteLine("Пользователь вводит с клавиатуры M чисел.\n" +
    "Программа посчитает, сколько чисел больше 0 ввёл пользователь.\n");
}

int[] CreateArray() {
    int arraySize = 0;
    while (arraySize < 1) {
        Console.Write("Определите кличество целых чисел (М): ");
        int.TryParse(Console.ReadLine(), out arraySize);        
    }
    int[] array = new int[arraySize];
    for(int i = 0; i < arraySize; i++) array[i] = 0;
    return array;
}

int[] FillArray(int[] array) {
    int value = 0;
    Console.WriteLine();
    for(int i = 0; i < array.Length; i++)  {
        Console.Write($"Введите {i+1}-е целое число: ");
        int.TryParse(Console.ReadLine(), out value);
        array[i] = value;       
    }
    return array;
}

int GetResult(int[] array) {
    int count = 0;
    foreach (var item in array) {
       if (item > 0) count++; 
    }
    return count;
}

void PrintResult (int[] array, int count) {
    Console.WriteLine();
    Console.Write("Вы ввели числа: ");
    foreach (int item in array) Console.Write($"{item} ");
    Console.WriteLine("\n");
    Console.WriteLine($"Количество чисел больше 0 -> {count}\n");
}
