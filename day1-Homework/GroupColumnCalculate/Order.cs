using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupColumnCalculate
{
    public class Order
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _cost;
        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        private int _revenue;
        public int Revenue
        {
            get { return _revenue; }
            set { _revenue = value; }
        }

        private int _sellPrice;
        public int SellPrice
        {
            get { return _sellPrice; }
            set { _sellPrice = value; }
        }
    }
}
