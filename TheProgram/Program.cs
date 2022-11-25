

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


string[] firstAr = { "1234", "1567", "computer science", "-2y", "eьжлропав", "0", "][" };
string[] midAr = new string[firstAr.GetLength(0)];
int newL = 0;
int maxL = 3;


//узнаём длинну нового массива и выбираем элементы
for (int i = 0; i < firstAr.GetLength(0); i++)
{
    Console.WriteLine($"//for1 = {i}");
    if (firstAr[i].Length <= maxL)
    {
        newL++;
        midAr[i] = firstAr[i];
        Console.WriteLine($"//midAr[i] = {midAr[i]}; i = {i}");
    }
}
Console.WriteLine($"//длинна узнана = {newL}");
Console.Write($"//Print1DArray midAr = ");
Print1DArray(midAr);


string[] newAr = new string[newL];
int iofNewAr = 0;

//добавляем в новый массив строки
for (int i = 0; i < newL; i++)
{
    Console.WriteLine($"//for2 = {i}");
    if (firstAr[i].Length <= maxL)
    {
        newAr[iofNewAr] = firstAr[i];
        Console.WriteLine($"//цикл добавления = {i}; newAr[iofNewAr] = {newAr[iofNewAr]}; firstAr[i] = {firstAr[i]}");
        iofNewAr++;
    }
}


Console.Write($"Изначальный массив = ");
Print1DArray(firstAr);
Console.Write($"Финальный массив = ");
Print1DArray(newAr);

midAr = midAr.Where(x => !string.IsNullOrEmpty(x)).ToArray();
Console.Write($"midAr массив = ");
Print1DArray(midAr);