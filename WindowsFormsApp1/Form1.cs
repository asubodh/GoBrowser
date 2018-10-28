using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            wb1.Navigate("https://www.google.com");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            wb1.Navigate("https://" + textBox1.Text);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            wb1.Stop();
        }

        private void txtURL_Click(object sender, EventArgs e)
        {

        }

        private void lnkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            wb1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnGo;


           
        }
    }
}
