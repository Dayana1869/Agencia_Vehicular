namespace CapaPresentacion
{
    partial class FormCarros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarros));
            System.Windows.Forms.Button btnGuardar;
            this.bntSALIR = new System.Windows.Forms.Button();
            this.dgvVehicular = new System.Windows.Forms.DataGridView();
            this.gboxClientes = new System.Windows.Forms.GroupBox();
            this.btnLIMPIAR = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnACTUALIZAR = new System.Windows.Forms.Button();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDVehiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicular)).BeginInit();
            this.gboxClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntSALIR
            // 
            this.bntSALIR.BackColor = System.Drawing.Color.Bisque;
            this.bntSALIR.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSALIR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(34)))), ((int)(((byte)(118)))));
            this.bntSALIR.Image = ((System.Drawing.Image)(resources.GetObject("bntSALIR.Image")));
            this.bntSALIR.Location = new System.Drawing.Point(369, 490);
            this.bntSALIR.Name = "bntSALIR";
            this.bntSALIR.Size = new System.Drawing.Size(43, 45);
            this.bntSALIR.TabIndex = 29;
            this.bntSALIR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntSALIR.UseVisualStyleBackColor = false;
            // 
            // dgvVehicular
            // 
            this.dgvVehicular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVehicular.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvVehicular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicular.GridColor = System.Drawing.Color.DarkGray;
            this.dgvVehicular.Location = new System.Drawing.Point(1, 219);
            this.dgvVehicular.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVehicular.Name = "dgvVehicular";
            this.dgvVehicular.ReadOnly = true;
            this.dgvVehicular.RowHeadersWidth = 51;
            this.dgvVehicular.RowTemplate.Height = 24;
            this.dgvVehicular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicular.Size = new System.Drawing.Size(866, 266);
            this.dgvVehicular.TabIndex = 28;
            this.dgvVehicular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicular_CellClick);
            // 
            // gboxClientes
            // 
            this.gboxClientes.Controls.Add(this.btnLIMPIAR);
            this.gboxClientes.Controls.Add(this.txtPrecio);
            this.gboxClientes.Controls.Add(this.label5);
            this.gboxClientes.Controls.Add(this.btnELIMINAR);
            this.gboxClientes.Controls.Add(this.btnACTUALIZAR);
            this.gboxClientes.Controls.Add(btnGuardar);
            this.gboxClientes.Controls.Add(this.cboxEstado);
            this.gboxClientes.Controls.Add(this.label8);
            this.gboxClientes.Controls.Add(this.label7);
            this.gboxClientes.Controls.Add(this.txtAño);
            this.gboxClientes.Controls.Add(this.label6);
            this.gboxClientes.Controls.Add(this.txtModelo);
            this.gboxClientes.Controls.Add(this.label3);
            this.gboxClientes.Controls.Add(this.txtMarca);
            this.gboxClientes.Controls.Add(this.label2);
            this.gboxClientes.Controls.Add(this.txtIDVehiculo);
            this.gboxClientes.Controls.Add(this.label1);
            this.gboxClientes.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(34)))), ((int)(((byte)(118)))));
            this.gboxClientes.Location = new System.Drawing.Point(1, 11);
            this.gboxClientes.Margin = new System.Windows.Forms.Padding(2);
            this.gboxClientes.Name = "gboxClientes";
            this.gboxClientes.Padding = new System.Windows.Forms.Padding(2);
            this.gboxClientes.Size = new System.Drawing.Size(866, 204);
            this.gboxClientes.TabIndex = 27;
            this.gboxClientes.TabStop = false;
            this.gboxClientes.Text = "DATOS ESTUDUANTES";
            // 
            // btnLIMPIAR
            // 
            this.btnLIMPIAR.Image = ((System.Drawing.Image)(resources.GetObject("btnLIMPIAR.Image")));
            this.btnLIMPIAR.Location = new System.Drawing.Point(640, 128);
            this.btnLIMPIAR.Name = "btnLIMPIAR";
            this.btnLIMPIAR.Size = new System.Drawing.Size(58, 65);
            this.btnLIMPIAR.TabIndex = 29;
            this.btnLIMPIAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLIMPIAR.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Bisque;
            this.txtPrecio.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(453, 81);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(151, 24);
            this.txtPrecio.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "VehiculoID";
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("btnELIMINAR.Image")));
            this.btnELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnELIMINAR.Location = new System.Drawing.Point(739, 128);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(112, 44);
            this.btnELIMINAR.TabIndex = 22;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            // 
            // btnACTUALIZAR
            // 
            this.btnACTUALIZAR.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACTUALIZAR.Image = ((System.Drawing.Image)(resources.GetObject("btnACTUALIZAR.Image")));
            this.btnACTUALIZAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnACTUALIZAR.Location = new System.Drawing.Point(739, 76);
            this.btnACTUALIZAR.Name = "btnACTUALIZAR";
            this.btnACTUALIZAR.Size = new System.Drawing.Size(112, 44);
            this.btnACTUALIZAR.TabIndex = 21;
            this.btnACTUALIZAR.Text = "Actualizar";
            this.btnACTUALIZAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnACTUALIZAR.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnGuardar.Location = new System.Drawing.Point(739, 26);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(112, 45);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboxEstado
            // 
            this.cboxEstado.BackColor = System.Drawing.Color.Bisque;
            this.cboxEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(34)))), ((int)(((byte)(118)))));
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxEstado.Location = new System.Drawing.Point(453, 128);
            this.cboxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(148, 28);
            this.cboxEstado.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Precio";
            // 
            // txtAño
            // 
            this.txtAño.BackColor = System.Drawing.Color.Bisque;
            this.txtAño.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.Location = new System.Drawing.Point(456, 39);
            this.txtAño.Margin = new System.Windows.Forms.Padding(2);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(148, 24);
            this.txtAño.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(361, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Año";
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.Bisque;
            this.txtModelo.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(123, 120);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(195, 24);
            this.txtModelo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.Bisque;
            this.txtMarca.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(123, 81);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(195, 24);
            this.txtMarca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // txtIDVehiculo
            // 
            this.txtIDVehiculo.BackColor = System.Drawing.Color.Bisque;
            this.txtIDVehiculo.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVehiculo.Location = new System.Drawing.Point(123, 38);
            this.txtIDVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDVehiculo.Name = "txtIDVehiculo";
            this.txtIDVehiculo.Size = new System.Drawing.Size(102, 24);
            this.txtIDVehiculo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // FormCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 538);
            this.Controls.Add(this.bntSALIR);
            this.Controls.Add(this.dgvVehicular);
            this.Controls.Add(this.gboxClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCarros";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormCarros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicular)).EndInit();
            this.gboxClientes.ResumeLayout(false);
            this.gboxClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntSALIR;
        private System.Windows.Forms.DataGridView dgvVehicular;
        private System.Windows.Forms.GroupBox gboxClientes;
        private System.Windows.Forms.Button btnLIMPIAR;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnACTUALIZAR;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDVehiculo;
        private System.Windows.Forms.Label label1;
    }
}

