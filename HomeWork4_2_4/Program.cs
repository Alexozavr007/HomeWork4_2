using HomeWork4_2_4;
using System.Diagnostics;

var collection = new ComparerCollection();

collection.Add("Mazda", 2007);
collection.Add("BMW", 2014);
collection.Add("Reno", 2020);
collection.Add("Audi", 2007);

Console.WriteLine($"Compare result [Mazda year {collection["Mazda"]}] to [Reno year {collection["Reno"]}]: {collection.Compare("Mazda", "Reno")}");

Debug.Assert(collection.Compare("Mazda", "Reno") == -1, "Test 1 not passed (comparer failed)");
Debug.Assert(collection.Compare("Reno", "Mazda") == 1, "Test 2 not passed (comparer failed)");
Debug.Assert(collection.Compare("Audi", "Mazda") == 0, "Test 3 not passed (comparer failed)");