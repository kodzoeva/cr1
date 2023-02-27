// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых <= 3.

string PromtString(string? msg)
{
    System.Console.Write(msg + "-> ");
    return Console.ReadLine();
}

int PromtInt(string? msg)
{
    System.Console.Write(msg + "-> ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
}

string[] FillArray(string[] array)
{
    int i = 0;
    int num = 1;
    for (int x = 0; x < array.Length; x++)
    {
        array[i] = PromtString($"Введите фразу номер {num}");
        i++;
        num++;
    }
    return array;
}

int SizeNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] TransformArray(string[] array)
{
    int count = SizeNewArray(array);
    if (count == 0)
    {
        System.Console.WriteLine("Нет подходящих по условию фраз.");
        Environment.Exit(0);
    }
    string[] newArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

int num = PromtInt("Сколько фраз вы хотите проверить?");
string[] array = new string[num];
array = FillArray(array);
string[] newArray = TransformArray(array);
System.Console.WriteLine("Из введенных фраз:");
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Условию задачи (длина фразы <= 3) подходят только:");
PrintArray(newArray);
