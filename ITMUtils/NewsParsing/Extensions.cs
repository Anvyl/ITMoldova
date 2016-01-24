using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMUtils.NewsParsing
{
    internal static class Extensions
    {
        /// <summary>
        /// Search through the collection of Structure items and return the results.
        /// </summary>
        /// <param name="InputList">Exensiion param</param>
        /// <param name="search">String to search</param>
        /// <returns></returns>
        public static List<Structure> Search(this List<Structure> InputList, string search)
        {
            List<Structure> result = new List<Structure>();
            foreach (Structure item in InputList)
            {
                if (item.Title.Contains(search) || item.Content.Contains(search))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        /// <summary>
        /// Verifies if there are new news online.
        /// </summary>
        /// <param name="InputList"></param>
        /// <param name="OtherList"></param>
        /// <returns></returns>
        public static bool IsNew(this List<Structure> InputList, List<Structure> OtherList)
        {
            
            return false;
        }
    }
}
