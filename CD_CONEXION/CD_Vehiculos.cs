using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Vehiculos
    {
        CD_CONEXION db_conexion = new CD_CONEXION();


        // CAPA PARA MOSTRAR VEHICULOS
        public DataTable MtMostrarVehiculos()
        {
            string QryMostrarVehiculos = "usp_vehiculo_Mostrar";
            SqlDataAdapter adapter = new SqlDataAdapter(QryMostrarVehiculos, db_conexion.MtdAbrirConexion());
            DataTable dtMostrarVehiculos = new DataTable();
            adapter.Fill(dtMostrarVehiculos);
            db_conexion.MtdCerrarConexion();
            return dtMostrarVehiculos;
        }




        // CAPA PARA INSERTAR VEHICULOS
        public void MtInsertarVehiculos(string Marca, string @Modelo, int Año, decimal Precio, string estado)
        {
            try
            {
                string Usp_crear = "usp_vehiculo_crear";

                using (SqlCommand cmd_InsertarEstudiante = new SqlCommand(Usp_crear, db_conexion.MtdAbrirConexion()))
                {
                    cmd_InsertarEstudiante.CommandType = CommandType.StoredProcedure;

                    cmd_InsertarEstudiante.Parameters.AddWithValue("@Marca", Marca);
                    cmd_InsertarEstudiante.Parameters.AddWithValue("@@Modelo", @Modelo);
                    cmd_InsertarEstudiante.Parameters.AddWithValue("@Año", Año);
                    cmd_InsertarEstudiante.Parameters.AddWithValue("@Precio", Precio);
                    cmd_InsertarEstudiante.Parameters.AddWithValue("@Estado", estado);

                    cmd_InsertarEstudiante.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar Vehiculos: {ex.Message}");
            }
            finally
            {
                db_conexion.MtdCerrarConexion();
            }
        }




        // CAPA DE ACTUALIZAR 
        public void MtdActualizarVehiculos(int VehiculoID, string Marca, string @Modelo, int Año, decimal Precio, string estado)
        {
             String usp_actualizar = "usp_vehiculos_editar";

            SqlCommand cmduspActualizar = new SqlCommand(usp_actualizar, db_conexion.MtdAbrirConexion());

            cmduspActualizar.CommandType = CommandType.StoredProcedure;

            cmduspActualizar.Parameters.AddWithValue("@EstudianteID", VehiculoID);
            cmduspActualizar.Parameters.AddWithValue("@Nombre", Marca);
            cmduspActualizar.Parameters.AddWithValue("@@Modelo", @Modelo);
            cmduspActualizar.Parameters.AddWithValue("@Año", Año);
            cmduspActualizar.Parameters.AddWithValue("@Precio", Precio);
            cmduspActualizar.Parameters.AddWithValue("@Estado", estado);
            cmduspActualizar.ExecuteNonQuery();

            db_conexion.MtdCerrarConexion();
        }





        // CAPA PARA ELIMINAR VEHICULOS
        public void CD_mtdEliminarVehiculos(int VehiculoID)
        {

            string UspEliminarVehiculos = "ups_eliminar_estudiante";
            SqlCommand commUspEliminarEstudiantes = new SqlCommand(UspEliminarVehiculos, db_conexion.MtdAbrirConexion());
            commUspEliminarEstudiantes.CommandType = CommandType.StoredProcedure;

            commUspEliminarEstudiantes.Parameters.AddWithValue("@EstudianteID", VehiculoID);
            commUspEliminarEstudiantes.ExecuteNonQuery();

            db_conexion.MtdCerrarConexion();
        }


    }
}
