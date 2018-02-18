/*Лабораторна робота №1
 Соколов Ю. М.
 Хренов О. Г. 
 ФБ-41*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Numerics;
using myfunc;
using System.Media;


namespace Lab3
{
    public partial class GenKey : Form
    {
        public GenKey()
        {
            InitializeComponent();
        }

        private void btnGenP_Click(object sender, EventArgs e)
        {
            BigInteger p = new BigInteger();
            int lengthP = 0;
            do
            {
                p = Func.NumBluma();
                byte[] byteP = p.ToByteArray();
                lengthP = byteP.Length;
            } while (lengthP != 16);

            txtP.Text = p.ToString("X");
            SoundPlayer ok = new SoundPlayer(@"E:\crypto2\lab3\Lab3\ok.wav");
            ok.Play();
        }

        private void btnGenQ_Click(object sender, EventArgs e)
        {
            BigInteger q = new BigInteger();
            int lengthQ = 0;
            do
            {
                q = Func.NumBluma();
                byte[] byteQ = q.ToByteArray();
                lengthQ = byteQ.Length;
            } while (lengthQ != 16);

            txtQ.Text = q.ToString("X");
            SoundPlayer ok = new SoundPlayer(@"E:\crypto2\lab3\Lab3\ok.wav");
            ok.Play();
        }

        private void btnGenN_Click(object sender, EventArgs e)
        {
            BigInteger p = Func.ConvertInTen(txtP.Text, 16);
            BigInteger q = Func.ConvertInTen(txtQ.Text, 16);
            BigInteger n = BigInteger.Multiply(p, q);
            txtN.Text = n.ToString("X");
        }

        private void btnCopyE_Click(object sender, EventArgs e)
        {
            Encrypt frm = new Encrypt();
            frm.Show();
            frm.txtN.Text = txtN.Text;
        }

        private void btnCopyD_Click(object sender, EventArgs e)
        {
            Decrypt frm = new Decrypt();
            frm.Show();
            frm.txtP.Text = txtP.Text;
            frm.txtQ.Text = txtQ.Text;
        }

        private void btnProstP_Click(object sender, EventArgs e)
        {
            txtP.ForeColor = Color.Black;

            BigInteger p = Func.ConvertInTen(txtP.Text, 16);

            if (Func.MillerRab(p, 50) && (p % 4) == 3)
            {
                txtP.ForeColor = Color.Green;
            }
            else if(Func.MillerRab(p, 50) && (p % 4) != 3)
            {
                txtP.ForeColor = Color.Blue;
            }
            else if (!Func.MillerRab(p, 50) && (p % 4) == 3)
            {
                txtP.ForeColor = Color.Yellow;
            }
            else
            {
                txtP.ForeColor = Color.Red;
            }
        }

        private void btnProstQ_Click(object sender, EventArgs e)
        {
            txtQ.ForeColor = Color.Black;

            BigInteger q = Func.ConvertInTen(txtQ.Text, 16);

            if (Func.MillerRab(q, 50) && (q % 4) == 3)
            {
                txtQ.ForeColor = Color.Green;
            }
            else if (Func.MillerRab(q, 50) && (q % 4) != 3)
            {
                txtQ.ForeColor = Color.Blue;
            }
            else if (!Func.MillerRab(q, 50) && (q % 4) == 3)
            {
                txtQ.ForeColor = Color.Yellow;
            }
            else
            {
                txtQ.ForeColor = Color.Red;
            }
        }

        private void btnCopySign_Click(object sender, EventArgs e)
        {
            Sign frm = new Sign();
            frm.Show();
            frm.txtP.Text = txtP.Text;
            frm.txtQ.Text = txtQ.Text;
            frm.txtN.Text = txtN.Text;
        }

        private void btnCopyProt_Click(object sender, EventArgs e)
        {
            Protocol frm = new Protocol();
            frm.Show();
            frm.txtP.Text = txtP.Text;
            frm.txtQ.Text = txtQ.Text;
            frm.txtN.Text = txtN.Text;
        }
    }
}
