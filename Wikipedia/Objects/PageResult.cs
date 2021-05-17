using System.Collections.Generic;
using RestSharp.Deserializers;

namespace Genbox.Wikipedia.Objects {
    public class PageResult {
        [DeserializeAs(Name = "normalized")]
        public Normalized? Normalized { get; set; }
        [DeserializeAs(Name = "pages")]
        public List<Page>? Pages{ get; set; }

        [DeserializeAs(Name = "error")]
        public Error? Error { get; set; }
    }
}