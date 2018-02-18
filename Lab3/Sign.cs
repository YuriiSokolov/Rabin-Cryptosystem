/*Лабораторна робота №1
 Соколов Ю. М.
 Хренов О. Г. 
 ФБ-41*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Numerics;
using myfunc;

namespace Lab3
{
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            BigInteger m = Func.ConvertInTen(txtM.Text, 16);
            BigInteger n = Func.ConvertInTen(txtN.Text, 16);
            BigInteger p = Func.ConvertInTen(txtP.Text, 16);
            BigInteger q = Func.ConvertInTen(txtQ.Text, 16);
            BigInteger Mn = Func.TextNormal(m, n);

            do
            {
                Mn = Func.TextNormal(m, n);
            } while (!Func.QuadRes(Mn, p, q));

            txtMn.Text += Mn.ToString("X");

            BigInteger[] tempSqrt = Func.SqrtBlum(Mn, p, q, n);

            txtS1.Text = tempSqrt[0].ToString("X");
            txtS2.Text = tempSqrt[1].ToString("X");
            txtS3.Text = tempSqrt[2].ToString("X");
            txtS4.Text = tempSqrt[3].ToString("X");
        }

        private void btnCopyDown_Click(object sender, EventArgs e)
        {
            txtTestS.Text = string.Empty;
            txtNtest.Text = string.Empty;
            txtMnTest.Text = string.Empty;

            txtMnTest.Text = txtMn.Text;
            txtNtest.Text = txtN.Text;
            Random rand = new Random();
            int num = rand.Next(1, 5);
            switch(num)
            {
                case 1:
                    txtTestS.Text = txtS1.Text;
                    break;
                case 2:
                    txtTestS.Text = txtS2.Text;
                    break;
                case 3:
                    txtTestS.Text = txtS3.Text;
                    break;
                case 4:
                    txtTestS.Text = txtS4.Text;
                    break;
            }
        }

        private void btnTestS_Click(object sender, EventArgs e)
        {
            txtTestS.ForeColor = Color.Black;
            BigInteger n = Func.ConvertInTen(txtNtest.Text, 16);
            BigInteger s = Func.ConvertInTen(txtTestS.Text, 16);
            BigInteger Mn = Func.ConvertInTen(txtMnTest.Text, 16);

            if (BigInteger.ModPow(s, 2, n) == Mn)
            {
                txtTestS.ForeColor = Color.Green;
            }
            else
            {
                txtTestS.ForeColor = Color.Red;
            } 
        }
    }
}
