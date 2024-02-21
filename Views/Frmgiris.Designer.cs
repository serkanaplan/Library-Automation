namespace kotomasyon
{
    partial class Frmgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmgiris));
            this.btngiris = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsifredegistir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblkullanicisayisi = new System.Windows.Forms.Label();
            this.lblkitapsayisi = new System.Windows.Forms.Label();
            this.lbloduncsayisi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btngiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btngiris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btngiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngiris.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.ForeColor = System.Drawing.Color.White;
            this.btngiris.Location = new System.Drawing.Point(116, 484);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(226, 37);
            this.btngiris.TabIndex = 3;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtemail.Location = new System.Drawing.Point(116, 368);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(226, 32);
            this.txtemail.TabIndex = 1;
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(116, 426);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(226, 32);
            this.txtsifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(47, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(116, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 217);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(1083, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(38, 33);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnsifredegistir);
            this.groupBox1.Controls.Add(this.btngiris);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 645);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(26, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(402, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Yüzüncü Yıl Üniversitesi Kütüphanesi";
            // 
            // btnsifredegistir
            // 
            this.btnsifredegistir.BackColor = System.Drawing.Color.Red;
            this.btnsifredegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsifredegistir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsifredegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsifredegistir.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsifredegistir.ForeColor = System.Drawing.Color.White;
            this.btnsifredegistir.Location = new System.Drawing.Point(141, 537);
            this.btnsifredegistir.Name = "btnsifredegistir";
            this.btnsifredegistir.Size = new System.Drawing.Size(161, 37);
            this.btnsifredegistir.TabIndex = 4;
            this.btnsifredegistir.Text = "Şifre Değiştir";
            this.btnsifredegistir.UseMnemonic = false;
            this.btnsifredegistir.UseVisualStyleBackColor = false;
            this.btnsifredegistir.Click += new System.EventHandler(this.Btnsifredegistir);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(57, 233);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 160);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(57, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(159, 160);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(57, 441);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(159, 160);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // lblkullanicisayisi
            // 
            this.lblkullanicisayisi.AutoSize = true;
            this.lblkullanicisayisi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanicisayisi.Location = new System.Drawing.Point(234, 101);
            this.lblkullanicisayisi.Name = "lblkullanicisayisi";
            this.lblkullanicisayisi.Size = new System.Drawing.Size(123, 21);
            this.lblkullanicisayisi.TabIndex = 8;
            this.lblkullanicisayisi.Text = "Aktif Kullanıcı :";
            // 
            // lblkitapsayisi
            // 
            this.lblkitapsayisi.AutoSize = true;
            this.lblkitapsayisi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkitapsayisi.Location = new System.Drawing.Point(234, 300);
            this.lblkitapsayisi.Name = "lblkitapsayisi";
            this.lblkitapsayisi.Size = new System.Drawing.Size(144, 21);
            this.lblkitapsayisi.TabIndex = 8;
            this.lblkitapsayisi.Text = "Toplam Materyal :";
            // 
            // lbloduncsayisi
            // 
            this.lbloduncsayisi.AutoSize = true;
            this.lbloduncsayisi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloduncsayisi.Location = new System.Drawing.Point(234, 516);
            this.lbloduncsayisi.Name = "lbloduncsayisi";
            this.lbloduncsayisi.Size = new System.Drawing.Size(195, 21);
            this.lbloduncsayisi.TabIndex = 8;
            this.lbloduncsayisi.Text = "Kullanımdaki materyal  :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.lbloduncsayisi);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.lblkitapsayisi);
            this.groupBox2.Controls.Add(this.lblkullanicisayisi);
            this.groupBox2.Location = new System.Drawing.Point(530, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 645);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Frmgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnexit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmgiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Frmgiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblkullanicisayisi;
        private System.Windows.Forms.Label lblkitapsayisi;
        private System.Windows.Forms.Label lbloduncsayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsifredegistir;
    }
}

