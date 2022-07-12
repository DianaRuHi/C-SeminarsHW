/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int[] InputNumbers(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        Console.Write($"Число {i + 1} = ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int NumberOfPositive(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result++;
    }
    return result;
}

Console.WriteLine("Сколько чисел вы хотите ввести?");
int num = int.Parse(Console.ReadLine());
int[] array = InputNumbers(num);
int pos = NumberOfPositive(array);
Console.WriteLine($"Количество введенных вами положительных чисел равно {pos}");
