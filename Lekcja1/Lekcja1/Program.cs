﻿// See https://aka.ms/new-console-template for more information

static double GetAverage(int[] arr)
{
    int suma = 0;
    foreach (var VARIABLE in arr)
    {
        suma += VARIABLE;
    }
    return (double)suma/arr.Length;
}

int[] arr = { 5,7,44,435,59043 };
//double avg = GetAverage(arr);
//Console.WriteLine(avg);


static int GetMax(int[] arr)
{
    int maks = arr[0];
    foreach (var elem in arr)
    {
        if (elem > maks) maks = elem;
    }
    return maks;
}

int max = GetMax(arr);
Console.WriteLine(max);
