using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class GrupoSanguineo
    {

        int idGrupoSanguineo;
        string nombre;
        int estado;

        public int IdGrupoSanguineo
        {
            get
            {
                return idGrupoSanguineo;
            }

            set
            {
                idGrupoSanguineo = value;
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

        public GrupoSanguineo()
        {
            nombre = Nombre;
            estado = Estado;
        }
    }
}
