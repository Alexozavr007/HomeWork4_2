using System.Collections;

namespace HomeWork4_2_2;

public class BuyerCollection : ICollection {

    private Dictionary<string, List<string>> productsByBuyer = new Dictionary<string, List<string>>();
    private Dictionary<string, List<string>> buyersByProduct = new Dictionary<string, List<string>>();

    private object _ = new object();

    public int Count => productsByBuyer.Count;

    public bool IsSynchronized => false;

    public object SyncRoot => _;

    public void Add(string buyer, string product) {
        if (productsByBuyer.ContainsKey(buyer)) {
            if (!productsByBuyer[buyer].Contains(product)) {
                productsByBuyer[buyer].Add(product);
            }
        }else {
            productsByBuyer.Add(buyer,new List<string> { product });
        }

        if (buyersByProduct.ContainsKey(product)) {
            if (!buyersByProduct[product].Contains(buyer)) {
                buyersByProduct[product].Add(buyer);
            }
        }else {
            buyersByProduct.Add(product,new List<string> { buyer});
        }
    }

    public List<string> GetProductsByBuyer(string buyer) {
        if (productsByBuyer.ContainsKey(buyer)) {
            return productsByBuyer[buyer];
        }
        else {
            throw new Exception("не знаю такого покупця");
        }
    }

    public List<string> GetBuyersByProduct(string product) {
        if (buyersByProduct.ContainsKey(product)) {
            return buyersByProduct[product];
        } else {
            throw new Exception("не знаю такого товару");
        }
    }

    public void CopyTo(Array array, int index) {
        productsByBuyer.Keys.ToArray().CopyTo(array, index);
    }

    public IEnumerator GetEnumerator() {
        return productsByBuyer.GetEnumerator();    
    }

}
