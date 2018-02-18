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
    public partial class Protocol : Form
    {
        public Protocol()
        {
            InitializeComponent();
        }

        private void btnSendB_Click(object sender, EventArgs e)
        {
            BigInteger x = Func.ConvertInTen(txtX.Text, 16);
            BigInteger n = Func.ConvertInTen(txtN.Text, 16);
            BigInteger z = BigInteger.Pow(x, 4) % n;
            txtXa.Text = z.ToString("X");
        }

        private void btnSendA_Click(object sender, EventArgs e)
        {
            txtZb.Text = txtZ.Text;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            txtZb.ForeColor = Color.Black;
            BigInteger z = Func.ConvertInTen(txtZb.Text, 16);
            BigInteger x = Func.ConvertInTen(txtX.Text, 16);
            BigInteger n = Func.ConvertInTen(txtN.Text, 16);
            BigInteger xquad = BigInteger.Pow(x, 2) % n;
            if (xquad == z)
            {
                txtZb.ForeColor = Color.Green;
            }
            else
            {
                txtZb.ForeColor = Color.Red;
            }
        }

        private void btnFindZ_Click(object sender, EventArgs e)
        {
            BigInteger x = Func.ConvertInTen(txtXa.Text, 16);
            BigInteger p = Func.ConvertInTen(txtP.Text, 16);
            BigInteger q = Func.ConvertInTen(txtQ.Text, 16);
            BigInteger n = p * q;

            BigInteger[] tempSqrt = Func.SqrtBlum(x, p, q, n);
            for (int i = 0; i < tempSqrt.Length; i++)
            {
                if(Func.QuadRes(tempSqrt[i], p, q))
                {
                    txtZ.Text = tempSqrt[i].ToString("X");
                    break;
                }
            }
        }

        private void btnSendBAttack_Click(object sender, EventArgs e)
        {
            BigInteger x = Func.ConvertInTen(txtX.Text, 16);
            BigInteger n = Func.ConvertInTen(txtN.Text, 16);
            BigInteger z = BigInteger.Pow(x, 2) % n;
            txtXa.Text = z.ToString("X");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BigInteger t = Func.ConvertInTen(txtX.Text, 16);
            BigInteger z = Func.ConvertInTen(txtZb.Text, 16);
            BigInteger n = Func.ConvertInTen(txtN.Text, 16);
            BigInteger snum = new BigInteger();
            BigInteger tplusz = t + z;

            BigInteger gdc = Func.Euclid(tplusz, n);

            txtPorQ.Text = gdc.ToString("X");

            if (Func.Euclid(gdc, n) == gdc)
            {
                snum = n / gdc;
                MessageBox.Show("Второе число это:\r\n" + snum.ToString("X"));
            }
            else
            {
                MessageBox.Show("Найденое число не является множителем n!!!");
            }
        }
    }
}
