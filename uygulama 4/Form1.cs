using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sbyte ort = Convert.ToSByte(textBox1.Text);
            if (ort < 0 || ort > 100) 
            {
                MessageBox.Show("Yanılış değer");
                textBox1.Focus();                 
            }
            if (ort < 50)
                label2.Text = "Sınıd Tekrarı";
            else
            {
                if (ort >= 85)
                    label2.Text = "Taktir ile";
                else
                    label2.Text = "Teşekkür ile";
                label2.Text += " Geçti";
            }   
        }
    }
}
