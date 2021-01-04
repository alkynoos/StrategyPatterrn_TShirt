using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterrn_TShirt
{
    class CashPaymentStrategy : IPaymentStrategy
    {
        public void DoPayment(TShirt tshirt)
        {
            decimal basePrice = 0.0m;

            switch (tshirt.Fabric)
            {
                case Fabric.WOOL:
                    //break;
                case Fabric.COTTON:
                    basePrice = 20.0m;
                    break;
                case Fabric.POLYESTER:
                    //break;
                case Fabric.RAYOL:
                    basePrice = 15.0m;
                    break;
                case Fabric.LINEN:
                    //break;
                case Fabric.CASHMERE:
                    //break;
                case Fabric.SILK:
                    basePrice = 30.0m;
                    break;                    
            }

            switch (tshirt.Size)
            {
                //case Size.XS:
                //    break;
                //case Size.S:
                //    break;
                //case Size.M:
                //    break;

                //this price changes only for these size
                case Size.L:
                //break;
                case Size.XL:
                //break;
                case Size.XXL:
                //break;
                case Size.XXXL:
                    basePrice += basePrice * 0.05m;
                    break;
            }

            //The price is the same for all colors
            Console.WriteLine($"The price of your T-Shirt is: {basePrice: 0.##}\u20AC");
        }
    }
}
