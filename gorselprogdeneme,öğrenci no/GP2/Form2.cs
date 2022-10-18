using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP2
{
    public partial class Form2 : Form
    {

        Form1 anaform;
        public Form2(Form1 parametreyegelenanaform)
        {
            InitializeComponent();
            anaform = parametreyegelenanaform;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anaekran = new Form1();
            anaform.Show();
            this.Close();



        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            anaform.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



    }
}
