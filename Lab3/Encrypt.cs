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
    public partial class Encrypt : Form
    {
        public Encrypt()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            BigInteger m = Func.ConvertInTen(txtM.Text, 16);
            byte[] bytesM = m.ToByteArray();
            int lengthM = bytesM.Length;
            BigInteger n = Func.ConvertInTen(txtN.Text, 16);
            BigInteger Mn = Func.TextNormal(m, n);
            txtMn.Text = Mn.ToString("X");

            BigInteger cipher = BigInteger.ModPow(Mn, 2, n);
            BigInteger c1 = Mn % 2;
            int c2 = Func.Jakobi(Mn, n);
            if (c2 == -1)
            {
                c2 = 1;
            }

            txtCipher.Text = cipher.ToString("X");
            txtC1.Text = c1.ToString("X");
            txtC2.Text = c2.ToString();
        }

        private void btnCopyToDecrypt_Click(object sender, EventArgs e)
        {
            Decrypt decrypt = new Decrypt();
            decrypt.Show();

            decrypt.txtCipher.Text = txtCipher.Text;
            decrypt.txtC1.Text = txtC1.Text;
            decrypt.txtC2.Text = txtC2.Text;
        }

        private void btnEncryptUseB_Click(object sender, EventArgs e)
        {
            BigInteger m = Func.ConvertInTen(txtM.Text, 16);
            byte[] bytesM = m.ToByteArray();
            int lengthM = bytesM.Length;
            BigInteger n = Func.ConvertInTen(txtN.Text, 16);
            BigInteger Mn = Func.TextNormal(m, n);
            BigInteger B = Func.ConvertInTen(txtB.Text, 16);
            txtMn.Text = Mn.ToString("X");

            BigInteger cipher = (Mn * (Mn + B)) % n;
            BigInteger inverseTwo = Func.InverseElement(2, n);
            BigInteger mNplusInverseTwo = Mn + inverseTwo;
            BigInteger c1 = (mNplusInverseTwo % n) % 2;
            int c2 = Func.Jakobi(mNplusInverseTwo, n);
            if (c2 == -1)
            {
                c2 = 1;
            }

            txtCipher.Text = cipher.ToString("X");
            txtC1.Text = c1.ToString("X");
            txtC2.Text = c2.ToString();
        }
    }
}
