namespace BeyazPerdeForm
{
    partial class frmFilmEkle
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
            lsvFilmler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFilmAd = new TextBox();
            dtpYayin = new DateTimePicker();
            cmbYonetmen = new ComboBox();
            lbOyuncular = new ListBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            SuspendLayout();
            // 
            // lsvFilmler
            // 
            lsvFilmler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lsvFilmler.FullRowSelect = true;
            lsvFilmler.GridLines = true;
            lsvFilmler.Location = new Point(12, 12);
            lsvFilmler.Name = "lsvFilmler";
            lsvFilmler.Size = new Size(339, 521);
            lsvFilmler.TabIndex = 0;
            lsvFilmler.UseCompatibleStateImageBehavior = false;
            lsvFilmler.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Film Ad";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Yayınlanma Tarihi";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Yonetmen";
            columnHeader3.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 36);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Film Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 102);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 2;
            label2.Text = "Yayınlanma Tarihi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 159);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 3;
            label3.Text = "Yönetmeni :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 211);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 4;
            label4.Text = "Oyuncuları :";
            // 
            // txtFilmAd
            // 
            txtFilmAd.Location = new Point(572, 29);
            txtFilmAd.Name = "txtFilmAd";
            txtFilmAd.Size = new Size(250, 27);
            txtFilmAd.TabIndex = 5;
            // 
            // dtpYayin
            // 
            dtpYayin.Location = new Point(572, 97);
            dtpYayin.Name = "dtpYayin";
            dtpYayin.Size = new Size(250, 27);
            dtpYayin.TabIndex = 6;
            // 
            // cmbYonetmen
            // 
            cmbYonetmen.FormattingEnabled = true;
            cmbYonetmen.Location = new Point(572, 159);
            cmbYonetmen.Name = "cmbYonetmen";
            cmbYonetmen.Size = new Size(250, 28);
            cmbYonetmen.TabIndex = 7;
            // 
            // lbOyuncular
            // 
            lbOyuncular.FormattingEnabled = true;
            lbOyuncular.Location = new Point(572, 223);
            lbOyuncular.Name = "lbOyuncular";
            lbOyuncular.SelectionMode = SelectionMode.MultiSimple;
            lbOyuncular.Size = new Size(250, 224);
            lbOyuncular.TabIndex = 8;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(395, 292);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(395, 351);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(395, 407);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 9;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // frmFilmEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 693);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(lbOyuncular);
            Controls.Add(cmbYonetmen);
            Controls.Add(dtpYayin);
            Controls.Add(txtFilmAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lsvFilmler);
            Name = "frmFilmEkle";
            Text = "frmFilmEkle";
            Load += frmFilmEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvFilmler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFilmAd;
        private DateTimePicker dtpYayin;
        private ComboBox cmbYonetmen;
        private ListBox lbOyuncular;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
    }
}