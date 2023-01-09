int a1 = 2;
int a2 = 3;
int a3 = 4;
int b1 = 5;
int b2 = 6;
int b3 = 7;
int c1 = 821;
int c2 = 9566;
int c3 = 10;
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
// Закомментированный код можно написать функцией в одну строчку (23).

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);