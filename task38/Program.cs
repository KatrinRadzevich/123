// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] array = new double[5];
fillArray(array);
printArray(array);
Console.WriteLine($" -> {getResult(array)}");
double[] fillArray(double[] Array)
{
    for (int i = 0; i < Array.Length; i++) Array[i] = new Random().Next(0, 100);
    return Array;
}
void printArray(double[] printedArray)
{
    Console.Write("[");
    for (int ind = 0; ind <= printedArray.Length - 1; ind++)
    {
        if (ind < printedArray.Length - 1) Console.Write($"{printedArray[ind]}, ");
        else if (ind == printedArray.Length - 1) Console.Write($"{printedArray[ind]}]");
    }
}
double getResult(double[] newArray)
{
    double maxValue = newArray[0];
    double minValue = newArray[0];
    double result = 0;
    for (int index = 1; index < newArray.Length; index++)
    {
        if (maxValue < newArray[index]) maxValue = newArray[index];
        else if (minValue > newArray[index]) minValue = newArray[index];
        result = maxValue - minValue;
    }
    return result;
}