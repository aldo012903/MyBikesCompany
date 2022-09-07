using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyBikesCompany.Business
{
    public static class Validator
    {
        public static bool ValidId(string id)
        {
            var myRegex = new Regex(@"^[0-9]+$");
            return myRegex.IsMatch(id);
        }

        public static string SuggestedId(List<Bike> _listOfBikes)
        {
            string validId = "";

            if (_listOfBikes.Count == 0)
                validId = "1";

            int[] ids = new int[_listOfBikes.Count];
            for (int i = 0; i < ids.Length; i++)
            {
                ids[i] = _listOfBikes[i].Id;
            }
            Array.Sort(ids);

            for (int i = 0; i < ids.Length - 1; i++)
            {
                if (ids[i] + 1 != ids[i + 1])
                {
                    validId = (ids[i] + 1).ToString();
                    break;
                }
            }

            if (validId == "")
                validId = (ids.Last() + 1).ToString();

            return validId;
        }
    }
}
