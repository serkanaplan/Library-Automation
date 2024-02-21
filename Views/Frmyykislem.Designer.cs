namespace kotomasyon
{
    partial class Frmyykislem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmyykislem));
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.datagridyyk = new System.Windows.Forms.DataGridView();
            this.lbltablo = new System.Windows.Forms.Label();
            this.txtyykdeger = new System.Windows.Forms.TextBox();
            this.lblbaslik = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridyyk)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(637, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(31, 29);
            this.btnexit.TabIndex = 39;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.datagridyyk);
            this.groupBox1.Controls.Add(this.lbltablo);
            this.groupBox1.Controls.Add(this.txtyykdeger);
            this.groupBox1.Location = new System.Drawing.Point(39, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 485);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Transparent;
            this.btnsil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsil.BackgroundImage")));
            this.btnsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsil.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(369, 336);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(113, 125);
            this.btnsil.TabIndex = 47;
            this.btnsil.Text = "Sil";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnguncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguncelle.BackgroundImage")));
            this.btnguncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnguncelle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguncelle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ForeColor = System.Drawing.Color.White;
            this.btnguncelle.Location = new System.Drawing.Point(239, 336);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(113, 125);
            this.btnguncelle.TabIndex = 48;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Transparent;
            this.btnekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnekle.BackgroundImage")));
            this.btnekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnekle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnekle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.White;
            this.btnekle.Location = new System.Drawing.Point(109, 336);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(113, 125);
            this.btnekle.TabIndex = 49;
            this.btnekle.Text = "Ekle";
            this.btnekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // datagridyyk
            // 
            this.datagridyyk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridyyk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.datagridyyk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridyyk.Location = new System.Drawing.Point(109, 37);
            this.datagridyyk.Name = "datagridyyk";
            this.datagridyyk.ReadOnly = true;
            this.datagridyyk.RowHeadersVisible = false;
            this.datagridyyk.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagridyyk.RowTemplate.Height = 24;
            this.datagridyyk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridyyk.Size = new System.Drawing.Size(373, 222);
            this.datagridyyk.TabIndex = 46;
            this.datagridyyk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridyyk_CellClick);
            // 
            // lbltablo
            // 
            this.lbltablo.AutoSize = true;
            this.lbltablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltablo.ForeColor = System.Drawing.Color.White;
            this.lbltablo.Location = new System.Drawing.Point(123, 280);
            this.lbltablo.Name = "lbltablo";
            this.lbltablo.Size = new System.Drawing.Size(110, 20);
            this.lbltablo.TabIndex = 45;
            this.lbltablo.Text = "Kategori Adı :";
            // 
            // txtyykdeger
            // 
            this.txtyykdeger.Location = new System.Drawing.Point(239, 277);
            this.txtyykdeger.Name = "txtyykdeger";
            this.txtyykdeger.Size = new System.Drawing.Size(225, 23);
            this.txtyykdeger.TabIndex = 44;
            // 
            // lblbaslik
            // 
            this.lblbaslik.AutoSize = true;
            this.lblbaslik.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbaslik.ForeColor = System.Drawing.Color.White;
            this.lblbaslik.Location = new System.Drawing.Point(246, 3);
            this.lblbaslik.Name = "lblbaslik";
            this.lblbaslik.Size = new System.Drawing.Size(181, 21);
            this.lblbaslik.TabIndex = 45;
            this.lblbaslik.Text = "Kategori İşlem Sayfası";
            // 
            // Frmyykislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(670, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lblbaslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmyykislem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yykislemleri";
            this.Load += new System.EventHandler(this.Frmyykislem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridyyk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        public System.Windows.Forms.DataGridView datagridyyk;
        public System.Windows.Forms.Label lbltablo;
        private System.Windows.Forms.TextBox txtyykdeger;
        public System.Windows.Forms.Label lblbaslik;
    }
}