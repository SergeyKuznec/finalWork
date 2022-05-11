
Console.WriteLine("Введите количество элементов массива");
int len = Convert.ToInt32(Console.ReadLine());


// ввод массива с клавиатуры

 String[] array = new String[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = Console.ReadLine(); 
    }
// Печать массива
 void PrintArray(string[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

// создание массива из валюдных элементов
String[] ValidArray(String[] array)
{
    int len = array.Length;
    int number = 0;
    for (int index = 0; index < len; index++)
    {
        if (array[index].Length <= 3)
        {
            number++;
        }
    }
    String[] arrayResult = new String[number];
    int i = 0; 
    for (int index = 0; index < len; index++)
    {
        if (array[index].Length <= 3)
        {
            arrayResult[i++] = array[index];
        }
    }
    return arrayResult;
}
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
String[] valid = ValidArray(array);
PrintArray(valid);