#region Auto generated information. Please do not modify

// ShoppingCartWebApi ShoppingCartWebApi ShoppingCart.cs
// bila007 Bilangi, Vivek-Vardhan
// 2018-02-15 11:10 
// 2018-02-15 11:06 

#endregion

using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartWebApi.Models
{
    public class ShoppingCart
    {
        public ShoppingCart(IList<Item> itemList)
        {
            ItemList = itemList;
            ItemCount = itemList.Count;
            TotalValue = itemList.Sum(item => item.Value);
        }

        public IList<Item> ItemList { get; }
        public int ItemCount { get; }
        public decimal TotalValue { get; }
    }
}
