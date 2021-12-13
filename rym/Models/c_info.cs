using System.Runtime.Serialization;

namespace rym.Models
{
    [DataContract]
    public class c_info
    {
        [DataMember]
        public int count { get; set; }
        [DataMember]
        public int pages { get; set; }
        [DataMember]
        public string next { get; set; }
        [DataMember]
        public string prev { get; set; }
    }
}