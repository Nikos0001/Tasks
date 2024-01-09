//int n = 10;
int[] array = { 2, 14, 9, 32, 31, 8, 5, 22, 39, 43 };
//int[] array = {1,3,7,9,33,97,53,11,77,33};  // Все нечетные.
//int[] array = {2,22,44,42,32,64,60,20,8,6}; // Все четные.
int i = 0;
//while (i < n)
while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]},");
    }
    i = i + 1;
}
