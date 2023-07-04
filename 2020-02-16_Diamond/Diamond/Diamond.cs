using System;
using System.Collections.Generic;

namespace DiamondDemo
{
    public class Diamond
    {
        public string PrintDiamond1(string order)
        {
            if (order.Equals("A"))
            {
                return order;
            }
            return @"_A_
                     B_B
                     _A_";
        }

        public string PrintDiamond(string order)
        {
            if (order.Equals("A"))
            {
                return order;
            }
            return PrintUpper(order) + 
                   PrintMiddle(order) + 
                   PrintLower(order);
        }

        private string PrintLower(string order) => 
            throw new NotImplementedException();
        private string PrintMiddle(string order) => 
            throw new NotImplementedException();
        private string PrintUpper(string order) => 
            throw new NotImplementedException();
       
    }

    public string PrintFirstLine(string order)
    {
        if (order.Equals("A"))
        {
            return order;
        }
        return "_A_";
    }
}
}
