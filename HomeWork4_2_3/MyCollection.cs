using System;
using System.Collections;
using System.Security.AccessControl;

namespace HomeWork4_2_3;

public class MyCollection : ICollection{
    private List<int> intList = new List<int>();
    private List<double> doubleList = new List<double>();

    private object _ = new object();

    public int Count => intList.Count;

    public bool IsSynchronized => false;

    public object SyncRoot => _;

    public void Add(int intNumber, double doubleNumber) {
        intList.Add(intNumber);
        doubleList.Add(doubleNumber);
    }

    public void CopyTo(Array array, int index) {
        intList.ToArray().CopyTo(array, index);
    }

    public IEnumerator GetEnumerator() {
        return intList.GetEnumerator();
    }

    public double this[int intNumber] {
        get {
            return doubleList[intList.IndexOf(intNumber)];
        }
    }

}
