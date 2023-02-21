// Задача 45: Напишите программу, которая будет создавать копию заданного массива с
// помощью поэлементного копирования и перемножать эти массивы.
int[] array = { 1, 2, 3, 4, 5 };
Console.WriteLine(String.Join(" ", array));
int[] copyArray = new int[5];
copyArray = GetCopyArray(array);
Console.WriteLine(String.Join(" ", copyArray));
int[] multArray = new int[5];
multArray = GetMultArray(array, copyArray);
Console.WriteLine(String.Join(" ", multArray));
int[] GetCopyArray(int[] newArray)
{
    int[] someArray = new int[5];
    for (int i = 0; i < array.Length; i++) someArray[i] = newArray[i];
    return someArray;
}
int[] GetMultArray(int[] firstArray, int[] secondArray)
{
    int[] resArray = new int[5];
    for (int i = 0; i < array.Length; i++) resArray[i] = firstArray[i] * secondArray[i];
    return resArray;
}