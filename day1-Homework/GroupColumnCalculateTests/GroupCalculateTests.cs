using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupColumnCalculate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpectedObjects;

namespace GroupColumnCalculate.Tests
{
    [TestClass()]
    public class GroupCalculateTests
    {
        [TestMethod()]
        public void Test_For_Cost_3Item_Subtotal()
        {
            //Arrange            
            List<Order> Orders = this.GetOrderContext();
            List<int> _expceted = new List<int>() { 6, 15, 24, 21 };
            GroupCalculate _target = new GroupCalculate();

            //Act                                
            List<int> _actual = _target.GroupColumnCalculate(Orders, 3, "Cost");

            //Assert
            _expceted.ToExpectedObject().ShouldEqual(_actual);
        }


        [TestMethod()]
        public void Test_For_Revenue_4Item_Subtotal()
        {
            //Arrange            
            List<Order> Orders = this.GetOrderContext();
            List<int> _expceted = new List<int>() { 50, 66, 60 };
            GroupCalculate _target = new GroupCalculate();

            //Act
            List<int> _actual = _target.GroupColumnCalculate(Orders, 4, "Revenue");

            //Assert
            _expceted.ToExpectedObject().ShouldEqual(_actual);
        }


        List<Order> GetOrderContext()
        {
            List<Order> orderContext = new List<Order>();

            orderContext.Add(new Order { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            orderContext.Add(new Order { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            orderContext.Add(new Order { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            orderContext.Add(new Order { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            orderContext.Add(new Order { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            orderContext.Add(new Order { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            orderContext.Add(new Order { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            orderContext.Add(new Order { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            orderContext.Add(new Order { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            orderContext.Add(new Order { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            orderContext.Add(new Order { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });
            return orderContext;
        }
    }
}
