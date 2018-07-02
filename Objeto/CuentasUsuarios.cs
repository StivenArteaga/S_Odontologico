using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class CuentasUsuarios
    {
        int idCuentaUsuario;
        string nombre;
        string email;
        int telefono;
        string contraseña;
        int idRolCuentaUsuario;
        int idPregunta;
        string respuesta;


        public int IdCuentaUsuario
        {
            get
            {
                return idCuentaUsuario;
            }

            set
            {
                idCuentaUsuario = value;
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

        public int Telefono
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

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }
        
        public int IdRolCuentaUsuario
        {
            get
            {
                return idRolCuentaUsuario;
            }

            set
            {
                idRolCuentaUsuario = value;
            }
        }

        public string Respuesta
        {
            get
            {
                return respuesta;
            }

            set
            {
                respuesta = value;
            }
        }

        public int IdPregunta
        {
            get
            {
                return idPregunta;
            }

            set
            {
                idPregunta = value;
            }
        }

        public CuentasUsuarios()
        {
            idCuentaUsuario = IdCuentaUsuario;
            nombre = Nombre;
            email = Email;
            telefono = Telefono;
            contraseña = Contraseña;
            idRolCuentaUsuario = IdRolCuentaUsuario;
            idPregunta = IdPregunta;
            respuesta = Respuesta;
        }

        public CuentasUsuarios(int idCuentaUsuario, string nombre, string email, int telefono, string contraseña, int idRolCuentaUsuario, string respuesta, int idPregunta)
        {
            IdCuentaUsuario = idCuentaUsuario;
            Nombre = nombre;
            Email = email;
            Telefono = telefono;
            Contraseña = contraseña;
            IdRolCuentaUsuario = idRolCuentaUsuario;
            IdPregunta = idPregunta;
            Respuesta = respuesta;
        }
    }
}
