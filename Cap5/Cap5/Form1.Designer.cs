namespace Cap5
{
    partial class FrmCine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCine));
            this.label1 = new System.Windows.Forms.Label();
            this.lblRazón = new System.Windows.Forms.Label();
            this.txtRazón = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.CboEdad = new System.Windows.Forms.ComboBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lvRegistrar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.lvEstadisticas = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.Niño = new System.Windows.Forms.PictureBox();
            this.JovenII = new System.Windows.Forms.PictureBox();
            this.AdultoI = new System.Windows.Forms.PictureBox();
            this.JovenI = new System.Windows.Forms.PictureBox();
            this.AdultoII = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Niño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JovenII)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdultoI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JovenI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdultoII)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control De Ventas De Boletos-Coorporativos";
            // 
            // lblRazón
            // 
            this.lblRazón.AutoSize = true;
            this.lblRazón.Location = new System.Drawing.Point(68, 51);
            this.lblRazón.Name = "lblRazón";
            this.lblRazón.Size = new System.Drawing.Size(70, 13);
            this.lblRazón.TabIndex = 1;
            this.lblRazón.Text = "Razón Social";
            // 
            // txtRazón
            // 
            this.txtRazón.Location = new System.Drawing.Point(34, 67);
            this.txtRazón.Name = "txtRazón";
            this.txtRazón.Size = new System.Drawing.Size(137, 20);
            this.txtRazón.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.CboEdad);
            this.groupBox1.Controls.Add(this.lblEdad);
            this.groupBox1.Location = new System.Drawing.Point(385, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro De Boletos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(344, 46);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(366, 22);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(247, 45);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(0, 13);
            this.lblCategoria.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(172, 45);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 13);
            this.lblPrecio.TabIndex = 2;
            // 
            // CboEdad
            // 
            this.CboEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEdad.FormattingEnabled = true;
            this.CboEdad.Items.AddRange(new object[] {
            "Niño",
            "JovenI",
            "JovenII",
            "AdultoI",
            "AdultoII"});
            this.CboEdad.Location = new System.Drawing.Point(6, 45);
            this.CboEdad.Name = "CboEdad";
            this.CboEdad.Size = new System.Drawing.Size(121, 21);
            this.CboEdad.TabIndex = 1;
            this.CboEdad.SelectedIndexChanged += new System.EventHandler(this.CboEdad_SelectedIndexChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(47, 23);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 0;
            this.lblEdad.Text = "Edad";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(613, 173);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 34);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lvRegistrar
            // 
            this.lvRegistrar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvRegistrar.GridLines = true;
            this.lvRegistrar.HideSelection = false;
            this.lvRegistrar.Location = new System.Drawing.Point(12, 228);
            this.lvRegistrar.Name = "lvRegistrar";
            this.lvRegistrar.Size = new System.Drawing.Size(776, 97);
            this.lvRegistrar.TabIndex = 5;
            this.lvRegistrar.UseCompatibleStateImageBehavior = false;
            this.lvRegistrar.View = System.Windows.Forms.View.Details;
            this.lvRegistrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvRegistrar_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Categoria";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio Unitario";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SubTotal";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Descuento";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Importe";
            this.columnHeader6.Width = 140;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(318, 332);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(207, 30);
            this.btnEstadisticas.TabIndex = 6;
            this.btnEstadisticas.Text = "Mostrar Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // lvEstadisticas
            // 
            this.lvEstadisticas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lvEstadisticas.GridLines = true;
            this.lvEstadisticas.HideSelection = false;
            this.lvEstadisticas.Location = new System.Drawing.Point(12, 366);
            this.lvEstadisticas.Name = "lvEstadisticas";
            this.lvEstadisticas.Size = new System.Drawing.Size(776, 97);
            this.lvEstadisticas.TabIndex = 7;
            this.lvEstadisticas.UseCompatibleStateImageBehavior = false;
            this.lvEstadisticas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Condicion";
            this.columnHeader7.Width = 420;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Valor";
            this.columnHeader8.Width = 420;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(669, 469);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Niño
            // 
            this.Niño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Niño.BackgroundImage")));
            this.Niño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Niño.Location = new System.Drawing.Point(195, 51);
            this.Niño.Name = "Niño";
            this.Niño.Size = new System.Drawing.Size(184, 139);
            this.Niño.TabIndex = 9;
            this.Niño.TabStop = false;
            this.Niño.Visible = false;
            // 
            // JovenII
            // 
            this.JovenII.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JovenII.BackgroundImage")));
            this.JovenII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JovenII.Location = new System.Drawing.Point(195, 51);
            this.JovenII.Name = "JovenII";
            this.JovenII.Size = new System.Drawing.Size(184, 139);
            this.JovenII.TabIndex = 10;
            this.JovenII.TabStop = false;
            this.JovenII.Visible = false;
            // 
            // AdultoI
            // 
            this.AdultoI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdultoI.BackgroundImage")));
            this.AdultoI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdultoI.Location = new System.Drawing.Point(195, 51);
            this.AdultoI.Name = "AdultoI";
            this.AdultoI.Size = new System.Drawing.Size(184, 139);
            this.AdultoI.TabIndex = 11;
            this.AdultoI.TabStop = false;
            this.AdultoI.Visible = false;
            // 
            // JovenI
            // 
            this.JovenI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JovenI.BackgroundImage")));
            this.JovenI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JovenI.Location = new System.Drawing.Point(195, 51);
            this.JovenI.Name = "JovenI";
            this.JovenI.Size = new System.Drawing.Size(184, 139);
            this.JovenI.TabIndex = 12;
            this.JovenI.TabStop = false;
            this.JovenI.Visible = false;
            // 
            // AdultoII
            // 
            this.AdultoII.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdultoII.BackgroundImage")));
            this.AdultoII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdultoII.Location = new System.Drawing.Point(195, 51);
            this.AdultoII.Name = "AdultoII";
            this.AdultoII.Size = new System.Drawing.Size(184, 139);
            this.AdultoII.TabIndex = 13;
            this.AdultoII.TabStop = false;
            this.AdultoII.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(456, 173);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 33);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categoria";
            // 
            // FrmCine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 497);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.AdultoII);
            this.Controls.Add(this.JovenI);
            this.Controls.Add(this.AdultoI);
            this.Controls.Add(this.JovenII);
            this.Controls.Add(this.Niño);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvEstadisticas);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.lvRegistrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRazón);
            this.Controls.Add(this.lblRazón);
            this.Controls.Add(this.label1);
            this.Name = "FrmCine";
            this.Text = "Control De Ventas De Boletos-Coorporativos";
            this.Load += new System.EventHandler(this.FrmCine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Niño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JovenII)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdultoI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JovenI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdultoII)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRazón;
        private System.Windows.Forms.TextBox txtRazón;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox CboEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListView lvRegistrar;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.ListView lvEstadisticas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.PictureBox Niño;
        private System.Windows.Forms.PictureBox JovenII;
        private System.Windows.Forms.PictureBox AdultoI;
        private System.Windows.Forms.PictureBox JovenI;
        private System.Windows.Forms.PictureBox AdultoII;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

