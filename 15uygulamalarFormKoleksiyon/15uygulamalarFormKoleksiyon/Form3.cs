using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15uygulamalarFormKoleksiyon
{
    public partial class Form3 : Form
    {
        public List<int> veriler = new List<int>();
        public Form3(List<int> toplama)
        {
            this.veriler= toplama;
           
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int a = 0;
            int b;
            int y = 0;
            string c = "";
            for (int i = 0; i < veriler.Count/2; i++)
            {
                 a = veriler[i +y];
                 b = veriler[i+1 +y];
                if(b == 0)
                {
                    c = "toplama";
                }
                else
                {
                    c = "Çıkarma";
                }
                y += 1;
                string[] satir = { a.ToString(), c.ToString() };
                ListViewItem item = new ListViewItem(satir);

                listView1.Items.Add(item);
            }
           
           
            
           
        }
    }
}
