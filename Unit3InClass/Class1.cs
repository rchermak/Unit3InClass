using System;
using System.Collections.Generic;
using System.Text;

namespace Unit3InClass
{
    class Class1
    {
        DateTime saleTime;
        float amount;

        public Class1(float amount)
        {
            this.amount = amount;
        }

        public DateTime SaleTime { get => saleTime; set => saleTime = value; }
    }
}
