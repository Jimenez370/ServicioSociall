namespace ServicioSociall
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panelmenulateral = new System.Windows.Forms.Panel();
            this.PersonasenServicioPanel = new FontAwesome.Sharp.IconButton();
            this.FormularioRegistroPanel = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.botonmaximizar = new FontAwesome.Sharp.IconButton();
            this.botonminimizar = new FontAwesome.Sharp.IconButton();
            this.botoncerrar = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panelmenulateral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Panelmenulateral
            // 
            this.Panelmenulateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Panelmenulateral.Controls.Add(this.PersonasenServicioPanel);
            this.Panelmenulateral.Controls.Add(this.FormularioRegistroPanel);
            this.Panelmenulateral.Controls.Add(this.panel1);
            this.Panelmenulateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panelmenulateral.Location = new System.Drawing.Point(0, 0);
            this.Panelmenulateral.Name = "Panelmenulateral";
            this.Panelmenulateral.Size = new System.Drawing.Size(200, 571);
            this.Panelmenulateral.TabIndex = 0;
            // 
            // PersonasenServicioPanel
            // 
            this.PersonasenServicioPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonasenServicioPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PersonasenServicioPanel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PersonasenServicioPanel.FlatAppearance.BorderSize = 0;
            this.PersonasenServicioPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonasenServicioPanel.ForeColor = System.Drawing.Color.White;
            this.PersonasenServicioPanel.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            this.PersonasenServicioPanel.IconColor = System.Drawing.Color.White;
            this.PersonasenServicioPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PersonasenServicioPanel.Location = new System.Drawing.Point(0, 160);
            this.PersonasenServicioPanel.Name = "PersonasenServicioPanel";
            this.PersonasenServicioPanel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.PersonasenServicioPanel.Size = new System.Drawing.Size(200, 60);
            this.PersonasenServicioPanel.TabIndex = 7;
            this.PersonasenServicioPanel.Text = "Personas en Servicio";
            this.PersonasenServicioPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PersonasenServicioPanel.UseVisualStyleBackColor = false;
            this.PersonasenServicioPanel.Click += new System.EventHandler(this.PersonasenServicioPanel_Click);
            // 
            // FormularioRegistroPanel
            // 
            this.FormularioRegistroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormularioRegistroPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.FormularioRegistroPanel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FormularioRegistroPanel.FlatAppearance.BorderSize = 0;
            this.FormularioRegistroPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormularioRegistroPanel.ForeColor = System.Drawing.Color.White;
            this.FormularioRegistroPanel.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.FormularioRegistroPanel.IconColor = System.Drawing.Color.White;
            this.FormularioRegistroPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FormularioRegistroPanel.Location = new System.Drawing.Point(0, 100);
            this.FormularioRegistroPanel.Name = "FormularioRegistroPanel";
            this.FormularioRegistroPanel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.FormularioRegistroPanel.Size = new System.Drawing.Size(200, 60);
            this.FormularioRegistroPanel.TabIndex = 0;
            this.FormularioRegistroPanel.Text = "Formulario Registro";
            this.FormularioRegistroPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FormularioRegistroPanel.UseVisualStyleBackColor = false;
            this.FormularioRegistroPanel.Click += new System.EventHandler(this.FormularioRegistroPanel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(197, 97);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.panelTitleBar);
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Location = new System.Drawing.Point(197, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(979, 571);
            this.panelChildForm.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelTitleBar.Controls.Add(this.botonmaximizar);
            this.panelTitleBar.Controls.Add(this.botonminimizar);
            this.panelTitleBar.Controls.Add(this.botoncerrar);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(979, 51);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // botonmaximizar
            // 
            this.botonmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonmaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonmaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonmaximizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.botonmaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.botonmaximizar.IconColor = System.Drawing.Color.White;
            this.botonmaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonmaximizar.IconSize = 15;
            this.botonmaximizar.Location = new System.Drawing.Point(889, 0);
            this.botonmaximizar.Name = "botonmaximizar";
            this.botonmaximizar.Size = new System.Drawing.Size(42, 30);
            this.botonmaximizar.TabIndex = 4;
            this.botonmaximizar.UseVisualStyleBackColor = true;
            this.botonmaximizar.Click += new System.EventHandler(this.botonmaximizar_Click);
            // 
            // botonminimizar
            // 
            this.botonminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonminimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonminimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.botonminimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.botonminimizar.IconColor = System.Drawing.Color.White;
            this.botonminimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonminimizar.IconSize = 15;
            this.botonminimizar.Location = new System.Drawing.Point(841, 0);
            this.botonminimizar.Name = "botonminimizar";
            this.botonminimizar.Size = new System.Drawing.Size(42, 30);
            this.botonminimizar.TabIndex = 3;
            this.botonminimizar.UseVisualStyleBackColor = true;
            this.botonminimizar.Click += new System.EventHandler(this.botonminimizar_Click);
            // 
            // botoncerrar
            // 
            this.botoncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botoncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.botoncerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.botoncerrar.IconColor = System.Drawing.Color.White;
            this.botoncerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botoncerrar.IconSize = 15;
            this.botoncerrar.Location = new System.Drawing.Point(937, 0);
            this.botoncerrar.Name = "botoncerrar";
            this.botoncerrar.Size = new System.Drawing.Size(42, 30);
            this.botoncerrar.TabIndex = 2;
            this.botoncerrar.UseVisualStyleBackColor = true;
            this.botoncerrar.Click += new System.EventHandler(this.botoncerrar_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(45, 30);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "label1";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(280, 193);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(413, 157);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1176, 571);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.Panelmenulateral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panelmenulateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panelmenulateral;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton FormularioRegistroPanel;
        private FontAwesome.Sharp.IconButton PersonasenServicioPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton botonminimizar;
        private FontAwesome.Sharp.IconButton botoncerrar;
        private FontAwesome.Sharp.IconButton botonmaximizar;
    }
}

