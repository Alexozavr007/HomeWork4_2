using HomeWork4_2_2;
using System.Diagnostics;

var myCollection = new BuyerCollection();
myCollection.Add("Коля", "садовий інвентар");
myCollection.Add("Коля", "садовий інвентар");
myCollection.Add("Коля", "компютер");
myCollection.Add("Вася", "садовий інвентар");

var test1Response = myCollection.GetBuyersByProduct("садовий інвентар");
Debug.Assert(
    test1Response.Count == 2 &&
    test1Response[0] == "Коля" &&
    test1Response[1] == "Вася",
    "Тест 1 не пройдено");

var test2Pesponse = myCollection.GetProductsByBuyer("Коля");
Debug.Assert(
    test2Pesponse.Count == 2 &&
    test2Pesponse[0] == "садовий інвентар" &&
    test2Pesponse[0] == "компютер",
     "Тест 1 не пройдено");