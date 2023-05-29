using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
