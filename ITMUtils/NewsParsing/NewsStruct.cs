using System;

namespace ITMUtils.NewsParsing
{
    /// <summary>
    /// Structure of our Feed Item.
    /// </summary>
    public class NewsStruct : IEquatable<NewsStruct>
    {
        /// <summary>
        /// Field that holds the id for the item used for local storing indexation.
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Feed Item Title.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// First found image url in the <see cref="EncodedString"/>
        /// </summary>
        public string ImgSource { get; set; }
        /// <summary>
        /// Clear content of the feed item with no html tag.
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Feed Item content with html tags.
        /// </summary>
        public string EncodedString { get; set; }
        /// <summary>
        /// The Publish Date of the current Feed Item.
        /// </summary>
        public DateTime PublishDate { get; set; }
        /// <summary>
        /// The Author of the Feed Item
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Feed Item category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Check if current Feed Item is equal with another.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(NewsStruct other)
        {
            if (other == null)
                return false;
            return this.Title.Equals(other.Title) && this.EncodedString.Equals(other.EncodedString) && this.Content.Equals(other.Content);
        }
    }
}
