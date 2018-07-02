using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class Pais
    {
        int idPais;
        string nombre;
        int estado;

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

        public int IdPais
        {
            get
            {
                return idPais;
            }

            set
            {
                idPais = value;
            }
        }

        public Pais()
        {

            nombre = Nombre;
            estado = Estado;
        }



    }
}
