using System.IO;
using System.Linq;

var list1 = new List<int>();
var list2 = new List<int>();

var filePath = "Day1Input.txt";

if (File.Exists(filePath))
{
    foreach (var line in File.ReadLines(filePath))
    {
        var locationIds = line.Split("   ");
        
        list1.Add(Convert.ToInt32(locationIds[0]));
        list2.Add(Convert.ToInt32(locationIds[1]));
    }
}
else
{
    Console.WriteLine("File not found: " + filePath);
}

list1.Sort();
list2.Sort();

var listDifference = 0;

if (list1.Count == list2.Count)
{
    for (var i = 0; i < list1.Count; i++)
    {
        listDifference += Math.Abs(list1[i] - list2[i]);
    }
}

Console.WriteLine(listDifference);