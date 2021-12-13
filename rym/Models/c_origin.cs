using System.Runtime.Serialization;

namespace rym.Models
{
    [DataContract]
    public class c_origin
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string url { get; set; }
    }
}