using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe2_pabd
{
    public partial class Form1 : Form
    {   readonly string Username = "abid";
        readonly string Password = "123";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == Username && textBox2.Text == Password)
            {
                this.Hide();
                Form2 panggil1 = new Form2();
                panggil1.Show();
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("username dan password tidak boleh kosong");
            }
            else
            {
                MessageBox.Show("username atau password anda salah");
            }
        }
    }
}
