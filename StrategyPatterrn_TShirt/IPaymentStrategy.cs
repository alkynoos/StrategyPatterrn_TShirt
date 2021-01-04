using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterrn_TShirt
{
    interface IPaymentStrategy
    {
        void DoPayment(TShirt tshirt);
    }
}
