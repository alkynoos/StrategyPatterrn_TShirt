using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterrn_TShirt
{
    class TShirt
    {
        #region Private fields

        private IPaymentStrategy _paymentStrategy;

        #endregion

        #region Public Properties
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }

        #endregion

        public void SetPaymentsStrategy(IPaymentStrategy paymentStrategy)
        {
            if (paymentStrategy == null)
            {
                throw new ArgumentNullException(nameof(paymentStrategy));
            }
            _paymentStrategy = paymentStrategy;
        }

        public void Pay()
        {
            _paymentStrategy.DoPayment(this);
        }

        #region Constructors

        public TShirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }

        public TShirt(Color color, Size size, Fabric fabric, IPaymentStrategy paymentStrategy): this(color, size, fabric)
        {
            if (paymentStrategy == null)
            {
                throw new ArgumentNullException(nameof(paymentStrategy));
            }
            _paymentStrategy = paymentStrategy;
        }

        #endregion
    }
}
