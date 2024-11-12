namespace BeyazPerdeForm
{
    partial class frmYonetmenEkle
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
            groupBox1 = new GroupBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            dtpDogumTarihi = new DateTimePicker();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lsvYonetmenler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(dtpDogumTarihi);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(690, 244);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yonetmen Ekle";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(477, 131);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 29);
            btnSil.TabIndex = 5;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(477, 83);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(110, 29);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(477, 35);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(110, 29);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(162, 140);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(250, 27);
            dtpDogumTarihi.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(162, 83);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(250, 27);
            txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(162, 37);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(250, 27);
            txtAd.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 140);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Doğum Tarihi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 90);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 44);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // lsvYonetmenler
            // 
            lsvYonetmenler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvYonetmenler.FullRowSelect = true;
            lsvYonetmenler.GridLines = true;
            lsvYonetmenler.Location = new Point(25, 322);
            lsvYonetmenler.MultiSelect = false;
            lsvYonetmenler.Name = "lsvYonetmenler";
            lsvYonetmenler.Size = new Size(690, 307);
            lsvYonetmenler.TabIndex = 1;
            lsvYonetmenler.UseCompatibleStateImageBehavior = false;
            lsvYonetmenler.View = View.Details;
            lsvYonetmenler.SelectedIndexChanged += lsvYonetmenler_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyad";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Doğum Tarihi";
            columnHeader4.Width = 150;
            // 
            // frmYonetmenEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 659);
            Controls.Add(lsvYonetmenler);
            Controls.Add(groupBox1);
            Name = "frmYonetmenEkle";
            Text = "frmYonetmenEkle";
            Load += frmYonetmenEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private DateTimePicker dtpDogumTarihi;
        private ListView lsvYonetmenler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}