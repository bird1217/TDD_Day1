using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupColumnCalculate
{
    public class GroupCalculate
    {
        private List<Order> _orderDts;
        private int _groupCount;
        private string _groupCoulumnName;


        public GroupCalculate(List<Order> orderDts, int groupCount, string groupCoulumnName)
        {
            _orderDts = orderDts;
            _groupCount = groupCount;
            _groupCoulumnName = groupCoulumnName;
        }

        public List<int> GroupColumnCalculate()
        {
            List<int> Subtotal = new List<int>();
            int dataIndex = 0;
            var splitOrder = _orderDts.Skip(dataIndex * _groupCount).Take(_groupCount).ToList();

            while (splitOrder.Count > 0)
            {
                int subtotal = 0;
                foreach (var _orderItem in splitOrder)
                {
                    //透過reflection抓出特定欄位值
                    int actualValue = (int)_orderItem.GetType().GetProperty(this._groupCoulumnName).GetValue(_orderItem);
                    subtotal += actualValue;
                }
                Subtotal.Add(subtotal);

                //繼續擷取後面的群組資料,直到資料抓完
                dataIndex++;
                splitOrder = _orderDts.Skip(dataIndex * _groupCount).Take(_groupCount).ToList();
            }
            return Subtotal;
        }
    }
}
