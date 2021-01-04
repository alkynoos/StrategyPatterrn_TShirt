﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterrn_TShirt
{
    class CretitCardPaymentStrategy : IPaymentStrategy
    {
        public void DoPayment(TShirt tshirt)
        {
            decimal basePrice = 0.0m;

            switch (tshirt.Fabric)
            {
                case Fabric.WOOL:
                case Fabric.COTTON:
                    basePrice = 30.0m;
                    break;
                case Fabric.POLYESTER:
                case Fabric.RAYOL:
                    basePrice = 25.0m;
                    break;
                case Fabric.LINEN:
                case Fabric.CASHMERE:
                case Fabric.SILK:
                    basePrice = 40.0m;
                    break;
            }

            switch (tshirt.Size)
            {
                //this price changes only for these size
                case Size.L:
                case Size.XL:
                case Size.XXL:
                case Size.XXXL:
                    basePrice += basePrice * 0.10m;
                    break;
            }

            switch (tshirt.Color)
            {
                //the price changes only for these colors
                case Color.INDIGO:
                case Color.VIOLET:
                    basePrice += basePrice * 0.05m;
                    break;

            }

            //The price is the same for all colors
            Console.WriteLine($"The price of your T-Shirt is: {basePrice: 0.##}\u20AC");// Euro sign
        }
    }
}
