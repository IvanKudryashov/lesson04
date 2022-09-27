//Задача 25: Используя определение степени числа, напишите цикл,
//который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

void zadacha25()
{
     Console.WriteLine("Введите число A:");
     int a = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите число B:");
     int b = Convert.ToInt32(Console.ReadLine());
     int result = 1;
     for (int i = 0; i < b; i++)
     {
        result = result * a;
     }
     Console.WriteLine($"А в степени В равно: {result}");
}

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void zadacha27()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while (number > 9)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    sum = sum + number;
    Console.WriteLine($"Сумма цифр в числе: {sum}");
}

//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
//и выводит отсортированный по модулю массив.

void zadacha29()
{
    int size = 8;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    SortArray(array);
    PrintArray(array);
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-30,30);
    }  
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (Math.Abs(array[j]) < Math.Abs(array[min])) min = j;
        }
        int temp = array[i];
        array[i] = array[min];
        array[min] = temp;
    }
}

//zadacha25();
//zadacha27();
zadacha29();