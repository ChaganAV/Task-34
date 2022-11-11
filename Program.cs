int size = 15;
int[] arrNum = new int[size];
int min = 100;
int max = 1000;
int countPositive = 0;
Random rnd = new Random();
for (int i = 0; i < arrNum.Length; i++)
{
    arrNum[i] = rnd.Next(min,max);
}
PrintArray(arrNum);

for(int i = 0; i < arrNum.Length; i++)
{
    if(arrNum[i]%2 == 0)
        countPositive++;
}
Console.WriteLine($"Количество четных чисел {countPositive}");

// Functions
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
