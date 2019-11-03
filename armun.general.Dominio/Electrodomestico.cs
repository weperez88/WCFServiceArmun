using System;
using System.Runtime.Serialization;

namespace armun.general.Dominio
{
    [DataContract]
    public class Electrodomestico
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string marca { get; set; }
        [DataMember]
        public string modelo { get; set; }
        [DataMember]
        public decimal precio { get; set; }
        [DataMember]
        public DateTime fecha_compra { get; set; }
    }
}
