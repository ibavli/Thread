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

namespace SuspendVeResumeMetodlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        int j, k;
        bool durum = false;
        


        public void sayici1()
        {
            for (int i = 1; i <= 30; i++)
            {
                Thread.Sleep(500);//Kanal içerisindeki yapılan işlemi 500 milisaniye bekleten kod.

                label1.Invoke(new sayici1_delegate(yeni_sayici1));
            }
        }

        public void sayici2()
        {
            for (int i = 1; i <= 30; i++)
            {
                Thread.Sleep(500);//Kanal içerisindeki yapılan işlemi 500 milisaniye bekleten kod.

                label2.Invoke(new sayici2_delegate(yeni_sayici2));//Invoke metodunu kullanarak delegate aracılığı ile tanımladığımız yenisayici1 ve yenisayici2 metodlarını çağırırız.

                if (i == 15)
                {
                    Thread.Sleep(3000);//Kanal içerisindeki yapılan işlemi 3000 milisaniye bekleten kod.
                }

            }
        }

        private delegate void sayici1_delegate();

        private void yeni_sayici1()
        {
            j++;
            label1.Text = j + " ";
        }

        private delegate void sayici2_delegate();

        public Thread kanal1;
        public Thread kanal2;
        private void Form1_Load(object sender, EventArgs e)
        {
            kanal1 = new Thread(new ThreadStart(sayici1));
            kanal2 = new Thread(new ThreadStart(sayici2));
            kanal1.Start();
            kanal2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Durdur")
            {
                button1.Text = "Devam Et";
                kanal1.Suspend();
                kanal2.Suspend();
            }
            else
            {
                button1.Text = "Durdur";
                kanal1.Resume();
                kanal2.Resume();
            }
        }

        private void yeni_sayici2()
        {
            k++;
            label2.Text = k + " ";
        }


    }
}
