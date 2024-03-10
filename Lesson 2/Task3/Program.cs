int n = 10;
int[] array = { 9, 8, 5, 2, 4, 3, 5, 7, 3, 10 };
int i = 0;

while (i < n)
{
    if (array[i] % 2 == 0)
    {
        Console.WriteLine($"{array[i]} ");
    }
    i = i + 1;
}