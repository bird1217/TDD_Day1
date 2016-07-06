using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupColumnCalculate
{
    public class GroupCalculate
    {
        public List<int> GroupColumnCalculate(List<Order> orderDts, int groupCount, string groupCoulumnName)
        {
            List<int> Subtotal = new List<int>();
            int dataIndex = 0;
            var splitOrder = orderDts.Skip(dataIndex * groupCount).Take(groupCount).ToList();

            while (splitOrder.Count > 0)
            {
                int subtotal = 0;
                foreach (var _orderItem in splitOrder)
                {
                    //透過reflection抓出特定欄位值
                    int actualValue = (int)_orderItem.GetType().GetProperty(groupCoulumnName).GetValue(_orderItem);
                    subtotal += actualValue;
                }
                Subtotal.Add(subtotal);

                //繼續擷取後面的群組資料,直到資料抓完
                dataIndex++;
                splitOrder = orderDts.Skip(dataIndex * groupCount).Take(groupCount).ToList();
            }
            return Subtotal;
        }
    }
}
