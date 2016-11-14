using System.Collections.Generic;
using LonghornMusic.Models;

namespace LonghornMusic.ViewModels {
    public class ShoppingCartViewModel {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}
