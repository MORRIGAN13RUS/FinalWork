Console.Write("Введите текстовую строку: ");

string str = Console.ReadLine();

string[] strArr = str.Split(" ");
PrintArr(strArr);

int count = 0;
GetShortStringCount();
string[] shortStrArr = GetShortStrArr(strArr, count);
PrintArr(shortStrArr);

string[] GetShortStrArr(string[] arr, int leng)
{
    int j = 0;
    string[] resArr = new String[leng];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            resArr[j] = arr[i];
            j++;
        }
    }
    return resArr;
}

void GetShortStringCount()
{
    for (int i = 0; i < strArr.Length; i++)
    {
        if (strArr[i].Length <= 3)
        {
            count++;
        }
    }
}

void PrintArr(String[] arr)
{
    Console.Write($"[{arr[0]}");
    for(int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");        
    }
    Console.WriteLine("]");
}