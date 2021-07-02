using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Models
{
   
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> shoppingCartItems { get; set; }
        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        //Access Session non controller class, This method is given to us all services
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            //we need Httpcontext Accesser availble for oour session: and question mark is null check
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            //??Ternnary operator if statement null check :while ? is a null check 
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString(); //CartId is a string in model

            session.SetString("CartId", cartId);
            return new ShoppingCart(context)
            {
                ShoppingCartId = cartId
            };
            
        }
        //I'am not surethis method
        public void AddToCart( Fruit fruit, int amount)

        {
            //Retirive shoppingCartItems 
            var shoppingCartItem = _appDbContext.shoppingCartItems.SingleOrDefault(
                s => s.Fruit.FruitId == fruit.FruitId && s.ShoppingCartId == ShoppingCartId);

            //And Creating the new one Here if that was null
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Fruit = fruit,
                    Amount = amount,
                    Price = fruit.Price // Den lägger kvitto  nuvårande price för product
                };
                //adding shoppingCart
                _appDbContext.shoppingCartItems.Add(shoppingCartItem);

            }
            //Increament fruit amount if user want more and  one
            else
            {
                shoppingCartItem.Amount++;

            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart( Fruit fruit)
        {
            var shoppingCartItem = _appDbContext.shoppingCartItems.SingleOrDefault(
              s => s.Fruit.FruitId == fruit.FruitId && s.ShoppingCartId == ShoppingCartId);
            var localamount = 0;
            if (shoppingCartItem !=null)
            {
                //Checking Amount of the Cart Greater then 1: and if is I need to Decrease
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localamount = shoppingCartItem.Amount;
                }
                else 
                {
                    _appDbContext.shoppingCartItems.Remove(shoppingCartItem);
                }
                }
            _appDbContext.SaveChanges();
            return localamount; 
        }
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            //check if it is null (if it is we return null )otherwise it is going shoppingCartItems and filter it
            //Include all the fruit and convert to List
            return shoppingCartItems ?? (shoppingCartItems = _appDbContext.shoppingCartItems.Where(c 
                => c.ShoppingCartId == ShoppingCartId)
                .Include(s => s.Fruit)
                .ToList());
              
        }
        public void ClearCart()
        {
            var cartItems = _appDbContext.shoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId);
            _appDbContext.shoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();

        } 
        public double GetshoppingCartTotal()
        {
            var Total = _appDbContext.shoppingCartItems.Where(c => ShoppingCartId == ShoppingCartId)
                .Select(c => c.Fruit.Price * c.Amount).Sum();
            return Total;
        }

    }
}
