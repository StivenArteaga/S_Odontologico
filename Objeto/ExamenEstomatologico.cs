﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class ExamenEstomatologico
    {
        //ExamenEstomatologico
        int idExamenEstomatologico;
        int idEstomatologico;
        static int idHistoriaClinica;
        string idRespuesta;
        string observacion;
        //Respuesta
        string nombre;
        int estado;
        //Paciente
        static string numeroHistoriaClinica;
        static string documento;
        static string nombreCompletoPaciente;
        static DateTime fecha;

        public int IdExamenEstomatologico
        {
            get
            {
                return idExamenEstomatologico;
            }

            set
            {
                idExamenEstomatologico = value;
            }
        }

        public int IdEstomatologico
        {
            get
            {
                return idEstomatologico;
            }

            set
            {
                idEstomatologico = value;
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
    }
}
