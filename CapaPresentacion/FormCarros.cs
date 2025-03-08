using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormCarros : Form
    {
        CD_Vehiculos cd_vehiculos = new CD_Vehiculos();

        public FormCarros()
        {
            InitializeComponent();
        }




        public void MtdMostrarVehiuclos()
        {
            CD_Vehiculos cd_vehiculos = new CD_Vehiculos();
            DataTable dtMostrarVehiculos = cd_vehiculos.MtMostrarVehiculos();
            dgvVehicular.DataSource = dtMostrarVehiculos;
        }


        /// metodo insertar un vehiculo
        public void mtdCrearVehiculos()
        {
            try
            {
                // convertir numeros apra que no de error por tipo de formato.  
                int.TryParse(txtAño.Text, out int Año);
                decimal.TryParse(txtPrecio.Text, out decimal Precio);


                cd_vehiculos.MtInsertarVehiculos( txtMarca.Text, txtModelo.Text, Año, Precio, cboxEstado.Text);

                MessageBox.Show("El Vehiculo se agregó con éxito.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormCarros_Load(object sender, EventArgs e)
        {
            MtdMostrarVehiuclos();

        }


        /// MOSTRAMOS DATOS EL EL DATADRIVED. DESDE LA CONECCION DE SQL
        private void dgvVehicular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDVehiculo.Text = dgvVehicular.SelectedCells[0].Value.ToString();
            txtMarca.Text = dgvVehicular.SelectedCells[1].Value.ToString();
            txtModelo.Text = dgvVehicular.SelectedCells[2].Value.ToString();
            txtAño.Text = dgvVehicular.SelectedCells[3].Value.ToString();
            txtPrecio.Text = dgvVehicular.SelectedCells[4].Value.ToString();
            cboxEstado.Text = dgvVehicular.SelectedCells[5].Value.ToString();
        }


        
        // BOTON DE GUARDAR 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MtdMostrarVehiuclos();
            mtdCrearVehiculos();
        }




        // METODO DE ACTUALIZAR VEHICULOS Y BOTO DE ACTUALIZAR 
        private void bttonActualizarVehiculos_Click(object sender, EventArgs e)
        {
            try
            {
                int VehiculoID = int.Parse(txtIDVehiculo.Text);

                int.TryParse(txtAño.Text, out int Año);
                decimal.TryParse(txtPrecio.Text, out decimal Precio);

                cd_vehiculos.MtdActualizarVehiculos(VehiculoID, txtMarca.Text, txtModelo.Text, Año, Precio, cboxEstado.Text);

                MessageBox.Show("El VEHICULO se actualizó con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarVehiuclos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // METODO PARA ELIMINAR UN VEHICULO Y EL BOTON DE ELIMINAR.
        private void bttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                cd_vehiculos.CD_mtdEliminarVehiculos(int.Parse(txtIDVehiculo.Text));


                MessageBox.Show("El vEHICULO se elimino con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarVehiuclos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
