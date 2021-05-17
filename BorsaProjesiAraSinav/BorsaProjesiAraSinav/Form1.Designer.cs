namespace BorsaProjesiAraSinav
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.girissifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.giriskadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbsifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbkadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbsoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbtc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbtelefon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbadres = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 318);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.girissifre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.giriskadi);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(348, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Giriş Yap";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbadres);
            this.tabPage2.Controls.Add(this.tbtelefon);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbemail);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbtc);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbsoyad);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbad);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbsifre);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbkadi);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(348, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kayıt Ol";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // girissifre
            // 
            this.girissifre.Location = new System.Drawing.Point(173, 77);
            this.girissifre.Name = "girissifre";
            this.girissifre.Size = new System.Drawing.Size(100, 20);
            this.girissifre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // giriskadi
            // 
            this.giriskadi.Location = new System.Drawing.Point(173, 51);
            this.giriskadi.Name = "giriskadi";
            this.giriskadi.Size = new System.Drawing.Size(100, 20);
            this.giriskadi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbsifre
            // 
            this.tbsifre.Location = new System.Drawing.Point(178, 48);
            this.tbsifre.Name = "tbsifre";
            this.tbsifre.Size = new System.Drawing.Size(100, 20);
            this.tbsifre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre";
            // 
            // tbkadi
            // 
            this.tbkadi.Location = new System.Drawing.Point(178, 22);
            this.tbkadi.Name = "tbkadi";
            this.tbkadi.Size = new System.Drawing.Size(100, 20);
            this.tbkadi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kayıt Ol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ad";
            // 
            // tbad
            // 
            this.tbad.Location = new System.Drawing.Point(178, 74);
            this.tbad.Name = "tbad";
            this.tbad.Size = new System.Drawing.Size(100, 20);
            this.tbad.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Soyad";
            // 
            // tbsoyad
            // 
            this.tbsoyad.Location = new System.Drawing.Point(178, 100);
            this.tbsoyad.Name = "tbsoyad";
            this.tbsoyad.Size = new System.Drawing.Size(100, 20);
            this.tbsoyad.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "TC Kimlik No";
            // 
            // tbtc
            // 
            this.tbtc.Location = new System.Drawing.Point(178, 126);
            this.tbtc.Name = "tbtc";
            this.tbtc.Size = new System.Drawing.Size(100, 20);
            this.tbtc.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Telefon";
            // 
            // tbtelefon
            // 
            this.tbtelefon.Location = new System.Drawing.Point(178, 152);
            this.tbtelefon.Name = "tbtelefon";
            this.tbtelefon.Size = new System.Drawing.Size(100, 20);
            this.tbtelefon.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Email";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(178, 178);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(100, 20);
            this.tbemail.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Adres";
            // 
            // tbadres
            // 
            this.tbadres.Location = new System.Drawing.Point(178, 204);
            this.tbadres.Name = "tbadres";
            this.tbadres.Size = new System.Drawing.Size(100, 20);
            this.tbadres.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 330);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Giriş Yap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox girissifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox giriskadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbadres;
        private System.Windows.Forms.TextBox tbtelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbtc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbsoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbsifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbkadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

