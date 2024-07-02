using System.Collections;
using System.Collections.Generic;

namespace HomeWork4_2_3;

public class MyCollection2 : ICollection{
    private List<objectForCollection2> innerList = new List<objectForCollection2>();

    private object _ = new object();

    public int Count => innerList.Count;

    public bool IsSynchronized => false;

    public object SyncRoot => _;

    public void Add(int intNumber, double doubleNumber) {
        var temp = new objectForCollection2();
        temp.IntNumber = intNumber;
        temp.DoubleNumber = doubleNumber;
        innerList.Add(temp);
    }

    public void CopyTo(Array array, int index) {
        innerList.ToArray().CopyTo(array, index);
    }

    public IEnumerator GetEnumerator() {
        return innerList.GetEnumerator();
    }

    public double this[int intNumber] {
        get {
            var res = innerList.Find(x => x.IntNumber == intNumber);
            return res.DoubleNumber;
        }
    }
}
