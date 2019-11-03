using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using armun.general.ContratoRepositorio;
using armun.general.SQLRepositorio;
using armun.general.Dominio;

namespace armun.general.Fachada
{
    class RecamaraFachada : IDisposable
    {
        public Electrodomestico getByID(int id)
        {
            IRecamaraRepositorio instancia = new RecamaraRepositorio();
            return instancia.getByID(id);
        }

        public IEnumerable<Electrodomestico> getList()
        {
            IRecamaraRepositorio instancia = new RecamaraRepositorio();
            return instancia.getList();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
