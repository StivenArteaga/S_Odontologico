﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class Genero
    {
        int idGenero;
        string nombre;
        int estado;

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

        public Genero()
        {
            nombre = Nombre;
            estado = Estado;
        }
    }
}
