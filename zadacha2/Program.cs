// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int FindSum(int numberA)
{
    int sum = 0;

    if (numberA > 0)
    {

        for (int remains = numberA; remains > 0; remains = remains / 10)
        {
            sum = sum + remains % 10;
        }

        Console.WriteLine($"сумма чисел = {sum}");
    }

    else // можно было обойтись без отрицательных значений дабы не усложнять, но в двнном варианте более универсальный метод получаеться
    {

        for (int remains = numberA; remains < 0; remains = remains / 10)
        {
            sum = sum + remains % 10;
        }

       Console.WriteLine($"сумма чисел = {sum}");
    }
    return sum;
}

Console.WriteLine("введите число number");

int numberA = int.Parse(Console.ReadLine());

int resalt = FindSum(numberA);
