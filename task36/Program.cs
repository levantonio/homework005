// Задача 36: 
// 1.Задайте одномерный массив, заполненный случайными числами. 
// 2.Найдите сумму элементов, стоящих на нечётных позициях. (i)

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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

int SumEvenNumbersPosition(int[] array)  
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1) sum += array[i];
    }
    return sum;
}

int[] arr = CreateArrayRndInt(6, 100, 200);
PrintArray(arr);
int sumevennumbersposition = SumEvenNumbersPosition(arr);
Console.WriteLine($"суммa элементов, стоящих на нечётных позициях = {sumevennumbersposition}");


















