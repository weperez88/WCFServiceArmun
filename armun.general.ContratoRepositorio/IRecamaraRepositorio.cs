using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using armun.general.Dominio;

namespace armun.general.ContratoRepositorio
{
    public interface IRecamaraRepositorio
    {
        Electrodomestico getByID(int id);
        IEnumerable<Electrodomestico> getList();
    }
}
