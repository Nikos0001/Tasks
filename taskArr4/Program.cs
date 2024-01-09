int n = 5;
int[] array = { 112, 4, 77, 3, 9 };
int i = 0;
int max = array[0];
while (i<n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);