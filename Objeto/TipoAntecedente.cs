using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class TipoAntecedente
    {
        int idTipoAntecedente;
        string nombre;
        int estado;

        public int IdTipoAntecedente
        {
            get
            {
                return idTipoAntecedente;
            }

            set
            {
                idTipoAntecedente = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public TipoAntecedente()
        {
            idTipoAntecedente = IdTipoAntecedente;
            nombre = Nombre;
            estado = Estado;
        }
    }
}
