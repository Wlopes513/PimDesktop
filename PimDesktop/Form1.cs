using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (userTxt.Text.Equals("admin") && passwordTxt.Text.Equals("123"))
                {
                    var menu = new Menu();
                    menu.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos",
                        "Desculpe.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe.",
                        ex.Message,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }
}
