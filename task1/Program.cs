string[] array = {"Hello", "2", "world", ":-)"};
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}
void Elements(string[] arr1)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        string line = arr1[i];
        if (line.Length < 4)
        {
            System.Console.Write(arr1[i] + " ");
            count++;
        }
    }
    if (count == 0)
    {
        System.Console.WriteLine("Нет строк, длина которых меньше или равна трём символам");
    }
}
PrintArray(array);
System.Console.WriteLine();
Elements(array);