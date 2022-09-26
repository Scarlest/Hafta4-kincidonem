using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta4İkincidonem
{
    public partial class Form1 : Form
    {
        class Insan
        {
           public string Adi { get; set; }
            
            public string Soyadi { get; set; }
            public int Yasi { get; set; }
            public string Telefon { get; set; }
            public string Cinsiyet { get; set; }
            public string Birlestir()
            {
                string Birlestir = Adi + Soyadi + Cinsiyet + Yasi + Telefon;
                return Birlestir;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insan kisi = new Insan();
            kisi.Adi ="Furkan Efe";
            kisi.Soyadi ="Engin" ;
            kisi.Cinsiyet = "Erkek";
            kisi.Yasi =21 ;
            kisi.Telefon = "05456745386";
            listBox1.Items.Add(kisi.Birlestir());
            //MessageBox.Show(kisi.Adi+" "+kisi.Soyadi+" "+kisi.Cinsiyet+" "+kisi.Yasi+" "+kisi.Telefon);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            insan birey = new insan();
            birey.Adi= textBox1.Text;
            birey.Soyadi = textBox2.Text;
            birey.Cinsiyet = radioButton1.Text;
            birey.Yasi = Convert.ToByte(numericUpDown1.Value);
            birey.Telefon = maskedTextBox1.Text;
            listBox1.Items.Add(textBox1.Text+" " +textBox2.Text+" "+numericUpDown1.Text+" "+radioButton1.Text+" "+maskedTextBox1.Text);
          
        }
    }
}
