// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] array = new int[4];
fillArray(array);
printArray(array);
Console.WriteLine($" -> {getResult(array)}");
int[] fillArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++) Array[i] = new Random().Next(-99, 100);
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
    for (int index = 1; index < newArray.Length; index += 2) result += newArray[index];
    return result;
}