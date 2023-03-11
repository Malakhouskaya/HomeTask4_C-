// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*Вариант решения через цикл:
int Degrees(int number, int degree)
{
    int result = number;
    for(int i = 1; i < degree; i++)
    {
        result = result * number;
    }
    return result;
}

Console.WriteLine("Input the first number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number: ");
int degree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The result is: {Degrees(number, degree)}");


// Более эффективный вариант решения:
double Degrees(int number, int degree)
{
    double result = Math.Pow(number, degree);
    return result;
}

Console.WriteLine("Input the first number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number: ");
int degree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The result is: {Degrees(number, degree)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int number)
{
    int sum = 0;
    int num = Math.Abs(number);
    while(num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("The sum of numbers is " + Sum(number));




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Вариант 1: Автоматическое заполнение массива

int[] FillArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random ();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,10);
    }
    return array;
}


Console.WriteLine("Input the number of elements in the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
Console.WriteLine($"[{string.Join("," , array )}]");


//Вариант 2: Заполнение массива пользователем

int[] FillArray(int size)
{
    int[] array = new int[size];
        
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Input the element of the array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


Console.WriteLine("Input the number of elements in the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
Console.WriteLine($"[{string.Join("," , array )}]");