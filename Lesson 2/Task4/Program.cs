int n = 5;
int[] array = { 20, 5, 99, 1520, 43 };
int i = 0;
int max = 0;

while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine("Maximum is:");
Console.WriteLine(max);