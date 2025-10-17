using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignEight
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount() : base("Buy One Get One Discount") { }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity > 1)
            {
                return (price / 2) * (quantity / 2);
            }
            return 0;
        }
    }
}
