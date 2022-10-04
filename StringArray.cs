void StringArray()
{
    Console.Write("Введите строки через пробел: ");
    string input = Console.ReadLine();
    var arrayOld = input.Split(" ");

    string[] arrayNew = new string[arrayOld.Length];
    int count = 0;

    for (int i = 0; i < arrayOld.Length; i++)
    {
        if (arrayOld[i].Length <= 3)
        {
            count++;
            arrayNew[count - 1] = arrayOld[i];
        }
    }

    Array.Resize(ref arrayNew, count);

    Console.WriteLine($"[{(String.Join(", ", arrayOld))}] --> [{(String.Join(", ", arrayNew))}]");
}
StringArray();
