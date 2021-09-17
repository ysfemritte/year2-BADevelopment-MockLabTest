using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockLabTest
{
    class Inventory
    {
        //1. Create Instance Variable - IV (PRIVATE & LOWER CASE) --> Needs to be implemented in 3. Implemented Properties
        private int stockAvailable;
        private double wCost;
        private double rCost;

        //2. Auto-Implemented Properties --> No need to validate - String DType
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }


        //3. Implemented Properties
        public int StockAvailable
        {
            get
            {
                return stockAvailable;
            }
            set
            {
                if (value > 0)
                {
                    stockAvailable = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Stock Available", value, "should be greater than 0");
                }
            }
        }// end of stockAvailable

        public double WCost
        {
            get
            {
                return wCost;
            }
            set
            {
                if (value > 0.0)
                {
                    wCost = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("wCost", value, "should be greater than 0");
                }
            }
        }// end of WCost
        public double RCost
        {
            get
            {
                return rCost;
            }
            set
            {
                if (value > 0.0)
                {
                    rCost = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("rCost", value, "should be greater than 0");
                }
            }
        }// end of RCost

        //4. Parameterless Constructor

        //5. Parameterised Constructor
        public Inventory(string _itemCode, string _itemDescription, int _stockAvailable, double _wCost, double _rCost)
        {
            //Properties = Parameters
            ItemCode = _itemCode;
            ItemDescription = _itemDescription;
            StockAvailable = _stockAvailable;
            WCost = _wCost;
            RCost = _rCost;
        }

        //6. Methods
        /// <summary>
        /// Purpose: Calculates total sales amount for the quantity sold & Check if there is sufficient stock
        /// Argument: Quantity Sold
        /// </summary>
        /// <returns></returns>
        public int Sales(int quantity = 10)
        {
            
        }

        public int ReStock()
        {

        }

        public double TotalWcost()
        {
                                 
        }

        public double TotalRCost()
        {

        }
    }// end of Class
}
