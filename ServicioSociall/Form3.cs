using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using FontAwesome.Sharp; // Asegúrate de importar FontAwesome

namespace ServicioSociall
{
    public partial class Form3 : Form
    {
        private string connectionString = "Server=localhost;Database=ServicioSocial;Uid=root;Pwd=Greci@Esponda;";

        public Form3()
        {
            InitializeComponent();
            LoadData();
            dgvprincipal.ReadOnly = true; // Inicialmente el DataGridView es de solo lectura
        }

        private void LoadData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Usuarios";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvprincipal.DataSource = dataTable;
                    FormatDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

        private void FormatDataGridView()
        {
            // Usamos `System.Drawing.Font` explícitamente para evitar la ambigüedad
            dgvprincipal.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            dgvprincipal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgvprincipal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvprincipal.EnableHeadersVisualStyles = false;

            dgvprincipal.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            dgvprincipal.DefaultCellStyle.BackColor = Color.LightGray;
            dgvprincipal.DefaultCellStyle.ForeColor = Color.Black;
            dgvprincipal.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 220, 220);
            dgvprincipal.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvprincipal.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            dgvprincipal.BorderStyle = BorderStyle.None;
            dgvprincipal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvprincipal.GridColor = Color.Gray;

            dgvprincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvprincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvprincipal.AllowUserToAddRows = false;

            if (dgvprincipal.Columns["FechaRegistro"] != null)
                dgvprincipal.Columns["FechaRegistro"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (dgvprincipal.Columns["UsuarioID"] != null)
                dgvprincipal.Columns["UsuarioID"].Visible = false;

            dgvprincipal.RowTemplate.Height = 30;
        }


        private void dgvprincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvprincipal.CurrentRow != null)
            {
                dgvprincipal.ReadOnly = false; // Activa la edición en el DataGridView
                dgvprincipal.BeginEdit(true);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.");
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (dgvprincipal.CurrentRow != null)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Usuarios SET NombreCompleto = @NombreCompleto, CorreoElectronico = @CorreoElectronico, " +
                                       "Telefono = @Telefono, Matricula = @Matricula, Estatus = @Estatus WHERE UsuarioID = @UsuarioID";
                        MySqlCommand command = new MySqlCommand(query, connection);

                        command.Parameters.AddWithValue("@NombreCompleto", dgvprincipal.CurrentRow.Cells["NombreCompleto"].Value);
                        command.Parameters.AddWithValue("@CorreoElectronico", dgvprincipal.CurrentRow.Cells["CorreoElectronico"].Value);
                        command.Parameters.AddWithValue("@Telefono", dgvprincipal.CurrentRow.Cells["Telefono"].Value);
                        command.Parameters.AddWithValue("@Matricula", dgvprincipal.CurrentRow.Cells["Matricula"].Value);
                        command.Parameters.AddWithValue("@Estatus", dgvprincipal.CurrentRow.Cells["Estatus"].Value);
                        command.Parameters.AddWithValue("@UsuarioID", dgvprincipal.CurrentRow.Cells["UsuarioID"].Value);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Cambios guardados exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar cambios: " + ex.Message);
                }
                finally
                {
                    LoadData();
                    dgvprincipal.ReadOnly = true; // Desactiva la edición después de guardar los cambios
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para guardar cambios.");
            }
        }

        private void btnBorrarFila_Click(object sender, EventArgs e)
        {
            if (dgvprincipal.CurrentRow != null)
            {
                var result = MessageBox.Show("¿Estás seguro de que deseas borrar esta fila?", "Confirmar Borrado", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            string query = "DELETE FROM Usuarios WHERE UsuarioID = @UsuarioID";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@UsuarioID", dgvprincipal.CurrentRow.Cells["UsuarioID"].Value);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Fila eliminada exitosamente.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al borrar fila: " + ex.Message);
                    }
                    finally
                    {
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para borrar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBusqueda = txtBuscarNombre.Text.Trim();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Usuarios WHERE NombreCompleto LIKE @NombreBusqueda";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@NombreBusqueda", "%" + nombreBusqueda + "%");

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvprincipal.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar datos: " + ex.Message);
                }
            }
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExpedirTarjeta_Click(object sender, EventArgs e)
        {
            if (dgvprincipal.CurrentRow != null)
            {
                // Datos de la fila seleccionada
                string nombre = dgvprincipal.CurrentRow.Cells["NombreCompleto"].Value.ToString();
                string correo = dgvprincipal.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
                string telefono = dgvprincipal.CurrentRow.Cells["Telefono"].Value.ToString();
                string matricula = dgvprincipal.CurrentRow.Cells["Matricula"].Value.ToString();
                string estatus = dgvprincipal.CurrentRow.Cells["Estatus"].Value.ToString();

                // Ruta y nombre del archivo PDF
                string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{nombre}_Tarjeta.pdf");

                // Crear el documento PDF
                Document doc = new Document();
                try
                {
                    PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
                    doc.Open();

                    // Añadir contenido al PDF
                    doc.Add(new Paragraph("Tarjeta de Servicio"));
                    doc.Add(new Paragraph(" "));
                    doc.Add(new Paragraph($"Nombre Completo: {nombre}"));
                    doc.Add(new Paragraph($"Correo Electrónico: {correo}"));
                    doc.Add(new Paragraph($"Teléfono: {telefono}"));
                    doc.Add(new Paragraph($"Matrícula: {matricula}"));
                    doc.Add(new Paragraph($"Estatus: {estatus}"));
                    doc.Add(new Paragraph(" "));
                    doc.Add(new Paragraph("Fecha de Emisión: " + DateTime.Now.ToString("dd/MM/yyyy")));

                    MessageBox.Show("Tarjeta expedida y guardada en el escritorio.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al expedir tarjeta: " + ex.Message);
                }
                finally
                {
                    doc.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para expedir la tarjeta.");
            }
        }
    }
}
