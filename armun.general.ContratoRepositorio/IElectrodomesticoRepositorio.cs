using armun.general.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armun.general.ContratoRepositorio
{
    public interface IElectrodomesticoRepositorio
    {
        Electrodomestico getByID(int id);
        IEnumerable<Electrodomestico> getList();
    }
}
