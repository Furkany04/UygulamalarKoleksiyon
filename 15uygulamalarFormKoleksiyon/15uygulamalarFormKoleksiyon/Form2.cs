using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _15uygulamalarFormKoleksiyon
{
    public partial class Form2 : Form
    {
        
        public List<int> veriler = new List<int>();
       


        public Form2(List<int> toplama)
        {
            this.veriler = toplama;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int cevap = sayi1 + sayi2;

            Form3 ff3 = new Form3(veriler);
            veriler.Add(cevap);
            veriler.Add(0);

           
            
            ff3.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int cevap = sayi1 - sayi2;

            Form3 ff3 = new Form3(veriler);
            veriler.Add(cevap);
            veriler.Add(1);

            ff3.Show();


        }
    }
}
