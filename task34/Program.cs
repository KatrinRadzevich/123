// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] array = new int[4];
fillArray(array);
printArray(array);
Console.WriteLine($" -> {getResult(array)}");
int[] fillArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++) Array[i] = new Random().Next(100, 1000);
    return Array;
}
void printArray(int[] printedArray)
{
    Console.Write("[");
    for (int ind = 0; ind <= printedArray.Length - 1; ind++)
    {
        if (ind < printedArray.Length - 1) Console.Write($"{printedArray[ind]}, ");
        else if (ind == printedArray.Length - 1) Console.Write($"{printedArray[ind]}]");
    }
}
int getResult(int[] newArray)
{
    int result = 0;
    for (int index = 0; index < newArray.Length; index++)
    {
        if (newArray[index] % 2 == 0) result += 1;
    }
    return result;
}