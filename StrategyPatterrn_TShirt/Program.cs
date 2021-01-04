using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterrn_TShirt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int fabric, size, color, paymnetMethod;
            Menu menu = new Menu();

            while (true)
            {
                menu.FabricMenu();
                while (!(int.TryParse(Console.ReadLine(), out fabric) && (fabric >=1 && fabric <=7)))
                {
                    Console.WriteLine("Wrong choise!");
                    Console.WriteLine();
                    menu.FabricMenu();
                }

                Console.WriteLine();

                menu.ColorMenu();
                while (!(int.TryParse(Console.ReadLine(), out color) && (color >= 1 && color <= 7)))
                {
                    Console.WriteLine("Wrong choise!");
                    Console.WriteLine();
                    menu.ColorMenu();
                }

                Console.WriteLine(); 
                
                menu.SizeMenu();
                while (!(int.TryParse(Console.ReadLine(), out size) && (size >= 1 && size <= 7)))
                {
                    Console.WriteLine("Wrong choise!");
                    Console.WriteLine();
                    menu.SizeMenu();
                }

                Console.WriteLine();

                TShirt tshirt = new TShirt((Color)(color - 1), (Size)(size - 1), (Fabric)(fabric - 1));
                
                menu.PaymentMethodeMenu();
                while (!(int.TryParse(Console.ReadLine(), out paymnetMethod) && (paymnetMethod >= 1 && paymnetMethod <= 3)))
                {
                    Console.WriteLine("Wrong choise!");
                    Console.WriteLine();
                    menu.PaymentMethodeMenu();
                }

                Console.WriteLine();

                IPaymentStrategy paymentStrategy = null;

                switch (paymnetMethod)
                {
                    case 1:
                        paymentStrategy = new CretitCardPaymentStrategy();
                        break;
                    case 2:
                        paymentStrategy = new BankTransferPaymentStrategy();
                        break;
                    case 3:
                        paymentStrategy = new CashPaymentStrategy();
                        break;
                    
                }

                tshirt.SetPaymentsStrategy(paymentStrategy);
                tshirt.Pay();
                Console.WriteLine();
                Console.WriteLine("Do you want to buy another T-Shirt? (yes/no)");
                string answer = Console.ReadLine();
                if (!answer.Equals("yes"))
                {
                    break;
                }

                Console.WriteLine();

            }
        }
    }
}
