// Задача 38:
// 1.Задайте массив вещественных чисел.
// 2.Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size]; //- создаем массив, который передадим из аргумента
    Random rnd = new Random(); //надо делать так
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min; //i = индекс массива
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, "); //выводим последний элемент без запятой в конце!!!!!
        else
            Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double SumMinMaxElem(double[] array) //ворачиваем суммы
{
    double sum = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];

        if (array[i] > max)
            max = array[i];
        sum = min + max;
        sum = Math.Round(sum, 1);
    }

    return sum;
}

// return округлить методом Math.Round()
double[] arr = CreateArrayRndDouble(5, -5, 5);
PrintArray(arr);
double summinmaxelem = SumMinMaxElem(arr);
Console.WriteLine($"Сумма min и max элементов массива = {summinmaxelem}");
