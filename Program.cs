//Задайте массив вещественных чисел. Найдите разницу между
//максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Введите кол-во элементов массива N ");
Console.Write(" N = ");
int n = Convert.ToInt32(Console.ReadLine());

double[] num = SetArrayRealNumbers(n);

double min = num[0];
double max = num[0];

for (int i = 0; i < n; i++)
{
    if (num[i] >= max)
    {
        max = num[i];
    }
    else if (num[i] <= min)
    {
        min = num[i];
    }
}
double[] SetArrayRealNumbers(int n)
{
    double[] num = new double[n];

    for (int i = 0; i < n; i++)
    {
        num[i] = new Random().Next(100, 1000) + new Random().NextDouble();

        num[i] = Math.Round(num[i], 2);
    }
    return num;
}

Console.Write(String.Join("; ", num));

Console.WriteLine();
Console.WriteLine("Максимальное значение элемента: "+max);
Console.WriteLine("Минимальное  значение элемента: "+min);

Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементом: "+Math.Round((max - min), 2));
