using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Modelo
{
    public class ClsHISTORIACLINICAS
    {

        public bool RegistrarHistoriaClinica(Objeto.ClsHISTORIACLINICAS objClsHistoriaClinica)
        {
            bool bolRepuesta = false;
            SqlConnection Conexion = new SqlConnection();

            try
            {
                ClsConexion objClsConexion = new ClsConexion();
                Conexion = objClsConexion.Conexion();
                Conexion.Open();

                // Especifica el Nombre del Procedimiento Almacenado
                string strHistoriaClinica = "[dbo].[insertarHISTORIACLINICAS]";
                // Esteblezco el Tipo de Conexión para el SqlCommand "CmInstUsuario"
                SqlCommand CmInstHistoriaClinica = new SqlCommand(strHistoriaClinica, Conexion);
                CmInstHistoriaClinica.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstHistoriaClinica.Parameters.AddWithValue("@idHistoriaClinica", objClsHistoriaClinica.IdHistoriaClinica);
                CmInstHistoriaClinica.Parameters.AddWithValue("@fecha", objClsHistoriaClinica.Fecha);
                CmInstHistoriaClinica.Parameters.AddWithValue("@estado", objClsHistoriaClinica.Estado);

                int intRepuesta = CmInstHistoriaClinica.ExecuteNonQuery();
                if (intRepuesta > 0)
                {
                    bolRepuesta = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                // Cierro la Conexión
                Conexion.Close();
                // Libero Recursos NO Administrados, esto me garantiza que se Cierra la Conexión
                Conexion.Dispose();
            }

            return bolRepuesta;
        }


        public DataTable ConsultarHistoriaClinica(int idHistoriaClinica)
        {
            DataTable dt = new DataTable();
            SqlConnection Conexion = new SqlConnection();


            try
            {
                ClsConexion objClsConexion = new ClsConexion();
                Conexion = objClsConexion.Conexion();
                Conexion.Open();

                string strHistoriaClinica = "[dbo].[listarHistoriaClinica]";

                SqlDataAdapter CmHistoriaClinica = new SqlDataAdapter(strHistoriaClinica, Conexion);
                CmHistoriaClinica.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                CmHistoriaClinica.SelectCommand.Parameters.AddWithValue("@idHistoriaClinica", idHistoriaClinica);

                CmHistoriaClinica.Fill(dt);
            }
            catch (Exception)
            {
            }
            finally
            {
                Conexion.Close();
                Conexion.Dispose();
            }

            return dt;
        }



        public DataTable ListarHistoriaClinica()
        {
            string strHistoriaClinica = "";
            DataTable dt = new DataTable();
            SqlConnection Conexion = new SqlConnection();

            try
            {
                ClsConexion objClsConexion = new ClsConexion();
                Conexion = objClsConexion.Conexion();
                Conexion.Open();

                strHistoriaClinica = "[dbo].[listarHistoriaClinica]";

            }
            catch (Exception)
            {
            }
            finally
            {
                Conexion.Close();
                Conexion.Dispose();
            }

            return dt;
        }


    }
}
