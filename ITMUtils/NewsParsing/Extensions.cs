using System.Collections.Generic;

namespace ITMUtils.NewsParsing
{
    /// <summary>
<<<<<<< HEAD
    /// Custom extension methods for our News library.
=======
    /// Custom extension methods for our news collection.
>>>>>>> refs/remotes/origin/master
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Search through the collection of Structure items and return the results.
        /// </summary>
        /// <param name="InputList">Extension param</param>
        /// <param name="search">String to search</param>
        /// <returns></returns>
        public static List<NewsStruct> Search(this List<NewsStruct> InputList,string search)
        {
            List<NewsStruct> result = new List<NewsStruct>();
            foreach (NewsStruct item in InputList)
            {
                if (item.Title.Contains(search)||item.Content.Contains(search))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
