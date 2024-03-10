int n = 6;
int[] array = { 1, 8, 6, 7, 2, 10 };
int max = array[0];

for (int i = 0; i < n; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine(max);

max = array[0];
foreach(int e in array)
{
    if(e>max)
    {
        max = e;
    }
}
Console.WriteLine(max);


//запомнить
//обозначение различных переменных пишутся на английском, например
//int digit = 5; число
//int amount = 7; количество
//int average = 8; среднее