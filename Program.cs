
#region
//int pow=0;
//for (int i = 19; i >= 1; i/=2)
//    if (i>1)
//    {
//        pow++;
//    }
//{
//    Console.WriteLine(pow);
//}
#endregion

#region
//{
//    int n = 128790903;
//    int m = 0;
//    int sum = 0;
//    while (n > 0)
//    {
//        m = n % 10;
//        sum = sum + m;
//        n = n / 10;
//    }
//    Console.WriteLine(sum);
//}
#endregion

#region
int num = 17;
if (num == 0 || num == 1)
{
    Console.WriteLine(num + " ne sade ne de murekkeb ededdir");
}
else
{
    for (int a = 2; a <= num / 2; a++)
    {
        if (num % a == 0)
        {
            Console.WriteLine(num + " murekkeb ededdir");

        }

    }
    Console.WriteLine(num + " sade ededdir");
}
#endregion