/*Лабораторна робота №1
 Соколов Ю. М.
 Хренов О. Г. 
 ФБ-41*/
using System;
using System.Windows.Forms;
using System.Numerics;
using myfunc;

namespace Lab3
{
    public partial class Decrypt : Form
    {
        public Decrypt()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            BigInteger p = Func.ConvertInTen(txtP.Text, 16);
            BigInteger q = Func.ConvertInTen(txtQ.Text, 16);
            BigInteger y = Func.ConvertInTen(txtCipher.Text, 16);
            BigInteger n = BigInteger.Multiply(p, q);
            int c1 = Convert.ToInt32(txtC1.Text);
            int c2 = Convert.ToInt32(txtC2.Text);

            BigInteger[] tempSqrt = Func.SqrtBlum(y, p, q, n);

            MessageBox.Show(string.Format("{0} {1} {2} {3}", tempSqrt[0].ToString("X"), tempSqrt[1].ToString("X"), tempSqrt[2].ToString("X"), tempSqrt[3].ToString("X")));

            for(int i = 0; i < tempSqrt.Length; i++)
            {
                if(((tempSqrt[i] % 2) == c1) && (Func.Jakobi(tempSqrt[i], n) == c2))
                {
                    txtM.Text = tempSqrt[i].ToString("X");
                }
            }
        }

        private void btnDecryptUseB_Click(object sender, EventArgs e)
        {
            BigInteger p = Func.ConvertInTen(txtP.Text, 16);
            BigInteger q = Func.ConvertInTen(txtQ.Text, 16);
            BigInteger y = Func.ConvertInTen(txtCipher.Text, 16);
            BigInteger n = BigInteger.Multiply(p, q);
            BigInteger b = Func.ConvertInTen(txtB.Text, 16);
            int c1 = Convert.ToInt32(txtC1.Text);
            int c2 = Convert.ToInt32(txtC2.Text);

            BigInteger inverseFour = Func.InverseElement(4, n);
            BigInteger inverseTwo = Func.InverseElement(2, n);

            BigInteger fpart = (b * inverseTwo) % n;
            BigInteger spart = (y + (inverseFour * b * b)) % n;

            BigInteger[] tempSqrt = Func.SqrtBlum(spart, p, q, n);

            for(int i = 0; i < tempSqrt.Length; i++)
            {
                tempSqrt[i] = ((2 * n) + (tempSqrt[i] - fpart)) % n;
            }

            MessageBox.Show(string.Format("{0} {2} {2} {3}", tempSqrt[0].ToString("X"), tempSqrt[1].ToString("X"), tempSqrt[2].ToString("X"), tempSqrt[3].ToString("X")));

            for (int i = 0; i < tempSqrt.Length; i++)
            {
                if (((tempSqrt[i] % 2) == c1) && (Func.Jakobi(tempSqrt[i], n) == c2))
                {
                    txtM.Text = tempSqrt[i].ToString("X");
                }
            }
        }
    }
}
