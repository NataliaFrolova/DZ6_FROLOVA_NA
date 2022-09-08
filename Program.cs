Start();

void Start()
{
    while (true)
    {
        Console.Write("Press enter: ");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("41) Задача 41: Пользователь вводит с клавиатуры M чисел." +
        "Посчитайте, сколько чисел больше 0 ввёл пользователь." +
        "0, 7, 8, -2, -2 -> 2                 1, -7, 567, 89, 223-> 3");
        Console.WriteLine("43) Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых," +
        "заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем." +
        "b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)");
        Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return;
            case 41: task41(); break;
            case 43: task43(); break;

            default: Console.WriteLine("error"); break;
        }
    }
}
//task41
void task41()
{
    Console.Write("Enter numbers separated by spaces: ");
    int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); //Приведенная строка помогает получить отдельные целые числа в строке, разделенные одним пробелом. Два или более пробелов между числами приведут к ошибке.
    //int[] array = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), (item) => Convert.ToInt32(item)); //этот вариант исправит ошибку и будет работать хорошо, даже если два или более пробелов между числами в строке
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"Element count > 0: [{String.Join(", ", array)}] -> {count}");
    return;
}

//task43

void task43()
{
    Console.Write("Enter b1: ");
    int b1 = int.Parse(Console.ReadLine());
    Console.Write("Enter k1: ");
    int k1 = int.Parse(Console.ReadLine());
    Console.Write("Enter b2: ");
    int b2 = int.Parse(Console.ReadLine());
    Console.Write("Enter k2: ");
    int k2 = int.Parse(Console.ReadLine());

    pointOfIntersection(b1, k1, b2, k2);

    void pointOfIntersection(double b1, double k1, double b2, double k2)
    {
        double[] point = new double[2];
        point[0] = (b2 - b1) / (k1 - k2);
        point[1] = k1 * point[0] + b1;

        if ((k1 * point[0] + b1) == (k2 * point[0] + b2))
        {
            Console.Write("Point of intersection: ");
            Console.WriteLine($"[{String.Join(", ", point)}]");
        }
        else
        {
            Console.WriteLine("There is no intersection.");
        }
    }
    return;
}

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}