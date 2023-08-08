namespace EntityFrameworkUdemy
{
    partial class UrunForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxUrunId = new System.Windows.Forms.Label();
            this.TextboxFiyat = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textFiyat = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.butonGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxUrunId
            // 
            this.textBoxUrunId.AutoSize = true;
            this.textBoxUrunId.Location = new System.Drawing.Point(52, 264);
            this.textBoxUrunId.Name = "textBoxUrunId";
            this.textBoxUrunId.Size = new System.Drawing.Size(55, 16);
            this.textBoxUrunId.TabIndex = 1;
            this.textBoxUrunId.Text = "Ürün Id :";
            this.textBoxUrunId.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TextboxFiyat
            // 
            this.TextboxFiyat.AutoSize = true;
            this.TextboxFiyat.Location = new System.Drawing.Point(52, 390);
            this.TextboxFiyat.Name = "TextboxFiyat";
            this.TextboxFiyat.Size = new System.Drawing.Size(42, 16);
            this.TextboxFiyat.TabIndex = 2;
            this.TextboxFiyat.Text = "Fiyat :";
            // 
            // textBoxAd
            // 
            this.textBoxAd.AutoSize = true;
            this.textBoxAd.Location = new System.Drawing.Point(52, 325);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(30, 16);
            this.textBoxAd.TabIndex = 3;
            this.textBoxAd.Text = "Ad :";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(179, 264);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 22);
            this.textId.TabIndex = 4;
            // 
            // textFiyat
            // 
            this.textFiyat.Location = new System.Drawing.Point(179, 387);
            this.textFiyat.Name = "textFiyat";
            this.textFiyat.Size = new System.Drawing.Size(100, 22);
            this.textFiyat.TabIndex = 5;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(179, 325);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(100, 22);
            this.textAd.TabIndex = 6;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(350, 335);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(156, 62);
            this.buttonEkle.TabIndex = 7;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(529, 264);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(156, 65);
            this.buttonList.TabIndex = 8;
            this.buttonList.Text = "Tüm Liste";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(529, 332);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(156, 65);
            this.buttonSil.TabIndex = 9;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            // 
            // butonGuncelle
            // 
            this.butonGuncelle.Location = new System.Drawing.Point(350, 264);
            this.butonGuncelle.Name = "butonGuncelle";
            this.butonGuncelle.Size = new System.Drawing.Size(156, 65);
            this.butonGuncelle.TabIndex = 10;
            this.butonGuncelle.Text = "Güncelle";
            this.butonGuncelle.UseVisualStyleBackColor = true;
            // 
            // UrunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butonGuncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.textFiyat);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.TextboxFiyat);
            this.Controls.Add(this.textBoxUrunId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrunForm";
            this.Text = "UrunlerFormcs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label textBoxUrunId;
        private System.Windows.Forms.Label TextboxFiyat;
        private System.Windows.Forms.Label textBoxAd;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textFiyat;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button butonGuncelle;
    }
}