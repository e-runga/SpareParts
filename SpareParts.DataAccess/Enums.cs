using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpareParts.DataAccess
{
    public class Enums
    {
        public enum CustomerType
        {
            Mecanic = 1,
            Individual = 2
        };

        public enum ProfileType
        {
            Administrator = 1,
            Operator = 2
        };

        public enum ProductStatus
        {
            New = 1,
            Bought = 2,
            Sold = 3,
            Complained = 4,
            Returned = 5,
            Replaced = 6,
            Requested = 7,
            Ordered = 8
        };
    }
}
