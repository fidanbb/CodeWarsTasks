using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFiltering
{
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            #region 1st way
            //List<int> expected = new List<int>();

            //foreach (object item in listOfItems)
            //{
            //    if (item.GetType() != typeof(string))
            //    {
            //        expected.Add((int)item);
            //    }

            //}
            //return expected;
            #endregion

            #region 2nd way
            //var expected = listOfItems.Where(m => m.GetType() != typeof(string)).Cast<int>();

            //return expected;
            #endregion



            #region 3rd way

            //return listOfItems.Where(x => x is not int).Select(x => (int)x);

            #endregion


            #region 4th way

            return listOfItems.OfType<int>();
          

            #endregion
        }
    }
}
