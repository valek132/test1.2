Console.Clear();
Console.Write("Ввод ");
int n =Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"сумма : {CountEventNumbers(array)}");
void InputArray(int[] array)
{
    for ( int i = 0; i< array.Length; i++)
        array[i] = new Random() .Next(-100,100);
}
int CountEventNumbers(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
    sum = sum +array[i];
    return sum;
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"сумма : {CountEventNumbers(array)}");

