using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.GuardClauses;

namespace CleanCodeExamples
{
    public class DuplicateCode
    {
        public void MethodDuplicateCode(Cutomer customer, Order order, Logger logger)
        {
            Guard.Against.Null(order, nameof(order));

            if (customer == null)
            {
                throw new ArgumentException("Customer cannot be null");
            }
            if (order == null)
            {
                throw new ArgumentException("Order cannot be null");
            }
            if (logger == null)
            {
                throw new ArgumentException("Logger cannot be null");
            }
            // do actual work
        }
    }
}
