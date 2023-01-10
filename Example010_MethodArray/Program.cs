int[] array = { 21, 32, 34, 45, 89, 65, 67, 87, 89 };
int n = array.Length;
int find = 89;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}