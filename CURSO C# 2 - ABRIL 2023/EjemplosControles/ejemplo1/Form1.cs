using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
          elementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxColor.Items.Add("Negro");
            comboBoxColor.Items.Add("Fucsia");
            comboBoxColor.Items.Add("Cian");
        }


        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dateTimePickerFechaNacimiento.Value;
            //operador ternario--> if en una sola linea
            string princesas = checkBoxPrincesas.Checked == true ? "Le gustan las princesas" : "No le gustan las princesas";
            string tipo;
            if (rbtCenicienta.Checked)
            {
                tipo = "Cenicienta";
            }
            else if (rbtAriel.Checked)
            {
                tipo = "Ariel";
            }
            else {
                tipo = "Rapunzel";
            }

            string colorFavorito = comboBoxColor.SelectedItem.ToString();
            string numeroFavorito = numericUpDown1.Value.ToString();

            MessageBox.Show(" Nombre " + nombre + " Fecha " + fecha + " Princesas " + princesas + " Tipo " + tipo); 
        }
    }
}
