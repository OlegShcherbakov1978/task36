// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int sum = 0;

int SumOfOdd(int[] arr)
{
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] array = FillArrayWithRandomNumbers(9, -10, 11);

PrintArray(array);

SumOfOdd(array);

System.Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}.");


