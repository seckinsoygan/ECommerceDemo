using Newtonsoft.Json;

namespace ECommerceDemo.API.Models.ShoppingTools
{
    [Serializable]
    public class Cart
    {
        [JsonProperty("myCart")]
        Dictionary<int, CartItem> myCart;
        public Cart()
        {
            myCart = new Dictionary<int, CartItem>();
        }
        [JsonProperty("MyCart")]
        public List<CartItem> MyCart
        {
            get
            {
                return myCart.Values.ToList();
            }
        }
        public void AddToCart(CartItem cartItem)
        {
            if (myCart.ContainsKey(cartItem.Id))
            {
                myCart[cartItem.Id].Amount++;
                return;
            }
            myCart.Add(cartItem.Id, cartItem);
        }
        public void RemoveFromCart(int id)
        {
            if (myCart[id].Amount > 1)
            {
                myCart[id].Amount--;
                return;
            }
            myCart.Remove(id);
        }
        public decimal? TotalPrice
        {
            get
            {
                return myCart.Sum(x => x.Value.SubTotal);
            }
        }
    }
}
