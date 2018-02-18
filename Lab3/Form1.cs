using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenKey_Click(object sender, EventArgs e)
        {
            GenKey genKey = new GenKey();
            genKey.Show();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Encrypt frm = new Encrypt();
            frm.Show();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Decrypt frm = new Decrypt();
            frm.Show();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            Sign frm = new Sign();
            frm.Show();
        }

        private void btnProtocol_Click(object sender, EventArgs e)
        {
            Protocol frm = new Protocol();
            frm.Show();
        }
    }
}
