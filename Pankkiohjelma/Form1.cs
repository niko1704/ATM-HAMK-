using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pankkiohjelma
{
   
    public partial class Form1 : Form
    {
        nostoform alaformi = new nostoform();
        talletusform alaformi2 = new talletusform();
        public static string saldo = System.IO.File.ReadAllText(@"C:\Temp\saldo.txt");
        public static int saldoluku = Int32.Parse(saldo);
        //public static Boolean kytkin = false;


    public Form1()
        {
            //if (kytkin = true)
            //{
            //    Application.Restart();
            //}
            InitializeComponent();
            textBox1.Text = saldo;
            
    }
        //public void (saldolaskin)
        //    {
        //    }


        private void nosto_Click(object sender, EventArgs e)
        {
            alaformi.Show();

        }

        private void talletus_Click(object sender, EventArgs e)
        {
            alaformi2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                this.Hide(); // Piilottaa ikkunan. this viittaa kyseiseen formiin
                e.Cancel = true;// Peruu menossa olevan toimenpiteen, eli formin sulkemisen ja hävittämisen
            }
        }
    }
}
