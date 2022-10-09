Console.Clear();
 
int numberCount = Convert.ToInt32(Console.ReadLine()!);
int[] numberArray = new int[numberCount];
 
for (int i = 0; i < numberArray.Length; i++)
{
    numberArray[i] = Convert.ToInt32(Console.ReadLine()!);
}
 
Console.WriteLine(CountPositiveNumbers(numberArray));
 
 
int CountPositiveNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}