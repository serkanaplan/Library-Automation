namespace kotomasyon
{
    partial class Frmodunclistele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmodunclistele));
            this.btnexit = new System.Windows.Forms.Button();
            this.datagridodunc = new System.Windows.Forms.DataGridView();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.txtara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioodunc = new System.Windows.Forms.RadioButton();
            this.radioiade = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridodunc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(1361, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(39, 32);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // datagridodunc
            // 
            this.datagridodunc.AllowUserToAddRows = false;
            this.datagridodunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridodunc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.datagridodunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridodunc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridodunc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridodunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridodunc.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridodunc.GridColor = System.Drawing.Color.White;
            this.datagridodunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datagridodunc.Location = new System.Drawing.Point(28, 36);
            this.datagridodunc.Name = "datagridodunc";
            this.datagridodunc.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridodunc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridodunc.RowHeadersVisible = false;
            this.datagridodunc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sans Serif Collection", 6F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.datagridodunc.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridodunc.RowTemplate.Height = 24;
            this.datagridodunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridodunc.Size = new System.Drawing.Size(1341, 360);
            this.datagridodunc.TabIndex = 40;
            this.datagridodunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridodunc_CellClick);
            this.datagridodunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridodunc_CellContentClick);
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
            this.btnguncelle.Location = new System.Drawing.Point(576, 523);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(153, 183);
            this.btnguncelle.TabIndex = 42;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // txtara
            // 
            this.txtara.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtara.Location = new System.Drawing.Point(1185, 431);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(184, 26);
            this.txtara.TabIndex = 43;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(513, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Ödünç Alınan Veyaİade Edilen Kitaplar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(982, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Ara(tc/ad/isbn/kitap adı) :";
            // 
            // radioodunc
            // 
            this.radioodunc.AutoSize = true;
            this.radioodunc.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioodunc.ForeColor = System.Drawing.Color.White;
            this.radioodunc.Location = new System.Drawing.Point(576, 474);
            this.radioodunc.Name = "radioodunc";
            this.radioodunc.Size = new System.Drawing.Size(77, 25);
            this.radioodunc.TabIndex = 45;
            this.radioodunc.TabStop = true;
            this.radioodunc.Text = "Ödunç";
            this.radioodunc.UseVisualStyleBackColor = true;
            // 
            // radioiade
            // 
            this.radioiade.AutoSize = true;
            this.radioiade.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioiade.ForeColor = System.Drawing.Color.White;
            this.radioiade.Location = new System.Drawing.Point(666, 474);
            this.radioiade.Name = "radioiade";
            this.radioiade.Size = new System.Drawing.Size(63, 25);
            this.radioiade.TabIndex = 45;
            this.radioiade.TabStop = true;
            this.radioiade.Text = "İade";
            this.radioiade.UseVisualStyleBackColor = true;
            // 
            // Frmodunclistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.radioiade);
            this.Controls.Add(this.radioodunc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.datagridodunc);
            this.Controls.Add(this.btnexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmodunclistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmodunclistele";
            this.Load += new System.EventHandler(this.Frmodunclistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridodunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView datagridodunc;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioodunc;
        private System.Windows.Forms.RadioButton radioiade;
    }
}