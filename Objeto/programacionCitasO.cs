using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class programacionCitasO
    {

        private int idProgramacionCitas;
        private int idOdontologo;
        static int idPaciente;
        static DateTime fechaCita;
        private TimeSpan horaInicio;
        private int duracion;
        private string descripcion;
        private Int16 estado;
        static string documento;
        static string b;


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

        public DateTime FechaCita
        {
            get
            {
                return fechaCita;
            }

            set
            {
                fechaCita = value;
            }
        }

        public TimeSpan HoraInicio
        {
            get
            {
                return horaInicio;
            }

            set
            {
                horaInicio = value;
            }
        }

        public int Duracion
        {
            get
            {
                return duracion;
            }

            set
            {
                duracion = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public Int16 Estado
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

        public int IdProgramacionCitas
        {
            get
            {
                return IdProgramacionCitas;
            }

            set
            {
                IdProgramacionCitas = value;
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

        public string B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        public programacionCitasO()

        {
            idOdontologo = IdOdontologo;
            idPaciente = IdPaciente;
            documento = Documento;
            fechaCita = FechaCita;
            horaInicio = HoraInicio;
            duracion = Duracion;
            descripcion = Descripcion;
            estado = Estado;
            b = B;

        }


        public programacionCitasO(int idProgramacionCitas, int idOdontologo, int idPaciente, string documento, DateTime fechaCita, TimeSpan horaInicio, int duracion, string descripcion, Int16 estado, string b)
        {
            IdProgramacionCitas = idProgramacionCitas;
            IdOdontologo = idOdontologo;
            IdPaciente = idPaciente;
            Documento = documento;
            FechaCita = fechaCita;
            HoraInicio = horaInicio;
            Duracion = duracion;
            Descripcion = descripcion;
            Estado = estado;
            B = b;

        }

    }
}
