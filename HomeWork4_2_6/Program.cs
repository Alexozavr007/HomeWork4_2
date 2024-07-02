var innerList = new SortedList<string, string>();
innerList.Add("aa", "1");
innerList.Add("bb", "2");
innerList.Add("zz", "3");
innerList.Add("yy", "4");

for (int i = 0; i < innerList.Count; i++) {
    string key = innerList.Keys[i];
    string value = innerList[key];
    Console.WriteLine($"{key} - {value}");
}

Console.WriteLine();
Console.WriteLine("=", 20);
Console.WriteLine();

for (int i = innerList.Count - 1; i >= 0; i--) {
    string key = innerList.Keys[i];
    string value = innerList[key];
    Console.WriteLine($"{key} - {value}");
}