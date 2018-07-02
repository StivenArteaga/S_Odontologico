using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class Odontologo
    {
        int idOdontologo;
        string documento;
        string nombre;
        string primerApellido;
        string segundoApellido;
        string especialidad;
        string email;
        string telefono;
        int estado;
        int idGenero;
        int idTipoDocumento;
        int idConsultorio;
        int idGrupoSanguineo;

        public int IdOdontologo
        {
            get
            {
                return idOdontologo;
            }

            set
            {
                idOdontologo = value;
            }
        }

        public string Documento
        {
            get
            {
                return documento;
            }

            set
            {
                documento = value;
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

        public string PrimerApellido
        {
            get
            {
                return primerApellido;
            }

            set
            {
                primerApellido = value;
            }
        }

        public string SegundoApellido
        {
            get
            {
                return segundoApellido;
            }

            set
            {
                segundoApellido = value;
            }
        }

        public string Especialidad
        {
            get
            {
                return especialidad;
            }

            set
            {
                especialidad = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
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

        public int IdGenero
        {
            get
            {
                return idGenero;
            }

            set
            {
                idGenero = value;
            }
        }

        public int IdTipoDocumento
        {
            get
            {
                return idTipoDocumento;
            }

            set
            {
                idTipoDocumento = value;
            }
        }

        public int IdConsultorio
        {
            get
            {
                return idConsultorio;
            }

            set
            {
                idConsultorio = value;
            }
        }

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

        public Odontologo()
        {
            idOdontologo = IdOdontologo;
            documento = Documento;
            nombre = Nombre;
            primerApellido = PrimerApellido;
            segundoApellido = SegundoApellido;
            especialidad = Especialidad;
            email = Email;
            telefono = Telefono;
            estado = Estado;
            idGenero = IdGenero;
            idTipoDocumento = IdTipoDocumento;
            idConsultorio = IdConsultorio;
            idGrupoSanguineo = IdGrupoSanguineo;
        }
    }
}
