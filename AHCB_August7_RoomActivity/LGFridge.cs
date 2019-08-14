using System;
using System.Collections.Generic;
using System.Text;

namespace AHCB_August7_RoomActivity
{
    public class LGFridge : IFridge
    {
        private IList<Grocery> _groceries = new List<Grocery>();

        public void Contents(Grocery grocery)
        {
            _groceries.Add(grocery);
        }

        public string GetContents()
        {
            var stringBuilder = new StringBuilder();
            foreach (var item in _groceries)
            {
                stringBuilder.Append(item);
            }

            return stringBuilder.ToString();
        }
    }
}
