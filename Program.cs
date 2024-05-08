// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


using System.ComponentModel.Design;

string[] sourceArray = {"Hello", "my", "solution", "is", "finally", "working", ":-)", "Send", "help","for", "an", "ant", "to", "croos", "the", "road", "Thank", "you" };
string[] newArray = FormNewArray(size:DecideSizeNewArray(sourceArray), sar:sourceArray);
PrintArray(sonar:sourceArray);
PrintArray(sonar:newArray);

//Расшифровка сокращений:
//sar - size of array
//sonar - size of new array
//SolAr - solution array

int DecideSizeNewArray(string[] sar)
{
    int length = 0;
    foreach (string element in sar)
        if (element.Length <= 3) length++;

    return length;
}

string[] FormNewArray(int size, string[] sar)
{
    int position = 0;
    string[] SolAr = new string[size];
    for (int i = 0; i < sar.Length; i++)
    {
        if (sar[i].Length <= 3)
        {
            SolAr[position] = sar[i];
            position++;
        }
    }

    return SolAr;
}

void PrintArray(string[] sonar)
{
    Console.Write("[");
    Console.Write(string.Join(", ", sonar));
    Console.WriteLine("]");
}