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
        public void Test_For_Id_3Item_Subtotal()
        {
            //Arrange            
            List<Order> Orders = this.GetOrderContext();
            List<int> _expceted = new List<int>() { 6, 15, 24, 21 };
            GroupCalculate _target = new GroupCalculate(Orders, 3, "Id");

            //Act                                
            List<int> _actual = _target.GroupColumnCalculate();

            //Assert
            _expceted.ToExpectedObject().ShouldEqual(_actual);
        }


        [TestMethod()]
        public void Test_For_Revenue_4Item_Subtotal()
        {
            //Arrange            
            List<Order> Orders = this.GetOrderContext();
            List<int> _expceted = new List<int>() { 50, 66, 60 };

            GroupCalculate _target = new GroupCalculate(Orders, 4, "Revenue");

            //Act                                
            List<int> _actual = _target.GroupColumnCalculate();

            //Assert
            _expceted.ToExpectedObject().ShouldEqual(_actual);
        }

        List<Order> GetOrderContext()
        {
            List<Order> orderContext = new List<Order>();

            for (int _index = 1; _index <= 11; _index++)
            {
                orderContext.Add(new Order() { Id = _index, Cost = _index, Revenue = _index + 10, SellPrice = _index + 20 });
            }
            return orderContext;
        }
    }
}
