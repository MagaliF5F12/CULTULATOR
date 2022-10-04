int tip = 0;
double a, l;
while (tip != 9)
{
    Console.Write("Операция (9 для выхода в жизнь): ");
    tip = Convert.ToInt32(Console.ReadLine());
    if (tip == 1)
    {
        Console.WriteLine("Ввод 1 числа: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ввод 2 числа: ");
        l = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a + l);
    }
    else if (tip == 2)
    {
        Console.WriteLine("Ввод 1 числа: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ввод 2 числа: ");
        l = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a - l);
    }
    else if (tip == 3)
    {
        Console.WriteLine("Ввод 1 числа: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ввод 2 числа: ");
        l = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a * l);
    }
    else if (tip == 4)
    {
        Console.WriteLine("Ввод 1 числа: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ввод 2 числа: ");
        l = Convert.ToDouble(Console.ReadLine());
        if (l != 0)
        {
            Console.WriteLine(a * l);
        }
        else
        {
            Console.WriteLine("Деление на нуль");
        }
    }
    else if (tip == 5)
    {
        Console.WriteLine("Ввод 1 числа: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ввод 2 числа: ");
        l = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Math.Pow(a, l));
    }
    else if (tip == 6)
    {
        Console.WriteLine("Ввод числа: ");
        a = Convert.ToDouble(Console.ReadLine());
        if (a >= 0)
            Console.WriteLine(Math.Sqrt(a));
        else
            Console.WriteLine("Корень");
    }
    else if (tip == 7)
    {
        Console.WriteLine("Ввод 1 числа: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a / 100);
    }
    else if (tip == 8)
    {
        Console.WriteLine("Ввод 1 числа: ");
        a = Convert.ToDouble(Console.ReadLine());
        if (a < 0)
            Console.WriteLine("Факториал");
        else
        {
            for (int i = Convert.ToInt32(a) - 1; i > 1; i--)
            {
                a *= i;
            }
            Console.WriteLine(a);
        }
    }
}
