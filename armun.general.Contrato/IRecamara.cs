using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using armun.general.Dominio;

namespace armun.general.Contrato
{
    [ServiceContract]
    public interface IRecamara
    {
        [OperationContract]
        Recamara getById(int id);
        [OperationContract]
        IEnumerable<Recamara> getList();
    }
}
