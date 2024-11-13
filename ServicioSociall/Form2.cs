using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ServicioSociall
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private bool ValidarTelefono(string telefono)
        {
            return Regex.IsMatch(telefono, @"^\d{10}$");
        }

        private bool ValidarNombre(string nombre)
        {
            // verifica que no este vacío y que contenga solo letras y espacios
            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\s]+$";
            return !string.IsNullOrWhiteSpace(nombre) && Regex.IsMatch(nombre, patron);
        }


        private void btguardar_Click(object sender, EventArgs e)
        {
            // obtiene los datos de los campos de texto
            string NombreCompleto = tbnombre.Text.Trim();
            string CorreoElectronico = tbcorreo.Text.Trim();
            string Telefono = tbtelefono.Text.Trim();
            string Matricula = tbmatricula.Text.Trim();
            DateTime FechaRegistro = dtfecha.Value;
            string Estatus = tbestatus.Text.Trim();

            // validar que los campos no esten vacios
            if (string.IsNullOrWhiteSpace(NombreCompleto) || string.IsNullOrWhiteSpace(Matricula) || string.IsNullOrWhiteSpace(Telefono))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // valida el campo de teléfono
            if (!ValidarTelefono(Telefono))
            {
                MessageBox.Show("El número de teléfono debe contener exactamente 10 dígitos.", "Teléfono inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nombre = tbnombre.Text.Trim();

            if (!ValidarNombre(nombre))
            {
                MessageBox.Show("El nombre debe contener solo letras y espacios, y no puede estar vacío.",
                                "Nombre inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // si el nombre es valido, continua con el proceso
            MessageBox.Show("El nombre es válido.", "Validación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // definir la cadena de conexión con MySQL
            string connectionString = "Server=localhost; Database=serviciosocial; Uid=root; Pwd=Greci@Esponda;";

            // crear la consulta SQL para insertar los datos
            string query = @"INSERT INTO usuarios(NombreCompleto, CorreoElectronico, Telefono, Matricula, FechaRegistro, Estatus)
                             VALUES (@NombreCompleto, @CorreoElectronico, @Telefono, @Matricula, @FechaRegistro, @Estatus);";

            // establece la conexión y ejecutar la consulta
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                        cmd.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
                        cmd.Parameters.AddWithValue("@Telefono", Telefono);
                        cmd.Parameters.AddWithValue("@Matricula", Matricula);
                        cmd.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
                        cmd.Parameters.AddWithValue("@Estatus", Estatus);

                        // ejecuta la consulta
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // verificar si la insercion fue exito
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos guardados exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // limpia los campos despues de guardarlos
            tbnombre.Clear();
            tbcorreo.Clear();
            tbtelefono.Clear();
            tbmatricula.Clear();
            tbestatus.Clear();
            dtfecha.Value = DateTime.Today;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}