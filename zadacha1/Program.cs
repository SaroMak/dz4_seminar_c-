// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int FindDegree(int numberA, int numberB, int multiPlay) // написали функцию для возведения в степень одного число в другое, отсекая число 0
{
    if (numberB == 0)

        Console.WriteLine($"число {numberA} возведенное в натуралбную степень {numberB} равно  0 ");
    else
    {

        for (int i = 1; i < numberB; i++)
        {
            multiPlay = multiPlay * numberA;
        }
        Console.WriteLine($"число {numberA} возведенное в натуралбную степень {numberB} равно  {multiPlay}");
    }
    return multiPlay;
}
Console.WriteLine("введите число numberA");

int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("введите  положительное число numberB");

int numberB = int.Parse(Console.ReadLine());
int multiPlay = numberA;

int pow = FindDegree(numberA, numberB, multiPlay);