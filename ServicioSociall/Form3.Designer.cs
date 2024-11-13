namespace ServicioSociall
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvprincipal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.btnBorrarFila = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnExpedirTarjeta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvprincipal
            // 
            this.dgvprincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprincipal.Location = new System.Drawing.Point(31, 96);
            this.dgvprincipal.Margin = new System.Windows.Forms.Padding(4);
            this.dgvprincipal.Name = "dgvprincipal";
            this.dgvprincipal.RowHeadersWidth = 51;
            this.dgvprincipal.Size = new System.Drawing.Size(1028, 537);
            this.dgvprincipal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(479, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de servicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(31, 55);
            this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(276, 22);
            this.txtBuscarNombre.TabIndex = 5;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.Location = new System.Drawing.Point(1119, 159);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 116);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.btnGuardarCambios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCambios.Location = new System.Drawing.Point(1119, 482);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(135, 102);
            this.btnGuardarCambios.TabIndex = 8;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnBorrarFila
            // 
            this.btnBorrarFila.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBorrarFila.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBorrarFila.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnBorrarFila.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnBorrarFila.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrarFila.Location = new System.Drawing.Point(1119, 330);
            this.btnBorrarFila.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarFila.Name = "btnBorrarFila";
            this.btnBorrarFila.Size = new System.Drawing.Size(135, 106);
            this.btnBorrarFila.TabIndex = 9;
            this.btnBorrarFila.Text = "Borrar Fila";
            this.btnBorrarFila.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrarFila.UseVisualStyleBackColor = true;
            this.btnBorrarFila.Click += new System.EventHandler(this.btnBorrarFila_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 30;
            this.btnBuscar.Location = new System.Drawing.Point(340, 46);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 43);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExpedirTarjeta
            // 
            this.btnExpedirTarjeta.Image = global::ServicioSociall.Properties.Resources.archivo_pdf__2_;
            this.btnExpedirTarjeta.ImageKey = "(ninguno)";
            this.btnExpedirTarjeta.Location = new System.Drawing.Point(1119, 39);
            this.btnExpedirTarjeta.Name = "btnExpedirTarjeta";
            this.btnExpedirTarjeta.Size = new System.Drawing.Size(135, 91);
            this.btnExpedirTarjeta.TabIndex = 11;
            this.btnExpedirTarjeta.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1305, 703);
            this.Controls.Add(this.btnExpedirTarjeta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrarFila);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvprincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvprincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvprincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
        private FontAwesome.Sharp.IconButton btnBorrarFila;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Button btnExpedirTarjeta;
    }
}
