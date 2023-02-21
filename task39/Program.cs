// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
int[] array = GetArray(9, 0, 10);
Console.WriteLine(String.Join(" ", array));//простой быстрый вывод массива без красивого оформления
// ReversArray1(array);
// Console.WriteLine(String.Join(" ", array));
int[] reversArray = ReversArray2(array);
Console.WriteLine(String.Join(" ", reversArray));
//полезный общий и краткий метод по формированию рандомного массиваБс указанием всех порогов в 1 строке кода
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
void ReversArray1(int[] inArray)//перезапись имеющегося массива
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = k;
    }
}
int[] ReversArray2(int[] inArray)//создание нового "перевернутого" массива
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}





// int[] array = new int[5];
// bringArray(array);
// reverseArray(array);
// int[] bringArray(int[] anyArray)
// {
//     Console.Write("[");
//     for (int i = 0; i < anyArray.Length; i++)
//     {
//         anyArray[i] = new Random().Next(1, 8);
//         if (i < array.Length - 1) Console.Write($"{anyArray[i]}, ");
//         else if (i == array.Length - 1) Console.Write($"{anyArray[i]}]");
//     }
//     return anyArray;
// }
// int[] reverseArray(int[] someArray)
// {
//     Console.Write(" -> [");
//     for (int ind = 4; ind >= 0; ind--)
//     {
//         if (ind >= 1) Console.Write($"{someArray[ind]}, ");
//         else if (ind == 0) Console.Write($"{someArray[ind]}]");
//     }
//     return someArray;
// }