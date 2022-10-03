namespace Farmacia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGrilla = new System.Windows.Forms.Button();
            this.cmbNit = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.grdFarmaceuticos = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.staEstado = new System.Windows.Forms.StatusStrip();
            this.slabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.slabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.slabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slabelCi = new System.Windows.Forms.ToolStripStatusLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFarmaceuticos)).BeginInit();
            this.staEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.btnIngreso);
            this.tabPage1.Controls.Add(this.txtpassword);
            this.tabPage1.Controls.Add(this.txtUsuario);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Acceso";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(209, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 38);
            this.label9.TabIndex = 6;
            this.label9.Text = "ACCESO AL SISTEMA";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(414, 277);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(209, 277);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(94, 29);
            this.btnIngreso.TabIndex = 4;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(339, 214);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(169, 27);
            this.txtpassword.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(339, 164);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(169, 27);
            this.txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(209, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.btnGrilla);
            this.tabPage2.Controls.Add(this.cmbNit);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txtCantidad);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cmbProducto);
            this.tabPage2.Controls.Add(this.txtApellido);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.btnFactura);
            this.tabPage2.Controls.Add(this.btnAgregar);
            this.tabPage2.Controls.Add(this.grdDetalle);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cajero";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGrilla
            // 
            this.btnGrilla.Location = new System.Drawing.Point(608, 118);
            this.btnGrilla.Name = "btnGrilla";
            this.btnGrilla.Size = new System.Drawing.Size(94, 29);
            this.btnGrilla.TabIndex = 16;
            this.btnGrilla.Text = "Agregar";
            this.btnGrilla.UseVisualStyleBackColor = true;
            this.btnGrilla.Click += new System.EventHandler(this.btnGrilla_Click);
            // 
            // cmbNit
            // 
            this.cmbNit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNit.FormattingEnabled = true;
            this.cmbNit.Location = new System.Drawing.Point(99, 36);
            this.cmbNit.Name = "cmbNit";
            this.cmbNit.Size = new System.Drawing.Size(151, 28);
            this.cmbNit.TabIndex = 15;
            this.cmbNit.SelectedValueChanged += new System.EventHandler(this.cmbNit_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(388, 120);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(68, 27);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(291, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 38);
            this.label8.TabIndex = 13;
            this.label8.Text = "FACTURA";
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(99, 119);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(199, 28);
            this.cmbProducto.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(388, 79);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(185, 27);
            this.txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(199, 27);
            this.txtNombre.TabIndex = 9;
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(243, 368);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(127, 29);
            this.btnFactura.TabIndex = 7;
            this.btnFactura.Text = "Generar Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(11, 368);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Grabar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicamento,
            this.Cantidad});
            this.grdDetalle.Location = new System.Drawing.Point(11, 162);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            this.grdDetalle.RowHeadersWidth = 51;
            this.grdDetalle.RowTemplate.Height = 29;
            this.grdDetalle.Size = new System.Drawing.Size(691, 188);
            this.grdDetalle.TabIndex = 5;
            // 
            // Medicamento
            // 
            this.Medicamento.HeaderText = "Medicamento";
            this.Medicamento.MinimumWidth = 6;
            this.Medicamento.Name = "Medicamento";
            this.Medicamento.ReadOnly = true;
            this.Medicamento.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "NIT:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.btnRegistrar);
            this.tabPage3.Controls.Add(this.btnActualizar);
            this.tabPage3.Controls.Add(this.btnEliminar);
            this.tabPage3.Controls.Add(this.btnCargar);
            this.tabPage3.Controls.Add(this.grdFarmaceuticos);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(723, 415);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dueño";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(337, 360);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 29);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Insertar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(225, 360);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(94, 29);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(116, 360);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(16, 360);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(94, 29);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // grdFarmaceuticos
            // 
            this.grdFarmaceuticos.AllowUserToOrderColumns = true;
            this.grdFarmaceuticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFarmaceuticos.Location = new System.Drawing.Point(16, 52);
            this.grdFarmaceuticos.Name = "grdFarmaceuticos";
            this.grdFarmaceuticos.RowHeadersWidth = 51;
            this.grdFarmaceuticos.RowTemplate.Height = 29;
            this.grdFarmaceuticos.Size = new System.Drawing.Size(686, 279);
            this.grdFarmaceuticos.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(85, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(506, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "ADMINISTRACION DE USUARIOS Y REPORTES";
            // 
            // staEstado
            // 
            this.staEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slabel,
            this.slabelUsuario,
            this.slabel2,
            this.slabelCi});
            this.staEstado.Location = new System.Drawing.Point(0, 449);
            this.staEstado.Name = "staEstado";
            this.staEstado.Size = new System.Drawing.Size(731, 26);
            this.staEstado.TabIndex = 1;
            this.staEstado.Text = "statusStrip1";
            // 
            // slabel
            // 
            this.slabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.slabel.Name = "slabel";
            this.slabel.Size = new System.Drawing.Size(67, 20);
            this.slabel.Text = "Usuario:";
            // 
            // slabelUsuario
            // 
            this.slabelUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.slabelUsuario.Name = "slabelUsuario";
            this.slabelUsuario.Size = new System.Drawing.Size(0, 20);
            this.slabelUsuario.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // slabel2
            // 
            this.slabel2.Name = "slabel2";
            this.slabel2.Size = new System.Drawing.Size(58, 20);
            this.slabel2.Text = "Cedula:";
            // 
            // slabelCi
            // 
            this.slabelCi.Name = "slabelCi";
            this.slabelCi.Size = new System.Drawing.Size(0, 20);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(497, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Reportes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 475);
            this.Controls.Add(this.staEstado);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFarmaceuticos)).EndInit();
            this.staEstado.ResumeLayout(false);
            this.staEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnSalir;
        private Button btnIngreso;
        private TextBox txtpassword;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
        private TabPage tabPage3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnFactura;
        private Button btnAgregar;
        private DataGridView grdDetalle;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label8;
        private TextBox txtCantidad;
        private ComboBox cmbProducto;
        private Label label9;
        private Label label10;
        private Button button1;
        private StatusStrip staEstado;
        private ToolStripStatusLabel slabel;
        private ToolStripStatusLabel slabelUsuario;
        private Button btnCargar;
        private DataGridView grdFarmaceuticos;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnRegistrar;
        private Button button2;
        private ComboBox cmbNit;
        private Button btnGrilla;
        private DataGridViewTextBoxColumn Medicamento;
        private DataGridViewTextBoxColumn Cantidad;
        private ToolStripStatusLabel slabel2;
        private ToolStripStatusLabel slabelCi;
        private Button button3;
    }
}