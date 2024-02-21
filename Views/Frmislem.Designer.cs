namespace kotomasyon
{
    partial class Frmislem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmislem));
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lblkitapsayisi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblborc = new System.Windows.Forms.Label();
            this.datagridodunc = new System.Windows.Forms.DataGridView();
            this.datagridkitap = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridodunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridkitap)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(1129, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 31);
            this.button6.TabIndex = 4;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnexit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(442, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "-Ödünç Al Veya İade Et-";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbltarih);
            this.groupBox1.Controls.Add(this.lblkitapsayisi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblborc);
            this.groupBox1.Controls.Add(this.datagridodunc);
            this.groupBox1.Controls.Add(this.datagridkitap);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(34, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1096, 690);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(796, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "-Güncel Borcunuz -";
            // 
            // txtara
            // 
            this.txtara.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtara.Location = new System.Drawing.Point(852, 21);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(225, 28);
            this.txtara.TabIndex = 23;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(525, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kitap Ara(İsbn,Yazar Veya KitapAdı):";
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Location = new System.Drawing.Point(1011, 643);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(19, 21);
            this.lbltarih.TabIndex = 22;
            this.lbltarih.Text = "0";
            this.lbltarih.Visible = false;
            // 
            // lblkitapsayisi
            // 
            this.lblkitapsayisi.AutoSize = true;
            this.lblkitapsayisi.Location = new System.Drawing.Point(1046, 643);
            this.lblkitapsayisi.Name = "lblkitapsayisi";
            this.lblkitapsayisi.Size = new System.Drawing.Size(19, 21);
            this.lblkitapsayisi.TabIndex = 22;
            this.lblkitapsayisi.Text = "0";
            this.lblkitapsayisi.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(930, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 36);
            this.label6.TabIndex = 21;
            this.label6.Text = "₺";
            // 
            // lblborc
            // 
            this.lblborc.AutoSize = true;
            this.lblborc.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblborc.Location = new System.Drawing.Point(886, 576);
            this.lblborc.Name = "lblborc";
            this.lblborc.Size = new System.Drawing.Size(32, 36);
            this.lblborc.TabIndex = 21;
            this.lblborc.Text = "0";
            // 
            // datagridodunc
            // 
            this.datagridodunc.AllowUserToAddRows = false;
            this.datagridodunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridodunc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.datagridodunc.BackgroundColor = System.Drawing.Color.Gray;
            this.datagridodunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridodunc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.datagridodunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridodunc.GridColor = System.Drawing.Color.White;
            this.datagridodunc.Location = new System.Drawing.Point(20, 349);
            this.datagridodunc.Name = "datagridodunc";
            this.datagridodunc.ReadOnly = true;
            this.datagridodunc.RowHeadersVisible = false;
            this.datagridodunc.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.datagridodunc.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridodunc.RowTemplate.Height = 24;
            this.datagridodunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridodunc.Size = new System.Drawing.Size(1057, 128);
            this.datagridodunc.TabIndex = 19;
            // 
            // datagridkitap
            // 
            this.datagridkitap.AllowUserToAddRows = false;
            this.datagridkitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridkitap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.datagridkitap.BackgroundColor = System.Drawing.Color.Gray;
            this.datagridkitap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridkitap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.datagridkitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridkitap.GridColor = System.Drawing.Color.White;
            this.datagridkitap.Location = new System.Drawing.Point(20, 60);
            this.datagridkitap.Name = "datagridkitap";
            this.datagridkitap.ReadOnly = true;
            this.datagridkitap.RowHeadersVisible = false;
            this.datagridkitap.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.datagridkitap.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridkitap.RowTemplate.Height = 24;
            this.datagridkitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridkitap.Size = new System.Drawing.Size(1057, 240);
            this.datagridkitap.TabIndex = 19;
            this.datagridkitap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridkitap_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(99, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 182);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ödünç Al";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnoduncal);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(342, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 179);
            this.button2.TabIndex = 13;
            this.button2.Text = "İade Et";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btniadeet);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(592, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 182);
            this.button3.TabIndex = 15;
            this.button3.Text = "Süre Uzat";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnsureuzat);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(534, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "İade Etmek Veya Süresini Uzatmak İstediğiniz Kitabı Aşağıdan Seçiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ödünç Almak İstediğiniz Kitabı Aşağıdan Seçiniz";
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.BackColor = System.Drawing.Color.Transparent;
            this.lblkullaniciadi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullaniciadi.ForeColor = System.Drawing.Color.White;
            this.lblkullaniciadi.Location = new System.Drawing.Point(40, 7);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(132, 24);
            this.lblkullaniciadi.TabIndex = 17;
            this.lblkullaniciadi.Text = "Kullanıcı Adı :";
            // 
            // Frmislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1166, 764);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lblkullaniciadi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmislem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci İşlemleri Ekranı";
            this.Load += new System.EventHandler(this.frmkullanici_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridodunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridkitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView datagridkitap;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblkullaniciadi;
        public System.Windows.Forms.Label lblkitapsayisi;
        public System.Windows.Forms.Label lblborc;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridodunc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbltarih;
    }
}