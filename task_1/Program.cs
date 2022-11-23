string[] StringModification(string[] stringOriginal)
{
    int lenArray = 0;
    for (int i = 0; i < stringOriginal.Length; i++)
    {
        if (stringOriginal[i].Length <= 3)
        {
            lenArray++;
        }
    }
    string[] stringModified = new string[lenArray];
    if (lenArray > 0)
        lenArray = 0;
    {
        for (int i = 0; i < stringOriginal.Length; i++)
        {
            if (stringOriginal[i].Length <= 3)
            {
                stringModified[lenArray] = stringOriginal[i];
                lenArray++;
            }
        }
    }
    return stringModified;
}

void StringOutput(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine(stringArray[i]);
    }
    Console.WriteLine("---------------");
}

string[] arrayExampleFirst = new string[] { "hello", "2", "world", ":-)" };
string[] arrayExampleSecond = new string[] { "1234", "1567", "-2", "computur science" };
string[] arrayExampleThird = new string[] { "russia", "denmark", "kazan", "3" };


//string[] stringModified = StringModification(arrayExampleFirst);
StringOutput(StringModification(arrayExampleFirst));
StringOutput(StringModification(arrayExampleSecond));
StringOutput(StringModification(arrayExampleThird));
