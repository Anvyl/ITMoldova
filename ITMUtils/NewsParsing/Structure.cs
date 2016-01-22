using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMUtils.NewsParsing
{
    public class Structure
    {
        public string Title { get; set; }
        public string ImgSource { get; set; }
        public string Content { get; set; }
        public string EncodedString { get; set; }
        public DateTime PublishDate { get; set;}
        public string Author { get; set; }
        public int index { get; set; }
    }
}
