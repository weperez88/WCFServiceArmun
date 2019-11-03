using System.Collections.Generic;
using System.ServiceModel;
using armun.general.Dominio;

namespace armun.general.Contrato
{
    [ServiceContract]
    public interface IElectrodomestico
    {
        [OperationContract]
        Electrodomestico getByID(int id);
        [OperationContract]
        IEnumerable<Electrodomestico> getList();
    }
}
