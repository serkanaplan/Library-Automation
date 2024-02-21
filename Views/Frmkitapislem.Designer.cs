namespace kotomasyon
{
    partial class Frmkitapislem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmkitapislem));
            this.txtara = new System.Windows.Forms.TextBox();
            this.datagridkitap = new System.Windows.Forms.DataGridView();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboyazar = new System.Windows.Forms.ComboBox();
            this.comboyayinevi = new System.Windows.Forms.ComboBox();
            this.combokategori = new System.Windows.Forms.ComboBox();
            this.btnyayinevi = new System.Windows.Forms.Button();
            this.btnkategori = new System.Windows.Forms.Button();
            this.btnyazar = new System.Windows.Forms.Button();
            this.lblstok = new System.Windows.Forms.Label();
            this.numericstok = new System.Windows.Forms.NumericUpDown();
            this.numericbaskiyili = new System.Windows.Forms.NumericUpDown();
            this.lblmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridkitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericstok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericbaskiyili)).BeginInit();
            this.SuspendLayout();
            // 
            // txtara
            // 
            this.txtara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtara.Location = new System.Drawing.Point(1131, 403);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(193, 24);
            this.txtara.TabIndex = 42;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // datagridkitap
            // 
            this.datagridkitap.AllowUserToAddRows = false;
            this.datagridkitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridkitap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.datagridkitap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridkitap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridkitap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridkitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridkitap.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridkitap.GridColor = System.Drawing.Color.White;
            this.datagridkitap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datagridkitap.Location = new System.Drawing.Point(35, 33);
            this.datagridkitap.Name = "datagridkitap";
            this.datagridkitap.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridkitap.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridkitap.RowHeadersVisible = false;
            this.datagridkitap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sans Serif Collection", 6F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.datagridkitap.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridkitap.RowTemplate.Height = 24;
            this.datagridkitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridkitap.Size = new System.Drawing.Size(1330, 342);
            this.datagridkitap.TabIndex = 39;
            this.datagridkitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridkitap_CellClick);
            this.datagridkitap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridkitap_CellContentClick);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Transparent;
            this.btnsil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsil.BackgroundImage")));
            this.btnsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsil.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(1194, 453);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(130, 183);
            this.btnsil.TabIndex = 31;
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
            this.btnguncelle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ForeColor = System.Drawing.Color.White;
            this.btnguncelle.Location = new System.Drawing.Point(1036, 453);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(130, 183);
            this.btnguncelle.TabIndex = 33;
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
            this.btnekle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.White;
            this.btnekle.Location = new System.Drawing.Point(881, 453);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(127, 183);
            this.btnekle.TabIndex = 34;
            this.btnekle.Text = "Ekle";
            this.btnekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(1369, 1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(31, 29);
            this.btnexit.TabIndex = 38;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(197, 417);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(170, 22);
            this.txtisbn.TabIndex = 17;
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Location = new System.Drawing.Point(197, 453);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(170, 22);
            this.txtkitapadi.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(587, -2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kitap İşlem Sayfası";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1072, 403);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "Ara :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "İsbn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kitap Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(61, 608);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Kategori adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(90, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Yazar adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Baskı Yılı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Yayınevi adı :";
            // 
            // comboyazar
            // 
            this.comboyazar.FormattingEnabled = true;
            this.comboyazar.Location = new System.Drawing.Point(197, 525);
            this.comboyazar.Name = "comboyazar";
            this.comboyazar.Size = new System.Drawing.Size(170, 24);
            this.comboyazar.TabIndex = 47;
            // 
            // comboyayinevi
            // 
            this.comboyayinevi.FormattingEnabled = true;
            this.comboyayinevi.Location = new System.Drawing.Point(197, 563);
            this.comboyayinevi.Name = "comboyayinevi";
            this.comboyayinevi.Size = new System.Drawing.Size(170, 24);
            this.comboyayinevi.TabIndex = 47;
            // 
            // combokategori
            // 
            this.combokategori.FormattingEnabled = true;
            this.combokategori.Location = new System.Drawing.Point(197, 601);
            this.combokategori.Name = "combokategori";
            this.combokategori.Size = new System.Drawing.Size(170, 24);
            this.combokategori.TabIndex = 47;
            // 
            // btnyayinevi
            // 
            this.btnyayinevi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnyayinevi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnyayinevi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyayinevi.ForeColor = System.Drawing.Color.White;
            this.btnyayinevi.Location = new System.Drawing.Point(373, 563);
            this.btnyayinevi.Name = "btnyayinevi";
            this.btnyayinevi.Size = new System.Drawing.Size(146, 24);
            this.btnyayinevi.TabIndex = 49;
            this.btnyayinevi.Text = "Yayınevi İşlemleri";
            this.btnyayinevi.UseVisualStyleBackColor = false;
            this.btnyayinevi.Click += new System.EventHandler(this.btnyayinevi_Click);
            // 
            // btnkategori
            // 
            this.btnkategori.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnkategori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkategori.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkategori.ForeColor = System.Drawing.Color.White;
            this.btnkategori.Location = new System.Drawing.Point(373, 601);
            this.btnkategori.Name = "btnkategori";
            this.btnkategori.Size = new System.Drawing.Size(146, 24);
            this.btnkategori.TabIndex = 49;
            this.btnkategori.Text = "Kategori İşlemleri";
            this.btnkategori.UseVisualStyleBackColor = false;
            this.btnkategori.Click += new System.EventHandler(this.btnkategori_Click);
            // 
            // btnyazar
            // 
            this.btnyazar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnyazar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnyazar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyazar.ForeColor = System.Drawing.Color.White;
            this.btnyazar.Location = new System.Drawing.Point(373, 525);
            this.btnyazar.Name = "btnyazar";
            this.btnyazar.Size = new System.Drawing.Size(145, 24);
            this.btnyazar.TabIndex = 50;
            this.btnyazar.Text = "Yazar İşlemleri";
            this.btnyazar.UseVisualStyleBackColor = false;
            this.btnyazar.Click += new System.EventHandler(this.btnyazar_Click);
            // 
            // lblstok
            // 
            this.lblstok.AutoSize = true;
            this.lblstok.BackColor = System.Drawing.Color.Transparent;
            this.lblstok.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstok.ForeColor = System.Drawing.Color.White;
            this.lblstok.Location = new System.Drawing.Point(130, 640);
            this.lblstok.Name = "lblstok";
            this.lblstok.Size = new System.Drawing.Size(61, 24);
            this.lblstok.TabIndex = 29;
            this.lblstok.Text = "Stok :";
            // 
            // numericstok
            // 
            this.numericstok.Location = new System.Drawing.Point(197, 639);
            this.numericstok.Name = "numericstok";
            this.numericstok.Size = new System.Drawing.Size(170, 22);
            this.numericstok.TabIndex = 52;
            this.numericstok.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericbaskiyili
            // 
            this.numericbaskiyili.Location = new System.Drawing.Point(199, 489);
            this.numericbaskiyili.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericbaskiyili.Name = "numericbaskiyili";
            this.numericbaskiyili.Size = new System.Drawing.Size(170, 22);
            this.numericbaskiyili.TabIndex = 52;
            this.numericbaskiyili.ValueChanged += new System.EventHandler(this.numericbaskiyili_ValueChanged);
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.BackColor = System.Drawing.Color.Transparent;
            this.lblmail.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmail.ForeColor = System.Drawing.Color.White;
            this.lblmail.Location = new System.Drawing.Point(31, 1);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(58, 24);
            this.lblmail.TabIndex = 25;
            this.lblmail.Text = "Mail :";
            // 
            // Frmkitapislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.numericbaskiyili);
            this.Controls.Add(this.numericstok);
            this.Controls.Add(this.btnyazar);
            this.Controls.Add(this.btnkategori);
            this.Controls.Add(this.btnyayinevi);
            this.Controls.Add(this.combokategori);
            this.Controls.Add(this.comboyayinevi);
            this.Controls.Add(this.comboyazar);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.datagridkitap);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.txtkitapadi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblstok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmkitapislem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmkitapislem";
            this.Load += new System.EventHandler(this.Frmkitapislem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridkitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericstok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericbaskiyili)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.DataGridView datagridkitap;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboyazar;
        private System.Windows.Forms.ComboBox comboyayinevi;
        private System.Windows.Forms.ComboBox combokategori;
        private System.Windows.Forms.Button btnyayinevi;
        private System.Windows.Forms.Button btnkategori;
        private System.Windows.Forms.Button btnyazar;
        private System.Windows.Forms.Label lblstok;
        private System.Windows.Forms.NumericUpDown numericstok;
        private System.Windows.Forms.NumericUpDown numericbaskiyili;
        public System.Windows.Forms.Label lblmail;
    }
}