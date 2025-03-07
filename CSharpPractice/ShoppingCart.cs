/* Strategy Pattern for Dynamic Discount Calculation
Implement different discount strategies (`NoDiscount`, `PercentageDiscount`, `FixedAmountDiscount`).
The `ShoppingCart` class should apply a strategy dynamically based on user input.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal totalAmount);
    }
    public class NoDiscount:IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount;
        }
    }
    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly decimal _percentage;
        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount - (totalAmount * _percentage / 100);
        }
    }
    public class FixedAmountDiscount : IDiscountStrategy
    {
        private readonly decimal _discountAmount;

        public FixedAmountDiscount(decimal discountAmount)
        {
            _discountAmount = discountAmount;
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount - _discountAmount;
        }
    }
    class ShoppingCart
    {
        private readonly List<decimal> _items;
        private IDiscountStrategy _discountStrategy;
        public ShoppingCart()
        {
            _items = new List<decimal>();
            _discountStrategy = new NoDiscount();
        }
        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }
        public void AddItem(decimal price)
        {
            _items.Add(price);
        }
        public decimal CalculateTotal()
        {
            decimal totalAmount = 0;
            foreach (var item in _items)
            {
                totalAmount += item;
            }
            return _discountStrategy.ApplyDiscount(totalAmount);
        }
    }
}
