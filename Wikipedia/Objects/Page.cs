using System.Collections.Generic;
using RestSharp.Deserializers;

namespace Genbox.Wikipedia.Objects {
    public class Page {
        [DeserializeAs(Name = "pageid")]
        public int PageID { get; set; }

        [DeserializeAs(Name = "ns")]
        public int NS { get; set; }

        [DeserializeAs(Name = "title")]
        public string Title { get; set; }

        [DeserializeAs(Name = "error")]
        public Error Error { get; set; }

        [DeserializeAs(Name = "extract")]
        public string? Extract { get; set; }


    }
}