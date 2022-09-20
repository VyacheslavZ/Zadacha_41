int[] UserArray(int k)
{
    int[] array = new int[k];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите целое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PosCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

try
{
    Console.WriteLine("Введите кол-во проверяемых чисел: ");
    int k = Convert.ToInt32(Console.ReadLine());
    int result = PosCount(UserArray(k));
    Console.Write("Из Вашего списка " + result + " результат(а) больше 0");
}
catch
{
    Console.WriteLine("Введите корректные данные");
}