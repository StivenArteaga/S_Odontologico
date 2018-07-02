using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class Ciudad
    {
        int idCiudad;
        string nombre;
        int estado;
        int idDepartamento;

        public int IdCiudad
        {
            get
            {
                return idCiudad;
            }

            set
            {
                idCiudad = value;
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

        public int IdDepartamento
        {
            get
            {
                return idDepartamento;
            }

            set
            {
                idDepartamento = value;
            }
        }

        public Ciudad()
        {
            nombre = Nombre;
            estado = Estado;
            idDepartamento = IdDepartamento;
        }
    }
}
