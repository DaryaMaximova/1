﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []


/*string[] AddNewValueToArray(string[] arr, string newRow)
{
    string[] newArr = new string[arr.Length + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    newArr[newArr.Length - 1] = newRow;
    return newArr;
}

string[] CreateArray()
{
    string[] arr = new string[0];
    while (true)
    {
        Console.Write("Введите строку. После завершения ввода нажмите e : ");
        string N = Console.ReadLine()!;
        if (N == "e" || N == "E") break;
        else arr = AddNewValueToArray(arr, newRow: N);
    }
    return arr;
}



string[] PrintArray(string [] arr, int  size = 0, int index = 0)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) size++;
    }
    string[] newArr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[index] = arr[i];
            index++;
        }
    }
    return newArr;
}

string[] initialData = CreateArray();
Console.WriteLine();
Console.WriteLine("[{0}]" , string.Join(", ", initialData));
Console.WriteLine();
string[] newData = PrintArray(arr: initialData);
Console.WriteLine("[{0}] ", string.Join(", ", newData));*/

string[] arr1 = new string[3] {"Rus", ":-)", "Kaz"};
string[] arr2 = new string[arr1.Length];
void NewArr(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3) arr2[count] = arr1[i]; count++;    
    }
}
void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
NewArr(arr1, arr2);
PrintArr(arr2);