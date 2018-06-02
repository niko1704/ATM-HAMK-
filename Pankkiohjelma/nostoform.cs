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
    public partial class nostoform : Form
    {
        public nostoform()
            
        {
            InitializeComponent();
            
        }

        private void nostoform_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide(); // Piilottaa ikkunan. this viittaa kyseiseen formiin
            e.Cancel = true;// Peruu menossa olevan toimenpiteen, eli formin sulkemisen ja hävittämisen
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            int nosto = Convert.ToInt32(textBox1.Text);
            int uusi = Form1.saldoluku - nosto;
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
    }
}
