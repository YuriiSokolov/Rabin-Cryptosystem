namespace Lab3
{
    partial class Encrypt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnCopyToDecrypt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnEncryptUseB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cipher";
            // 
            // txtCipher
            // 
            this.txtCipher.Location = new System.Drawing.Point(52, 154);
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(222, 20);
            this.txtCipher.TabIndex = 13;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(12, 15);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(16, 13);
            this.lable1.TabIndex = 11;
            this.lable1.Text = "M";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(33, 12);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(349, 20);
            this.txtM.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "c1";
            // 
            // txtC1
            // 
            this.txtC1.Location = new System.Drawing.Point(306, 154);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(21, 20);
            this.txtC1.TabIndex = 16;
            // 
            // txtC2
            // 
            this.txtC2.Location = new System.Drawing.Point(361, 154);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(21, 20);
            this.txtC2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "c2";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(12, 180);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 19;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "N";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(33, 119);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(349, 20);
            this.txtN.TabIndex = 20;
            // 
            // btnCopyToDecrypt
            // 
            this.btnCopyToDecrypt.Location = new System.Drawing.Point(307, 180);
            this.btnCopyToDecrypt.Name = "btnCopyToDecrypt";
            this.btnCopyToDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnCopyToDecrypt.TabIndex = 22;
            this.btnCopyToDecrypt.Text = "Copy";
            this.btnCopyToDecrypt.UseVisualStyleBackColor = true;
            this.btnCopyToDecrypt.Click += new System.EventHandler(this.btnCopyToDecrypt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mn";
            // 
            // txtMn
            // 
            this.txtMn.Location = new System.Drawing.Point(33, 48);
            this.txtMn.Name = "txtMn";
            this.txtMn.Size = new System.Drawing.Size(349, 20);
            this.txtMn.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "B";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(33, 84);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(349, 20);
            this.txtB.TabIndex = 25;
            // 
            // btnEncryptUseB
            // 
            this.btnEncryptUseB.Location = new System.Drawing.Point(102, 180);
            this.btnEncryptUseB.Name = "btnEncryptUseB";
            this.btnEncryptUseB.Size = new System.Drawing.Size(91, 23);
            this.btnEncryptUseB.TabIndex = 27;
            this.btnEncryptUseB.Text = "Encrypt Use B";
            this.btnEncryptUseB.UseVisualStyleBackColor = true;
            this.btnEncryptUseB.Click += new System.EventHandler(this.btnEncryptUseB_Click);
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 213);
            this.Controls.Add(this.btnEncryptUseB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMn);
            this.Controls.Add(this.btnCopyToDecrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.txtM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Encrypt";
            this.Text = "Encrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnCopyToDecrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnEncryptUseB;
    }
}