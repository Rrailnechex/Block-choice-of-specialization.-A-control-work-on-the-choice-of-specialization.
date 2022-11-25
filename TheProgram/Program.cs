

/* 
Задача:

есть массив элементов

создать новый массив
положить в него строки из старого
    если их длинна не больше 3символа

использовать массивы
 */


void Print1DArray(string[] inputArray)
{
    Console.Write("[");
    for (int rows = 0; rows < inputArray.GetLength(0); rows++)
    {
        Console.Write($"{inputArray[rows]}, ");
    }
    Console.Write("]"); Console.WriteLine();
}

//string[] firstAr = { "hoTo-GVaisai", "t", "time is", "-rt", "walsho`a ri", "h562", "true", "rrava" };
//string[] firstAr = { "Guliuhwa", "hu LL45", "computer science", "-2y", "dz", "0tt", "watti", "r" };
string[] firstAr = { "1234", "1..", "computer science", "-2y", "eьжлропав", "0", "][", "rty" };
string[] newAr = new string[firstAr.GetLength(0)];
int maxL = 3;


//выбираем элементы
for (int i = 0; i < firstAr.GetLength(0); i++)
{
    if (firstAr[i].Length <= maxL)
    {
        newAr[i] = firstAr[i];
    }
}


//убираем из массива пустые элементы с помощю Linq 
newAr = newAr.Where(x => !string.IsNullOrEmpty(x)).ToArray();


Console.Write($"Изначальный массив = ");
Print1DArray(firstAr);
Console.Write($"Финальный массив = ");
Print1DArray(newAr);