using System.Collections.Generic;
using RestSharp.Deserializers;

namespace Genbox.Wikipedia.Objects {
    public class Normalized {

        [DeserializeAs(Name = "from")]
        public string? From { get; set; }

        [DeserializeAs(Name = "to")]
        public string? To { get; set; }


    }
}