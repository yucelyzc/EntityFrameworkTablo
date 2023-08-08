namespace EntityFrameworkUdemy
{
    partial class SiparisForm
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
            this.sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guncelle = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.textBoxSiparisNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAdet = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMusteriid = new System.Windows.Forms.ComboBox();
            this.comboBoxUrunId = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(650, 262);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(113, 58);
            this.sil.TabIndex = 0;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 207);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Müşteri Id :";
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(650, 364);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(113, 55);
            this.guncelle.TabIndex = 6;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(482, 365);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(113, 58);
            this.ekle.TabIndex = 7;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            // 
            // textBoxSiparisNo
            // 
            this.textBoxSiparisNo.Location = new System.Drawing.Point(233, 256);
            this.textBoxSiparisNo.Name = "textBoxSiparisNo";
            this.textBoxSiparisNo.Size = new System.Drawing.Size(100, 22);
            this.textBoxSiparisNo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sipariş :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adet :";
            // 
            // textBoxAdet
            // 
            this.textBoxAdet.Location = new System.Drawing.Point(233, 419);
            this.textBoxAdet.Name = "textBoxAdet";
            this.textBoxAdet.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdet.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(233, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // comboBoxMusteriid
            // 
            this.comboBoxMusteriid.FormattingEnabled = true;
            this.comboBoxMusteriid.Location = new System.Drawing.Point(233, 341);
            this.comboBoxMusteriid.Name = "comboBoxMusteriid";
            this.comboBoxMusteriid.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMusteriid.TabIndex = 15;
            // 
            // comboBoxUrunId
            // 
            this.comboBoxUrunId.FormattingEnabled = true;
            this.comboBoxUrunId.Location = new System.Drawing.Point(233, 380);
            this.comboBoxUrunId.Name = "comboBoxUrunId";
            this.comboBoxUrunId.Size = new System.Drawing.Size(121, 24);
            this.comboBoxUrunId.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(482, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 58);
            this.button4.TabIndex = 17;
            this.button4.Text = "Listele";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBoxUrunId);
            this.Controls.Add(this.comboBoxMusteriid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxAdet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSiparisNo);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sil);
            this.Name = "SiparisForm";
            this.Text = "SiparisFormcs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox textBoxSiparisNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAdet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxMusteriid;
        private System.Windows.Forms.ComboBox comboBoxUrunId;
        private System.Windows.Forms.Button button4;
    }
}