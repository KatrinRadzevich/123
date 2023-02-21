// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write("Введите несколько целых чисел, чтобы программа посчитала,сколько из них положительных: ");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.Write(String.Join(", ", array));
Console.Write($" -> {GetRes(array)}");
int GetRes(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            num += 1;
        }
    }
    return num;
}