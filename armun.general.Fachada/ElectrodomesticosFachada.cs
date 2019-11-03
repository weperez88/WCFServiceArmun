using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using armun.general.Dominio;
using armun.general.SQLRepositorio;
using armun.general.ContratoRepositorio;

namespace armun.general.Fachada
{
    public class ElectrodomesticosFachada : IDisposable
    {
        public Electrodomestico getByID(int id)
        {
            IElectrodomesticoRepositorio instancia = new ElectrodomesticoRepositorio();
            return instancia.getByID(id);
        }

        public IEnumerable<Electrodomestico> getList()
        {
            IElectrodomesticoRepositorio instancia = new ElectrodomesticoRepositorio();
            return instancia.getList();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
