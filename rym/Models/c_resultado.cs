using System.Collections.Generic;
using System.Runtime.Serialization;

namespace rym.Models
{
    [DataContract]
    public class c_resultado
    {
        [DataMember]
        public c_info info { get; set; }
        [DataMember]
        public List<c_results> results { get; set; }
    }
}