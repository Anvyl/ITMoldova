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
    public class Parser
    {
        public Parser()
        {

        }

        public async static Task<List<Structure>> GetTitles()
        {
            List<Structure> result = new List<Structure>();
            HttpClient client = new HttpClient();
            string xml = await client.GetStringAsync("http://itmoldova.com/feed");
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xml);
            XmlNodeList nodes = xdoc.SelectNodes("/rss/channel/item/title");
            foreach (IXmlNode item in nodes)
            {
                result.Add(new Structure() { Title = item.InnerText ,ImgSource= "http://itmoldova.com/wp-content/uploads/2016/01/lithium-ion.jpg"});
            }
            Regex rgx = new Regex("src=\".+?\"");
            xdoc.LoadXml(xml);
            XmlNodeList nodes2= xdoc.SelectNodes("/rss/channel/item/description");
            int count = 0;
            string text = string.Empty;
            foreach (IXmlNode item in nodes2)
            {
                text = item.NextSibling.NextSibling.InnerText;
                result[count].ImgSource = rgx.Matches(text)[0].Value.Replace("src=\"", string.Empty).Replace("\"", string.Empty);
                result[count].Content = Regex.Replace(Regex.Replace(text, "<.*?>", string.Empty), "&.*?;", string.Empty);
                result[count].EncodedString = text;
                count++;
            }
            nodes2 = xdoc.SelectNodes("/rss/channel/item/pubDate");
            count = 0;
            foreach (IXmlNode item in nodes2)
            {
                result[count++].PublishDate = DateTime.Parse(item.InnerText).ToLocalTime();
            }

            nodes2 = xdoc.SelectNodes("/rss/channel/item/pubDate");
            count = 0;
            foreach (IXmlNode item in nodes2)
            {
                result[count++].Author = "Autor: " + item.NextSibling.NextSibling.InnerText;
            }
            return result;
        }
    }
}
