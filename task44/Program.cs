// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Write("Введите число, чтобы увидеть числа фибоначи до вашего числа: ");
int[] fibonacciArray = new int[int.Parse(Console.ReadLine())];
fibonacciArray = GetFibonacciNums(fibonacciArray);
Console.Write($"Если N = {fibonacciArray.Length} -> {String.Join(" ", fibonacciArray)}");
int[] GetFibonacciNums(int[] array)
{
    array[0] = 0; array[1] = 1;
    for (int i = 2; i < array.Length; i++) array[i] = array[i - 1] + array[i - 2];
    return array;
}
