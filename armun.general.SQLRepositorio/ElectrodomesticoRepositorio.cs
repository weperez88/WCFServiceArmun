using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using armun.general.Dominio;
using armun.general.ContratoRepositorio;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace armun.general.SQLRepositorio
{
    public class ElectrodomesticoRepositorio : IElectrodomesticoRepositorio
    {
        public Electrodomestico getByID(int id)
        {
            string sql_select = "select * from electrodomestico where id = @id";
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.getStringConnection()))
            {
                conexion.Open();
                var electrodomestico = conexion.QueryFirstOrDefault<Electrodomestico>(sql_select, new {id = id});
                return electrodomestico;
            }
        }

        public IEnumerable<Electrodomestico> getList()
        {
            string sql_select = "select * from electrodomestico";
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.getStringConnection()))
            {
                conexion.Open();

                var data = conexion.Query<Electrodomestico>(sql_select);
                return data;
            }
        }
    }
}
