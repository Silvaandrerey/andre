using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace andre
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void yyy_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form2 = new Form6();
            form2.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 form2 = new Form12();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 form2 = new Form13();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            form.ShowDialog();
        }
    }
}
