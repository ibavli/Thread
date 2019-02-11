using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadIleCalismak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDongu_Click(object sender, EventArgs e)
        {
            //Dongu();


            Thread kanal1 = new Thread(Dongu);//kanal1 isimli yeni bir thread oluşturduk. Dongu isimli metodumuzu bu kanal içerisinde çalıştırdık.
            kanal1.Start();  
        }

        private void Dongu()
        {
            decimal i = default(decimal);
            for (i = 0; i < 1000000000; i++)
            {

            }
            MessageBox.Show("İşlem bitti");
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tıkladın");
        }
    }
}
