namespace WindowsFormsAppEjemplo
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxMostrarCombo = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.labelEvento = new System.Windows.Forms.Label();
            this.buttonGroupBox = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelDesktop = new System.Windows.Forms.Label();
            this.buttonEscritorio = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonDirectorioActual = new System.Windows.Forms.Button();
            this.buttonDirectorios = new System.Windows.Forms.Button();
            this.textBoxMultilineaDirectorio = new System.Windows.Forms.TextBox();
            this.buttonCrearDirectorio = new System.Windows.Forms.Button();
            this.textBoxDirectorio = new System.Windows.Forms.TextBox();
            this.buttonLeerArchivo = new System.Windows.Forms.Button();
            this.textBoxLeerArchivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar Titulo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxMostrarCombo
            // 
            this.checkBoxMostrarCombo.AutoSize = true;
            this.checkBoxMostrarCombo.Location = new System.Drawing.Point(21, 29);
            this.checkBoxMostrarCombo.Name = "checkBoxMostrarCombo";
            this.checkBoxMostrarCombo.Size = new System.Drawing.Size(97, 17);
            this.checkBoxMostrarCombo.TabIndex = 1;
            this.checkBoxMostrarCombo.Text = "Mostrar Combo";
            this.checkBoxMostrarCombo.UseVisualStyleBackColor = true;
            this.checkBoxMostrarCombo.CheckedChanged += new System.EventHandler(this.checkBoxMostrarCombo_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Opcion1",
            "Opcion2",
            "Opcion3"});
            this.comboBox1.Location = new System.Drawing.Point(139, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "-Seleccione Una Opcion-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el titulo del FORMULARIO:";
            this.label1.Leave += new System.EventHandler(this.label1_Leave);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(276, 14);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(190, 26);
            this.textBoxTitulo.TabIndex = 4;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoSize = true;
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelPrincipal.Controls.Add(this.labelEvento);
            this.panelPrincipal.Controls.Add(this.buttonGroupBox);
            this.panelPrincipal.Controls.Add(this.button1);
            this.panelPrincipal.Controls.Add(this.textBoxTitulo);
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPrincipal.Location = new System.Drawing.Point(22, 18);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(602, 89);
            this.panelPrincipal.TabIndex = 5;
            // 
            // labelEvento
            // 
            this.labelEvento.AutoSize = true;
            this.labelEvento.Location = new System.Drawing.Point(17, 53);
            this.labelEvento.Name = "labelEvento";
            this.labelEvento.Size = new System.Drawing.Size(168, 20);
            this.labelEvento.TabIndex = 6;
            this.labelEvento.Text = "Evento Boton Habilitar";
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Location = new System.Drawing.Point(482, 44);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Size = new System.Drawing.Size(102, 29);
            this.buttonGroupBox.TabIndex = 5;
            this.buttonGroupBox.Text = "Habilitar";
            this.buttonGroupBox.UseVisualStyleBackColor = true;
            this.buttonGroupBox.Click += new System.EventHandler(this.buttonGroupBox_Click);
            this.buttonGroupBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonGroupBox_MouseClick);
            this.buttonGroupBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonGroupBox_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.checkBoxMostrarCombo);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(22, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion General";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.dni});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 143);
            this.dataGridView1.TabIndex = 7;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(167, 547);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 178);
            this.panel1.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 529);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelPrincipal);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clase 11";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxLeerArchivo);
            this.tabPage2.Controls.Add(this.buttonLeerArchivo);
            this.tabPage2.Controls.Add(this.textBoxDirectorio);
            this.tabPage2.Controls.Add(this.buttonCrearDirectorio);
            this.tabPage2.Controls.Add(this.textBoxMultilineaDirectorio);
            this.tabPage2.Controls.Add(this.buttonDirectorios);
            this.tabPage2.Controls.Add(this.labelDesktop);
            this.tabPage2.Controls.Add(this.buttonEscritorio);
            this.tabPage2.Controls.Add(this.labelPath);
            this.tabPage2.Controls.Add(this.buttonDirectorioActual);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clase 12";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelDesktop
            // 
            this.labelDesktop.AutoSize = true;
            this.labelDesktop.Location = new System.Drawing.Point(210, 109);
            this.labelDesktop.Name = "labelDesktop";
            this.labelDesktop.Size = new System.Drawing.Size(36, 13);
            this.labelDesktop.TabIndex = 3;
            this.labelDesktop.Text = "PATH";
            // 
            // buttonEscritorio
            // 
            this.buttonEscritorio.Location = new System.Drawing.Point(21, 92);
            this.buttonEscritorio.Name = "buttonEscritorio";
            this.buttonEscritorio.Size = new System.Drawing.Size(133, 46);
            this.buttonEscritorio.TabIndex = 2;
            this.buttonEscritorio.Text = "Mostrar Escritorio";
            this.buttonEscritorio.UseVisualStyleBackColor = true;
            this.buttonEscritorio.Click += new System.EventHandler(this.buttonMisDocumentos_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(210, 45);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(36, 13);
            this.labelPath.TabIndex = 1;
            this.labelPath.Text = "PATH";
            // 
            // buttonDirectorioActual
            // 
            this.buttonDirectorioActual.Location = new System.Drawing.Point(21, 28);
            this.buttonDirectorioActual.Name = "buttonDirectorioActual";
            this.buttonDirectorioActual.Size = new System.Drawing.Size(133, 46);
            this.buttonDirectorioActual.TabIndex = 0;
            this.buttonDirectorioActual.Text = "Mostrar Directorio Actual";
            this.buttonDirectorioActual.UseVisualStyleBackColor = true;
            this.buttonDirectorioActual.Click += new System.EventHandler(this.buttonDirectorioActual_Click);
            // 
            // buttonDirectorios
            // 
            this.buttonDirectorios.Location = new System.Drawing.Point(21, 158);
            this.buttonDirectorios.Name = "buttonDirectorios";
            this.buttonDirectorios.Size = new System.Drawing.Size(133, 46);
            this.buttonDirectorios.TabIndex = 4;
            this.buttonDirectorios.Text = "Mostrar Directorio";
            this.buttonDirectorios.UseVisualStyleBackColor = true;
            this.buttonDirectorios.Click += new System.EventHandler(this.buttonDirectorios_Click);
            // 
            // textBoxMultilineaDirectorio
            // 
            this.textBoxMultilineaDirectorio.Location = new System.Drawing.Point(160, 158);
            this.textBoxMultilineaDirectorio.Multiline = true;
            this.textBoxMultilineaDirectorio.Name = "textBoxMultilineaDirectorio";
            this.textBoxMultilineaDirectorio.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMultilineaDirectorio.Size = new System.Drawing.Size(455, 46);
            this.textBoxMultilineaDirectorio.TabIndex = 5;
            // 
            // buttonCrearDirectorio
            // 
            this.buttonCrearDirectorio.Location = new System.Drawing.Point(386, 213);
            this.buttonCrearDirectorio.Name = "buttonCrearDirectorio";
            this.buttonCrearDirectorio.Size = new System.Drawing.Size(133, 46);
            this.buttonCrearDirectorio.TabIndex = 6;
            this.buttonCrearDirectorio.Text = "Crear Directorio";
            this.buttonCrearDirectorio.UseVisualStyleBackColor = true;
            this.buttonCrearDirectorio.Click += new System.EventHandler(this.buttonCrearDirectorio_Click);
            // 
            // textBoxDirectorio
            // 
            this.textBoxDirectorio.Location = new System.Drawing.Point(163, 227);
            this.textBoxDirectorio.Name = "textBoxDirectorio";
            this.textBoxDirectorio.Size = new System.Drawing.Size(207, 20);
            this.textBoxDirectorio.TabIndex = 7;
            // 
            // buttonLeerArchivo
            // 
            this.buttonLeerArchivo.Location = new System.Drawing.Point(21, 265);
            this.buttonLeerArchivo.Name = "buttonLeerArchivo";
            this.buttonLeerArchivo.Size = new System.Drawing.Size(133, 46);
            this.buttonLeerArchivo.TabIndex = 8;
            this.buttonLeerArchivo.Text = "Leer Archivo";
            this.buttonLeerArchivo.UseVisualStyleBackColor = true;
            this.buttonLeerArchivo.Click += new System.EventHandler(this.buttonLeerArchivo_Click);
            // 
            // textBoxLeerArchivo
            // 
            this.textBoxLeerArchivo.Location = new System.Drawing.Point(163, 265);
            this.textBoxLeerArchivo.Multiline = true;
            this.textBoxLeerArchivo.Name = "textBoxLeerArchivo";
            this.textBoxLeerArchivo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLeerArchivo.Size = new System.Drawing.Size(443, 46);
            this.textBoxLeerArchivo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre del Directorio:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(667, 749);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario de Ejemplo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxMostrarCombo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.Label labelEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonDirectorioActual;
        private System.Windows.Forms.Label labelDesktop;
        private System.Windows.Forms.Button buttonEscritorio;
        private System.Windows.Forms.Button buttonDirectorios;
        private System.Windows.Forms.TextBox textBoxMultilineaDirectorio;
        private System.Windows.Forms.TextBox textBoxDirectorio;
        private System.Windows.Forms.Button buttonCrearDirectorio;
        private System.Windows.Forms.TextBox textBoxLeerArchivo;
        private System.Windows.Forms.Button buttonLeerArchivo;
        private System.Windows.Forms.Label label2;
    }
}

