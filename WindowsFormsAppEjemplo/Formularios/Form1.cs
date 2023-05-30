using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsAppEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Formulario cargado...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = textBoxTitulo.Text;
        }

        private void checkBoxMostrarCombo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarCombo.Checked)
            {
                comboBox1.Visible = true;
            }
            else {
                comboBox1.Visible = false;
            }
        }

        private void buttonGroupBox_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            labelEvento.Text = "Click";   
        }

        private void label1_Leave(object sender, EventArgs e)
        {

        }

        private void buttonGroupBox_MouseClick(object sender, MouseEventArgs e)
        {
            labelEvento.Text = "MouseClick";
        }

        private void buttonGroupBox_MouseDown(object sender, MouseEventArgs e)
        {
            labelEvento.Text = "MouseDown";
        }

        private void buttonGroupBox_MouseUp(object sender, MouseEventArgs e)
        {
            labelEvento.Text = "MouseUp";
        }

        private void buttonDirectorioActual_Click(object sender, EventArgs e)
        {
            //mostramos en el LABEL el PATH del directorio actual
            labelPath.Text = Directory.GetCurrentDirectory();
        }

        private void buttonMisDocumentos_Click(object sender, EventArgs e)
        {
            //mostramos en el LABEL el PATH del escritorio de windows
            labelDesktop.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void buttonDirectorios_Click(object sender, EventArgs e)
        {
            //nos paramos en la carpeta \STORES
            string path = Directory.GetCurrentDirectory()+"\\stores\\";
            //IEnumerable<String> listOfDirectories = Directory.EnumerateDirectories(path);

            //recuperamos todos los archivos TXT de todos los SUBDIRECTORIOS
            IEnumerable<String> listOfDirectories = Directory.EnumerateFiles(path,"*.tXt", SearchOption.AllDirectories);

            foreach (var item in listOfDirectories)
            {
                //mostramos un listado de los archivos encontrados
                Console.WriteLine(item);
                textBoxMultilineaDirectorio.Text += item + Environment.NewLine;
            }

        }

        private void buttonCrearDirectorio_Click(object sender, EventArgs e)
        {
            string path = "";
            if (textBoxDirectorio.Text!="") {
                //creamos un DIRECTORIO nuevo con el nombre ingresado en el textbox dentro de la carpeta STORES
                path = Path.Combine($".{Path.DirectorySeparatorChar}stores{Path.DirectorySeparatorChar}", textBoxDirectorio.Text);
                Directory.CreateDirectory(path);
            }
        }

        private void buttonLeerArchivo_Click(object sender, EventArgs e)
        {
            //leemos el contenido del ARCHIVO SALES.JSON de la carpeta \STORES\201 y lo mostramos en el textBox
            string path = $".{Path.DirectorySeparatorChar}stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json";
            textBoxLeerArchivo.Text = File.ReadAllText(path);
        }
    }
}
