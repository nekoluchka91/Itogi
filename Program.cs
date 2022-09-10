// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, 
// длина которых меньше, либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] arrayFirst = { "Hello", "2", "world", ":-)" };
string[] arraySecond = new string[arrayFirst.Length]; 

void GetNewArray(string[] arrFirst, string[] arrSecond)
{
    int count = 0;
    for (int i = 0; i < arrFirst.Length; i++)
    {
        if (arrFirst[i].Length <= 3)
        {
        arrSecond[count] = arrFirst[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

GetNewArray(arrayFirst, arraySecond);
Console.WriteLine("Первый массив: ");
PrintArray(arrayFirst);
Console.WriteLine("Второй массив: ");
PrintArray(arraySecond);