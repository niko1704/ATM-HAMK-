using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pankkiohjelma
{
    public partial class talletusform : Form
    {
        public talletusform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int talletus = Convert.ToInt32(textBox1.Text);
            int uusi = Form1.saldoluku + talletus;
            System.IO.File.WriteAllBytes(@"C:\Temp\saldo.txt", new byte[0]);
            using (System.IO.StreamWriter file =
    new System.IO.StreamWriter(@"C:\Temp\saldo.txt", true))
            {
                file.WriteLine(uusi);
            }
            //Form1.kytkin = true;
            this.Close();
            Application.Restart();

        }
        //private void talletusform_FormClosing(object sender, FormClosingEventArgs e)
        //{

        //}

        private void talletusform_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide(); // Piilottaa ikkunan. this viittaa kyseiseen formiin
            e.Cancel = true;// Peruu menossa olevan toimenpiteen, eli formin sulkemisen ja hävittämisen
        }
    }
}
