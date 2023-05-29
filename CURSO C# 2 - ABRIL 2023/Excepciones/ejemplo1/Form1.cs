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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;
           
            try
            {
                resultado = Calcular();
                btnCalcular.Text = "Resu= " + resultado;
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Error!"); 
            }
        }

        private int Calcular()
        {
            int a, b, c;
            try
            {
                
                a = int.Parse(txtNum1.Text);
                b = int.Parse(txtNum2.Text);
                c = a / b;
                return c; 
                
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
