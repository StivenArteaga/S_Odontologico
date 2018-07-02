using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Logica
{
    public class TipoAntecedente
    {
        private Modelo.TipoAntecedente tipoAntecedente = new Modelo.TipoAntecedente();


        public bool insertarTipoAntecedente(Objeto.TipoAntecedente objTipoAntecedente)
        {
            return tipoAntecedente.RegistrarTipoAntecedente(objTipoAntecedente);
        }


        public DataTable cargarTipoAntecedente()
        {
            return tipoAntecedente.ConsultarTipoAntecedente();
        }

        public bool modificarTipoAntecedente(Objeto.TipoAntecedente objTipoAntecedente)
        {
            return tipoAntecedente.ModificarTipoAntecedente(objTipoAntecedente);
        }
    }
}
