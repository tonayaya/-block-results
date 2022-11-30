// Задача: Написать программу,
// которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 


string[] source = { "единицы", "десятки", "сотни", "тысячи", "1", ":-)", "New York", "-2", "Windows" };
void PrintArray(string[] m)
{
for (int x = 0; x < m.Length; x++)
Console.Write($"\"{m[x]}\" ");
Console.WriteLine();
}
string[] copyStringsBelowOrEqual3InNewArray(string[] strArray)
{
int k = 0;
for (int i = 0; i < strArray.Length; i++)
if (strArray[i].Length <= 3) k++;
string[] newArray = new string[k];
k = 0;
for (int i = 0; i < strArray.Length; i++)
if (strArray[i].Length <= 3) newArray[k++]=strArray[i];
return newArray;
}


Console.WriteLine("Программа создания нового массива и копирования в него строк длиной <=3");
Console.WriteLine("Исходный массив строк:");
PrintArray(source);

string[] target = copyStringsBelowOrEqual3InNewArray(source);

Console.WriteLine("Результирующий массив строк:");
PrintArray(target);
Console.WriteLine();