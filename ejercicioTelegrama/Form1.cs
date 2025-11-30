using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int num, i;
            string resultado = "";

            try
            {
                num = int.Parse(txtNum.Text);

                if (num < 1)
                {
                    MessageBox.Show("Elige un número que sea mayor a 0");
                    txtNum.Clear();
                    return;
                }

                for (i = 1; i <= 10; i++)
                {
                    resultado += $"{num} * {i} = {num * i}\n";
                }
                txtNum.Clear();
                txtNum.Focus();
                MessageBox.Show($"Tabla del {num}\n{resultado}");

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {

            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
