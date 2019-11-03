using System;
using System.Runtime.Serialization;

namespace armun.general.Dominio
{
    [DataContract]
    public class Recamara
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string identificador { get; set; }
        [DataMember]
        public int numero_paredes { get; set; }
        [DataMember]
        public int numero_puertas { get; set; }
        [DataMember]
        public int numero_ventanas { get; set; }
        [DataMember]
        public bool amueblada { get; set; }
        [DataMember]
        public string tipo_techo { get; set; }
    }
}
