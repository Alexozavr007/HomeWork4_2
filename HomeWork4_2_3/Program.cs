using HomeWork4_2_3;
using System.Diagnostics;

var a = new MyCollection();
a.Add(1, 0.43);
a.Add(23, 43.32);
Debug.Assert(a[23] == 43.32, "Test 1 not passed (indexator usage)");
Debug.Assert(a.Count == 2, "Test 2 not passed (Count property usage)");

var b = new MyCollection2();
b.Add(1, 0.43);
b.Add(32, 123.321);
Debug.Assert(b[32] == 123.321, "Test 3 not passed (indexator usage)");
Debug.Assert(b.Count == 2, "Test 4 not passed (Count property usage)");