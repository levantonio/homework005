// Задача 34:
// 1.Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2.Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


 int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size]; //- создаем массив, который передадим из аргумента
    Random rnd = new Random(); //надо делать так 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);  //i = индекс массива
    }
    return array;    
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, "); //выводим последний элемент без запятой в конце!!!!!
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int EvenNumbers(int[] array)  
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) sum++;
    }
    return sum;
}

int[] arr = CreateArrayRndInt(123, 100, 999);
PrintArray(arr);
int evennumbers = EvenNumbers(arr);
Console.Write($"Количество четных чисел в массиве --> {evennumbers}");