

/* 
Задача:

есть массив элементов

создать новый массив
положить в него строки из старого
    если их длинна больше 3символа

использовать массивы
 */

void Print1DArray(string[] inputArray)
{
    Console.Write("[");
    for (int rows = 0; rows < inputArray.GetLength(0); rows++)
    {
        Console.Write($"{inputArray[rows]}, ");
    }
    Console.Write("]");
}






string[] firstAr = { "1234", "1567", "computer science", "-2", "e" };
int newL = 0;
int maxL = 2;

for (int i = 0; i < firstAr.GetLength(0); i++)
{
    Console.WriteLine($"{i} -> цикл");
    if (firstAr[i].Length <= maxL)
    {
        newL++;
        Console.WriteLine($"{newL} -> newL newL newL newL");
        Console.WriteLine($"{firstAr[i].Length} -> firstAr[i].Length");
    }
}

Console.WriteLine($"{newL} -> ------------------- дальше");

string[] newAr = new string[newL];

for (int i = 0; i < newAr.GetLength(0); i++)
{
    if (firstAr[i].Length <= maxL)
    {
        newL++;
        Console.WriteLine($"{newL} -> newL newL newL newL");
        Console.WriteLine($"{firstAr[i].Length} -> firstAr[i].Length");
        newAr[i] = firstAr[i];

    }
}

Console.WriteLine($" -> ------------------- конец");

Console.Write($"Изначальный массив = ");
Print1DArray(firstAr);
Console.WriteLine();
Console.Write($"Финальный массив = ");
Print1DArray(newAr);