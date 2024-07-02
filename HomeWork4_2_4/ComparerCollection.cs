using System.Collections;
using System.Collections.Specialized;

namespace HomeWork4_2_4;

public class ComparerCollection : IComparer {
    private OrderedDictionary dct = new OrderedDictionary();

    public void Add(string key, int value) {
        dct.Add(key, value);
    }

    public int this[string carModel] { 
        get {
            return (int)dct[carModel];
        }
    }

    public int Compare(object? x, object? y) {
        var xValue = (int)dct[x];
        var yValue = (int)dct[y];

        return xValue.CompareTo(yValue);
    }

}
