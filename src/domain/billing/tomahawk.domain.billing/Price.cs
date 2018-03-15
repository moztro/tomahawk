using System;
using System.Collections.Generic;
using System.Text;
using tomahawk.domain.billing.Enums;

namespace tomahawk.domain.billing
{
    public class Price
    {
        public Price()
        {
            this.Currency = Currency.MXN;
        }

        public Guid Id { get; set; }

        public Currency Currency { get; set; }

        public double Amount { get; set; }
    }
}
