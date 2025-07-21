int Count = Convert.ToInt32(Console.ReadLine());
int IsSimple = 0;   
while (Count > 0)
{
    IsSimple++;
    if (IsSimple <= 3)
    {
        Console.WriteLine(IsSimple);
        Count--;
        continue;
    }
    bool Check = true;
    for (int i = 2; i <= double.Sqrt(IsSimple); i++)
    {
        if (IsSimple % i == 0)
        {
            Check = false;
            break;
        }
    }
    if (Check)
    {
        Console.WriteLine(IsSimple);
        Count--;
    }
}