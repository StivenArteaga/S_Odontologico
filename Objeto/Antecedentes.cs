using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class Antecedentes
    {
        //AntecedentesTipo
        int idAntecedenteTipo;
        int idTipoAntecedente;
        static int idHistoriaClinica;
        string idRespuesta;
        string observacion;
        //TipoAntecedentes
        string nombre;
        int estado;
        //Paciente
        static string numeroHistoriaClinica;
        static string documento;
        static string nombreCompletoPaciente;
        static DateTime fecha;




        public int IdAntecedenteTipo
        {
            get
            {
                return idAntecedenteTipo;
            }

            set
            {
                idAntecedenteTipo = value;
            }
        }

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

        public int IdHistoriaClinica
        {
            get
            {
                return idHistoriaClinica;
            }

            set
            {
                idHistoriaClinica = value;
            }
        }

        public string IdRespuesta
        {
            get
            {
                return idRespuesta;
            }

            set
            {
                idRespuesta = value;
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

        public string NombreCompletoPaciente
        {
            get
            {
                return nombreCompletoPaciente;
            }

            set
            {
                nombreCompletoPaciente = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string NumeroHistoriaClinica
        {
            get
            {
                return numeroHistoriaClinica;
            }

            set
            {
                numeroHistoriaClinica = value;
            }
        }

        public Antecedentes()
        {
            idAntecedenteTipo = IdAntecedenteTipo;
            idTipoAntecedente = IdTipoAntecedente;
            idHistoriaClinica = IdHistoriaClinica;
            idRespuesta = IdRespuesta;
            observacion = Observacion;
            nombre = Nombre;
            estado = Estado;
            documento = Documento;
            nombreCompletoPaciente = NombreCompletoPaciente;
            fecha = Fecha;
            numeroHistoriaClinica = NumeroHistoriaClinica;
        }
    }
}
