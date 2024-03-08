// See https://aka.ms/new-console-template for more information

static double GetAverage(int[] arr)
{
    int suma = 0;
    foreach (var VARIABLE in arr)
    {
        suma += VARIABLE;
    }
    return (double)suma/arr.Length;
}

int[] arr = { 1,2,3,4 };
double avg = GetAverage(arr);
Console.WriteLine(avg);