

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


string[] firstAr = { "1234", "1567", "computer science", "-2", "eьжлропав", "0", "][" };
string[] midAr = new string[firstAr.GetLength(0)];
int newL = 0;
int maxL = 2;


//узнаём длинну нового массива и выбираем элементы
for (int i = 0; i < firstAr.GetLength(0); i++)
{
    Console.WriteLine($"for = {i}");
    if (firstAr[i].Length <= maxL)
    {
        newL++;
        midAr[i] = firstAr[i];
        Console.WriteLine($"midAr[i] = {midAr[i]}; i = {i}");
    }
}
Console.WriteLine($"длинна узнана = {newL}");


//добавляем в новый массив строки
string[] newAr = new string[newL];

for (int i = 0; i < newAr.GetLength(0); i++)
{
    if (firstAr[i].Length <= maxL)
    {
        newAr[i] = firstAr[i];
        Console.WriteLine($"цикл добавления = {i}");
    }
}


Console.Write($"Изначальный массив = ");
Print1DArray(firstAr);
Console.WriteLine();
Console.Write($"Финальный массив = ");
Print1DArray(newAr);