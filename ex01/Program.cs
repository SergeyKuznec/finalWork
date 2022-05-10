
Console.WriteLine("Введите количество элементов массива");
int len = Convert.ToInt32(Console.ReadLine());


// ввод массива с клавиатуры

String[] CreateAndFillArray(int len)
{
    string[] array = new string[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}