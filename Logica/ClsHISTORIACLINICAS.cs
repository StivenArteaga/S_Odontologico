using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    class ClsHISTORIACLINICAS
    {
        private Modelo.ClsHISTORIACLINICAS objClsHistoriaClinica = new Modelo.ClsHISTORIACLINICAS();

        public bool RegistrarHistoriaClinica(Objeto.ClsHISTORIACLINICAS objClsHistoria)
        {
            return objClsHistoriaClinica.RegistrarHistoriaClinica(objClsHistoria);
        }

        public DataTable ConsultarHistoriaClinica(int intId_Cliente)
        {
            return objClsHistoriaClinica.ConsultarHistoriaClinica(intId_Cliente);
        }

        public DataTable listar_clientes()
        {

            return objClsHistoriaClinica.ListarHistoriaClinica();
        }
    }
}
