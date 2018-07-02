using CAD.DSTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CAD
{
    public class CADValidacionRegistroUsuario
    {

        private static CUENTASUSUARIOSTableAdapter adaptador = new CUENTASUSUARIOSTableAdapter();

        public static bool ExisteUsuario(string email, string contraseña)
        {
            try
            {
                if (adaptador.ExisteUsuario(email, contraseña) == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

    }
}
