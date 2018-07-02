using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class Departamento
    {
        int idDepartamento;
        string nombre;
        int estado;
        int idPais;

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

        public Departamento()
        {
            nombre = Nombre;
            estado = Estado;
            idPais = IdPais;
        }
    }
}
