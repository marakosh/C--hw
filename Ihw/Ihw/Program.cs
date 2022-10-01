
using Ihw;

MyArr myarr = new MyArr(1, 43, 5, 6, 4, 3, 4, 3, 4, 4, 75, 1, 1, 2, 4, 3);
myarr.Add(1, new int[] { 1, 2, 4, 5 });
myarr.SortShell();
for (int i = 0; i < myarr.Length; i++)
{
    Console.Write($"{myarr[i]} ");
}
Console.WriteLine($"\n{myarr.CountDistinct()}");