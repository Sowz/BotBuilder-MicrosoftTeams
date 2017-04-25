// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Linq;

    /// <summary>
    /// A list card item base.
    /// </summary>
    public partial class ListItemBase
    {
        /// <summary>
        /// Initializes a new instance of the ListItemBase class.
        /// </summary>
        public ListItemBase() { }

        /// <summary>
        /// Initializes a new instance of the ListItemBase class.
        /// </summary>
        /// <param name="type">Type of the item</param>
        /// <param name="id">Id of the item</param>
        /// <param name="title">Title of the item</param>
        /// <param name="subtitle">Subtitle of the item</param>
        public ListItemBase(string type = default(string), string id = default(string), string title = default(string), string subtitle = default(string), CardAction tap = default(CardAction))
        {
            Type = type;
            Id = id;
            Title = title;
            Subtitle = subtitle;
            Tap = tap;
        }

        /// <summary>
        /// Gets or sets type of the item
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets id of the item
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets title of the item
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets subtitle of the item
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "subtitle")]
        public string Subtitle { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tap")]
        public CardAction Tap { get; set; }

    }
}