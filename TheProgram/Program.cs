

/* 
Задача:

есть массив элементов

создать новый массив
положить в него строки из старого
    если их длинна больше 3символа

использовать массивы
 */



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

int[] newAr = new int[firstAr.GetLength(0)];