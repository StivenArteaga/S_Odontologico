using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class Ocupacion
    {

        int idOcupacion;
        string nombre;
        int estado;

        public int IdOcupacion
        {
            get
            {
                return idOcupacion;
            }

            set
            {
                idOcupacion = value;
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

        public Ocupacion()
        {
            nombre = Nombre;
            estado = Estado;
        }
    }
}
