using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using System.Text.RegularExpressions;

namespace ITMUtils.NewsParsing
{
    /// <summary>
    /// Parses the information from the feed xml. 
    /// </summary>
    public class Parser
    {
        private static string SourceUrl = "http://itmoldova.com/feed";
        private static string ItemPath = "/rss/channel/item";
        private static string TitlePath = ItemPath + "/title";
        private static string DescriptionPath = ItemPath + "/description";
        private static string PublishDatePath = ItemPath + "/pubDate";

        /// <summary>
        /// Get all feed data with a structure according to <see cref="ITMUtils.NewsParsing.Structure" />
        /// </summary>
        /// <returns>All feed data into a <see cref="List{Structure}"/> format</returns>
        public async static Task<List<Structure>> GetFeedData()
        {
            List<Structure> result = new List<Structure>();
            HttpClient client = new HttpClient();
            string xml = await client.GetStringAsync(SourceUrl);
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xml);
            XmlNodeList nodes = xdoc.SelectNodes(TitlePath);
            foreach (IXmlNode item in nodes)
            {
                result.Add(new Structure() { Title = item.InnerText});
            }
            Regex rgx = new Regex("src=\".+?\"");
            xdoc.LoadXml(xml);
            nodes= xdoc.SelectNodes(DescriptionPath);
            int count = 0;
            string text = string.Empty;
            foreach (IXmlNode item in nodes)
            {
                text = item.NextSibling.NextSibling.InnerText;
                result[count].ImgSource = rgx.Matches(text)[0].Value.Replace("src=\"", string.Empty).Replace("\"", string.Empty);
                result[count].Content = Regex.Replace(Regex.Replace(text, "<.*?>", string.Empty), "&.*?;", string.Empty);
                result[count].EncodedString = text;
                count++;
            }
            nodes = xdoc.SelectNodes(PublishDatePath);
            count = 0;
            foreach (IXmlNode item in nodes)
            {
                result[count].PublishDate = DateTime.Parse(item.InnerText).ToLocalTime();
                result[count].Author = "Autor: " + item.NextSibling.NextSibling.InnerText;
                count++;
            }
            return result;
        }
    }
}
