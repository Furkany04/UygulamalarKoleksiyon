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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        public List<int> veriler = new List<int>();
       
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                
                Form2 ff2 = new Form2(veriler);
                
                ff2.MdiParent = this;

                ff2.Show();
      

            }
        }

       
    }
}
