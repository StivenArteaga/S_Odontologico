using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class Paciente
    {

        int idPaciente;
        string documento;
        string nombres;
        string primerApellido;
        string segundoApellido;
        DateTime fechaNacimiento;
        string email;
        string foto;
        string barrio;
        string direccion;
        string telefonoFijo;
        string telefonoMovil;
        string observacion;
        int estado;
        int idGenero;
        int idCiudad;
        int idEstadoCivil;
        int idTipoDocumento;
        int idOcupacion;
        int idAseguradora;
        int idTipoSeguro;
        int idGrupoSanguineo;

        string nombreResponsable;
        string apellidoResponsable;
        string telefonoResponsable;
        string direccionResponsable;
        int idParentescoResponsable;


        public int IdPaciente
        {
            get
            {
                return idPaciente;
            }

            set
            {
                idPaciente = value;
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

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
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

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
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

        public string Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }

        public string Barrio
        {
            get
            {
                return barrio;
            }

            set
            {
                barrio = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string TelefonoFijo
        {
            get
            {
                return telefonoFijo;
            }

            set
            {
                telefonoFijo = value;
            }
        }

        public string TelefonoMovil
        {
            get
            {
                return telefonoMovil;
            }

            set
            {
                telefonoMovil = value;
            }
        }

        public string Observacion
        {
            get
            {
                return observacion;
            }

            set
            {
                observacion = value;
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

        public int IdAseguradora
        {
            get
            {
                return idAseguradora;
            }

            set
            {
                idAseguradora = value;
            }
        }

        public int IdTipoSeguro
        {
            get
            {
                return idTipoSeguro;
            }

            set
            {
                idTipoSeguro = value;
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

        public string NombreResponsable
        {
            get
            {
                return nombreResponsable;
            }

            set
            {
                nombreResponsable = value;
            }
        }

        public string ApellidoResponsable
        {
            get
            {
                return apellidoResponsable;
            }

            set
            {
                apellidoResponsable = value;
            }
        }

        public string TelefonoResponsable
        {
            get
            {
                return telefonoResponsable;
            }

            set
            {
                telefonoResponsable = value;
            }
        }

        public string DireccionResponsable
        {
            get
            {
                return direccionResponsable;
            }

            set
            {
                direccionResponsable = value;
            }
        }

        public int IdParentescoResponsable
        {
            get
            {
                return idParentescoResponsable;
            }

            set
            {
                idParentescoResponsable = value;
            }
        }

        public Paciente()
        {
            idPaciente = IdPaciente;
            documento = Documento;
            nombres = Nombres;
            primerApellido = PrimerApellido;
            segundoApellido = SegundoApellido;
            fechaNacimiento = FechaNacimiento;
            email = Email;
            // foto = Foto;
            barrio = Barrio;
            direccion = Direccion;
            telefonoFijo = TelefonoFijo;
            telefonoMovil = TelefonoMovil;
            observacion = Observacion;
            estado = Estado;
            idGenero = IdGenero;
            idCiudad = IdCiudad;
            idEstadoCivil = IdEstadoCivil;
            idTipoDocumento = IdTipoDocumento;
            idOcupacion = IdOcupacion;
            idAseguradora = IdAseguradora;
            idTipoSeguro = IdTipoSeguro;
            idGrupoSanguineo = IdGrupoSanguineo;

            nombreResponsable = NombreResponsable;
            apellidoResponsable = ApellidoResponsable;
            telefonoResponsable = TelefonoResponsable;
            direccionResponsable = DireccionResponsable;
            idParentescoResponsable = IdParentescoResponsable;
        }
    }
}
