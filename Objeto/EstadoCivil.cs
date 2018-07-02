using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class EstadoCivil
    {

        int idEstadoCivil;
        string nombre;
        int estado;

        public int IdEstadoCivil
        {
            get
            {
                return idEstadoCivil;
            }

            set
            {
                idEstadoCivil = value;
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

        public EstadoCivil()
        {
            nombre = Nombre;
            estado = Estado;
        }
    }
}
