//TAPSIRIQ 1
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
//TAPSIRIQ 2
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
//TAPSIRIQ 3
#region
int num1 = 17;
if (num1 == 0 || num1 == 1)
{
    Console.WriteLine(num1 + " ne sade ne de murekkeb ededdir");
}
else
{
    for (int a = 2; a <= num1 / 2; a++)
    {
        if (num1 % a == 0)
       {
            Console.WriteLine(num1 + " murekkeb ededdir");

      }

   }
Console.WriteLine(num1 + " sade ededdir");
}
#endregion