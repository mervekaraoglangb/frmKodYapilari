namespace frmKodYapilari
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKisaKenar = new System.Windows.Forms.TextBox();
            this.txtUzunKenar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKdvTutari = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIndirim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOran = new System.Windows.Forms.ComboBox();
            this.brbUret = new System.Windows.Forms.Button();
            this.txti = new System.Windows.Forms.TextBox();
            this.txtj = new System.Windows.Forms.TextBox();
            this.txtk = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbxListe = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnTernary = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dikdörtgenin Alanı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kısa Kenar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uzun Kenar";
            // 
            // txtKisaKenar
            // 
            this.txtKisaKenar.Location = new System.Drawing.Point(109, 35);
            this.txtKisaKenar.Name = "txtKisaKenar";
            this.txtKisaKenar.Size = new System.Drawing.Size(220, 20);
            this.txtKisaKenar.TabIndex = 3;
            // 
            // txtUzunKenar
            // 
            this.txtUzunKenar.Location = new System.Drawing.Point(109, 74);
            this.txtUzunKenar.Name = "txtUzunKenar";
            this.txtUzunKenar.Size = new System.Drawing.Size(220, 20);
            this.txtUzunKenar.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSonuc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUzunKenar);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtKisaKenar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 276);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dikdörtgenin Alanı ve Çevresi";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.Red;
            this.lblSonuc.Location = new System.Drawing.Point(105, 188);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 20);
            this.lblSonuc.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 44);
            this.button2.TabIndex = 0;
            this.button2.Text = "Dikdörtgenin Çevresi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toplam Fiyat";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(110, 36);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(233, 20);
            this.txtFiyat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "KDV oranı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "KDV Tutarı";
            // 
            // txtKdvTutari
            // 
            this.txtKdvTutari.Location = new System.Drawing.Point(112, 141);
            this.txtKdvTutari.Name = "txtKdvTutari";
            this.txtKdvTutari.Size = new System.Drawing.Size(233, 20);
            this.txtKdvTutari.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 32);
            this.button3.TabIndex = 10;
            this.button3.Text = "Hesapla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIndirim);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbOran);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtKdvTutari);
            this.groupBox2.Controls.Add(this.txtFiyat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(563, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 445);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kdv Hesabı";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(28, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 51);
            this.label8.TabIndex = 14;
            this.label8.Text = "Eğer genel toplam 100-200 arasında ise %10 indirim, 200 - 500 arasında ise %20 in" +
    "dirim, 500 ve üstü ise %30 indirim uygulanacaktır";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(28, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "İndirim tutarı şu şekilde hesaplanır:";
            // 
            // txtIndirim
            // 
            this.txtIndirim.Location = new System.Drawing.Point(112, 193);
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.Size = new System.Drawing.Size(226, 20);
            this.txtIndirim.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "İndirim Tutarı";
            // 
            // cmbOran
            // 
            this.cmbOran.FormattingEnabled = true;
            this.cmbOran.Items.AddRange(new object[] {
            "1",
            "8",
            "18"});
            this.cmbOran.Location = new System.Drawing.Point(112, 88);
            this.cmbOran.Name = "cmbOran";
            this.cmbOran.Size = new System.Drawing.Size(231, 21);
            this.cmbOran.TabIndex = 11;
            // 
            // brbUret
            // 
            this.brbUret.Location = new System.Drawing.Point(59, 160);
            this.brbUret.Name = "brbUret";
            this.brbUret.Size = new System.Drawing.Size(118, 31);
            this.brbUret.TabIndex = 13;
            this.brbUret.Text = "Hesapla";
            this.brbUret.UseVisualStyleBackColor = true;
            this.brbUret.Click += new System.EventHandler(this.brbUret_Click);
            // 
            // txti
            // 
            this.txti.Location = new System.Drawing.Point(55, 39);
            this.txti.Name = "txti";
            this.txti.Size = new System.Drawing.Size(192, 20);
            this.txti.TabIndex = 14;
            // 
            // txtj
            // 
            this.txtj.Location = new System.Drawing.Point(59, 78);
            this.txtj.Name = "txtj";
            this.txtj.Size = new System.Drawing.Size(188, 20);
            this.txtj.TabIndex = 15;
            // 
            // txtk
            // 
            this.txtk.Location = new System.Drawing.Point(59, 122);
            this.txtk.Name = "txtk";
            this.txtk.Size = new System.Drawing.Size(188, 20);
            this.txtk.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTernary);
            this.groupBox3.Controls.Add(this.btnContinue);
            this.groupBox3.Controls.Add(this.btnBreak);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.lbxListe);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtk);
            this.groupBox3.Controls.Add(this.txtj);
            this.groupBox3.Controls.Add(this.txti);
            this.groupBox3.Controls.Add(this.btnWhile);
            this.groupBox3.Controls.Add(this.btnFor);
            this.groupBox3.Controls.Add(this.brbUret);
            this.groupBox3.Location = new System.Drawing.Point(26, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 493);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(162, 425);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(118, 23);
            this.btnContinue.TabIndex = 21;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.Location = new System.Drawing.Point(162, 396);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(118, 23);
            this.btnBreak.TabIndex = 21;
            this.btnBreak.Text = "Break";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(162, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 26);
            this.button4.TabIndex = 20;
            this.button4.Text = "Do While";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbxListe
            // 
            this.lbxListe.FormattingEnabled = true;
            this.lbxListe.Location = new System.Drawing.Point(297, 35);
            this.lbxListe.Name = "lbxListe";
            this.lbxListe.Size = new System.Drawing.Size(215, 446);
            this.lbxListe.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Sonuç:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(22, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "k";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(22, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "j";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(22, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "i";
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(162, 327);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(118, 31);
            this.btnWhile.TabIndex = 13;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.brnWhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(162, 290);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(118, 31);
            this.btnFor.TabIndex = 13;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.brnFor_Click);
            // 
            // btnTernary
            // 
            this.btnTernary.Location = new System.Drawing.Point(162, 454);
            this.btnTernary.Name = "btnTernary";
            this.btnTernary.Size = new System.Drawing.Size(118, 27);
            this.btnTernary.TabIndex = 22;
            this.btnTernary.Text = "Ternary If";
            this.btnTernary.UseVisualStyleBackColor = true;
            this.btnTernary.Click += new System.EventHandler(this.btnTernary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 838);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kod Yapıları";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKisaKenar;
        private System.Windows.Forms.TextBox txtUzunKenar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKdvTutari;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbOran;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIndirim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button brbUret;
        private System.Windows.Forms.TextBox txti;
        private System.Windows.Forms.TextBox txtj;
        private System.Windows.Forms.TextBox txtk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbxListe;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnTernary;
    }
}

