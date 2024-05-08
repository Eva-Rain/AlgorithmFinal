// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] sourceArray = {"Hello", "2", "world", ":-)" };
string[] newArray = FormNewArray(size:DecideSizeNewArray(sourceArray), sar:sourceArray);
PrintArray(sonar:sourceArray);
PrintArray(sonar:newArray);

//sar - size of array
//sonar - size of new array

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
    string[] threeArr = new string[size];
    for (int i = 0; i < sar.Length; i++)
    {
        if (sar[i].Length <= 3)
        {
            threeArr[position] = sar[i];
            position++;
        }
    }

    return threeArr;
}

void PrintArray(string[] sonar)
{
    Console.Write("[");
    Console.Write(string.Join(", ", sonar));
    Console.WriteLine("]");
}