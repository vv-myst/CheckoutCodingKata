#region Auto generated information. Please do not modify

// ShoppingCartWebApi ShoppingCartWebApi IShoppingCartController.cs
// bila007 Bilangi, Vivek-Vardhan
// 2018-02-15 11:00 
// 2018-02-15 10:57 

#endregion

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartWebApi.Models;

namespace ShoppingCartWebApi.Contracts
{
    public interface IShoppingCartController
    {
        Task<IActionResult> Post([FromBody] Item item, int itemId);
        Task<IActionResult> Put([FromQuery] int itemCount, int itemId);
        Task<IActionResult> Delete(int itemId);
    }
}
