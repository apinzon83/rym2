using System.Collections.Generic;
using System.Runtime.Serialization;

namespace rym.Models
{
    [DataContract]
    public class c_results
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public string species { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string gender { get; set; }
        [DataMember]
        public c_origin origin { get; set; }
        [DataMember]
        public c_location location { get; set; }
        [DataMember]
        public string image { get; set; }
        [DataMember]
        public string[] episode { get; set; }
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string created { get; set; }
    }
}