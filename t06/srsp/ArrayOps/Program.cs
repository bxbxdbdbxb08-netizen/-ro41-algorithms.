using System;

public static class ArrayOps
{
    // 1. Сумма элементов массива
    public static int Sum(int[] a)
    {
        if (a == null) throw new ArgumentNullException(nameof(a));
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        return sum;
    }

    // 2. Индекс первого минимального элемента
    public static int IndexOfMin(int[] a)
    {
        if (a == null || a.Length == 0) 
            throw new ArgumentException("Массив не должен быть пустым или null.");
        
        int minIndex = 0;
        int minVal = a[0]; // Начальное значение минимума из массива
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < minVal)
            {
                minVal = a[i];
                minIndex = i;
            }
        }
        return minIndex;
    }

    // 3. Количество элементов больше x
    public static int CountGreater(int[] a, int x)
    {
        if (a == null) throw new ArgumentNullException(nameof(a));
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > x)
            {
                count++;
            }
        }
        return count;
    }

    // 4. Разворот массива на месте
    public static void Reverse(int[] a)
    {
        if (a == null) throw new ArgumentNullException(nameof(a));
        int left = 0;
        int right = a.Length - 1;
        while (left < right)
        {
            int temp = a[left];
            a[left] = a[right];
            a[right] = temp;
            left++;
            right--;
        }
    }
}

class Program
{
    static void Main()
    {
        // Тестовые массивы по условию
        int[][] testArrays = new int[][]
        {
            new int[] { 4, 1, 7, 3, 9 },
            new int[] { 5 },
            new int[] { -2, -7, -4 },
            new int[] { 2, 2, 2 }
        };

        int x = 2;

        foreach (var original in testArrays)
        {
            // Создаем копию для вывода
            int[] arr = (int[])original.Clone();

            Console.WriteLine($"Исходный массив: {{ {string.Join(", ", arr)} }}");
            Console.WriteLine($"Сумма: {ArrayOps.Sum(arr)}");
            Console.WriteLine($"Индекс первого мин. элемента: {ArrayOps.IndexOfMin(arr)}");
            Console.WriteLine($"Количество элементов больше {x}: {ArrayOps.CountGreater(arr, x)}");

            ArrayOps.Reverse(arr);
            Console.WriteLine($"Массив после Reverse: {{ {string.Join(", ", arr)} }}");
            Console.WriteLine(new string('-', 40));
        }
    }
