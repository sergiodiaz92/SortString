List<string> myStrings = new List<string>();
Console.Write("Number of strings: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.Write($"String #{i.ToString()}: ");
    string str = Console.ReadLine();
    myStrings.Add(str);
}
Console.WriteLine("List of Strings sorted: ");
SortString.Sort.sortStrings(n,myStrings);
