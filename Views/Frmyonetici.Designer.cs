namespace kotomasyon
{
    partial class Frmyonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmyonetici));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.lblborc = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lblkitapsayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(753, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 460);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ödünç Kitap Listesi";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnodunclistele);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(253, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 460);
            this.button3.TabIndex = 1;
            this.button3.Text = "Kitap işlemleri";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnkitap);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(503, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 460);
            this.button4.TabIndex = 1;
            this.button4.Text = "Ödünç/İade işlemleri";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnodunciade);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 460);
            this.button5.TabIndex = 1;
            this.button5.Text = "Kullanıcı İşlemleri";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnkullanici);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(399, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yönetici Ekranı";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(971, 1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(32, 32);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.BackColor = System.Drawing.Color.Transparent;
            this.lblkullaniciadi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullaniciadi.ForeColor = System.Drawing.Color.White;
            this.lblkullaniciadi.Location = new System.Drawing.Point(12, 8);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(132, 24);
            this.lblkullaniciadi.TabIndex = 18;
            this.lblkullaniciadi.Text = "Kullanıcı Adı :";
            // 
            // lblborc
            // 
            this.lblborc.AutoSize = true;
            this.lblborc.BackColor = System.Drawing.Color.Transparent;
            this.lblborc.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblborc.ForeColor = System.Drawing.Color.White;
            this.lblborc.Location = new System.Drawing.Point(859, 8);
            this.lblborc.Name = "lblborc";
            this.lblborc.Size = new System.Drawing.Size(21, 24);
            this.lblborc.TabIndex = 18;
            this.lblborc.Text = "0";
            this.lblborc.Visible = false;
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.BackColor = System.Drawing.Color.Transparent;
            this.lbltarih.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltarih.ForeColor = System.Drawing.Color.White;
            this.lbltarih.Location = new System.Drawing.Point(929, 8);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(21, 24);
            this.lbltarih.TabIndex = 18;
            this.lbltarih.Text = "0";
            this.lbltarih.Visible = false;
            // 
            // lblkitapsayisi
            // 
            this.lblkitapsayisi.AutoSize = true;
            this.lblkitapsayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblkitapsayisi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkitapsayisi.ForeColor = System.Drawing.Color.White;
            this.lblkitapsayisi.Location = new System.Drawing.Point(808, 11);
            this.lblkitapsayisi.Name = "lblkitapsayisi";
            this.lblkitapsayisi.Size = new System.Drawing.Size(21, 24);
            this.lblkitapsayisi.TabIndex = 18;
            this.lblkitapsayisi.Text = "0";
            this.lblkitapsayisi.Visible = false;
            // 
            // Frmyonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 501);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.lblkitapsayisi);
            this.Controls.Add(this.lblborc);
            this.Controls.Add(this.lblkullaniciadi);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmyonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Frmyonetici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
        public System.Windows.Forms.Label lblkullaniciadi;
        public System.Windows.Forms.Label lblborc;
        public System.Windows.Forms.Label lbltarih;
        public System.Windows.Forms.Label lblkitapsayisi;
    }
}