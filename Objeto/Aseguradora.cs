﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class Aseguradora
    {
        int idAseguradora;
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

        public Aseguradora()
        {
            nombre = Nombre;
            estado = Estado;
        }
    }
}
