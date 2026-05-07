int[] num = { 5, 1, 23, 5, 1 };

for (int a = 0; a < num.Length - 1; a++)
{
  for (int b = a + 1; b < num.Length; b++)
  {
    if (num[b] < num[a])
    {
      int temp = num[a];
      num[a] = num[b];
      num[b] = temp;
    }
  }
}
int x = 0;
foreach (int a in num)
{
  Console.WriteLine(num[x]);
  x++;
}