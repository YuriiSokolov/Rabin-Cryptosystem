namespace Lab3
{
    partial class GenKey
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
            this.btnGenP = new System.Windows.Forms.Button();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.btnGenQ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnGenN = new System.Windows.Forms.Button();
            this.btnCopyE = new System.Windows.Forms.Button();
            this.btnCopyD = new System.Windows.Forms.Button();
            this.btnProstQ = new System.Windows.Forms.Button();
            this.btnProstP = new System.Windows.Forms.Button();
            this.btnCopySign = new System.Windows.Forms.Button();
            this.btnCopyProt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenP
            // 
            this.btnGenP.Location = new System.Drawing.Point(358, 10);
            this.btnGenP.Name = "btnGenP";
            this.btnGenP.Size = new System.Drawing.Size(75, 23);
            this.btnGenP.TabIndex = 0;
            this.btnGenP.Text = "Gen P";
            this.btnGenP.UseVisualStyleBackColor = true;
            this.btnGenP.Click += new System.EventHandler(this.btnGenP_Click);
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(33, 12);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(310, 20);
            this.txtP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Q";
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(33, 48);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(310, 20);
            this.txtQ.TabIndex = 4;
            // 
            // btnGenQ
            // 
            this.btnGenQ.Location = new System.Drawing.Point(358, 46);
            this.btnGenQ.Name = "btnGenQ";
            this.btnGenQ.Size = new System.Drawing.Size(75, 23);
            this.btnGenQ.TabIndex = 3;
            this.btnGenQ.Text = "Gen Q";
            this.btnGenQ.UseVisualStyleBackColor = true;
            this.btnGenQ.Click += new System.EventHandler(this.btnGenQ_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "N";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(33, 84);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(310, 20);
            this.txtN.TabIndex = 7;
            // 
            // btnGenN
            // 
            this.btnGenN.Location = new System.Drawing.Point(358, 82);
            this.btnGenN.Name = "btnGenN";
            this.btnGenN.Size = new System.Drawing.Size(75, 23);
            this.btnGenN.TabIndex = 6;
            this.btnGenN.Text = "Gen N";
            this.btnGenN.UseVisualStyleBackColor = true;
            this.btnGenN.Click += new System.EventHandler(this.btnGenN_Click);
            // 
            // btnCopyE
            // 
            this.btnCopyE.Location = new System.Drawing.Point(12, 110);
            this.btnCopyE.Name = "btnCopyE";
            this.btnCopyE.Size = new System.Drawing.Size(105, 23);
            this.btnCopyE.TabIndex = 9;
            this.btnCopyE.Text = "Copy To Encrypt";
            this.btnCopyE.UseVisualStyleBackColor = true;
            this.btnCopyE.Click += new System.EventHandler(this.btnCopyE_Click);
            // 
            // btnCopyD
            // 
            this.btnCopyD.Location = new System.Drawing.Point(133, 110);
            this.btnCopyD.Name = "btnCopyD";
            this.btnCopyD.Size = new System.Drawing.Size(105, 23);
            this.btnCopyD.TabIndex = 10;
            this.btnCopyD.Text = "Copy To Decrypt";
            this.btnCopyD.UseVisualStyleBackColor = true;
            this.btnCopyD.Click += new System.EventHandler(this.btnCopyD_Click);
            // 
            // btnProstQ
            // 
            this.btnProstQ.Location = new System.Drawing.Point(449, 46);
            this.btnProstQ.Name = "btnProstQ";
            this.btnProstQ.Size = new System.Drawing.Size(75, 23);
            this.btnProstQ.TabIndex = 12;
            this.btnProstQ.Text = "Test Q";
            this.btnProstQ.UseVisualStyleBackColor = true;
            this.btnProstQ.Click += new System.EventHandler(this.btnProstQ_Click);
            // 
            // btnProstP
            // 
            this.btnProstP.Location = new System.Drawing.Point(449, 10);
            this.btnProstP.Name = "btnProstP";
            this.btnProstP.Size = new System.Drawing.Size(75, 23);
            this.btnProstP.TabIndex = 11;
            this.btnProstP.Text = "Test P";
            this.btnProstP.UseVisualStyleBackColor = true;
            this.btnProstP.Click += new System.EventHandler(this.btnProstP_Click);
            // 
            // btnCopySign
            // 
            this.btnCopySign.Location = new System.Drawing.Point(256, 110);
            this.btnCopySign.Name = "btnCopySign";
            this.btnCopySign.Size = new System.Drawing.Size(105, 23);
            this.btnCopySign.TabIndex = 13;
            this.btnCopySign.Text = "Copy To Sign";
            this.btnCopySign.UseVisualStyleBackColor = true;
            this.btnCopySign.Click += new System.EventHandler(this.btnCopySign_Click);
            // 
            // btnCopyProt
            // 
            this.btnCopyProt.Location = new System.Drawing.Point(376, 110);
            this.btnCopyProt.Name = "btnCopyProt";
            this.btnCopyProt.Size = new System.Drawing.Size(105, 23);
            this.btnCopyProt.TabIndex = 14;
            this.btnCopyProt.Text = "Copy To Protocol";
            this.btnCopyProt.UseVisualStyleBackColor = true;
            this.btnCopyProt.Click += new System.EventHandler(this.btnCopyProt_Click);
            // 
            // GenKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 146);
            this.Controls.Add(this.btnCopyProt);
            this.Controls.Add(this.btnCopySign);
            this.Controls.Add(this.btnProstQ);
            this.Controls.Add(this.btnProstP);
            this.Controls.Add(this.btnCopyD);
            this.Controls.Add(this.btnCopyE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnGenN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.btnGenQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.btnGenP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GenKey";
            this.Text = "GenKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenP;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Button btnGenQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnGenN;
        private System.Windows.Forms.Button btnCopyE;
        private System.Windows.Forms.Button btnCopyD;
        private System.Windows.Forms.Button btnProstQ;
        private System.Windows.Forms.Button btnProstP;
        private System.Windows.Forms.Button btnCopySign;
        private System.Windows.Forms.Button btnCopyProt;
    }
}