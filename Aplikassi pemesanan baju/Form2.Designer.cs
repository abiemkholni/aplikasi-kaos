using System;

namespace Aplikassi_pemesanan_baju
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.btnKeranjang = new System.Windows.Forms.Button();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.Item = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.cmbUkuran = new System.Windows.Forms.ComboBox();
            this.Ukuran = new System.Windows.Forms.Label();
            this.Harga = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.Jumlah = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiskon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fadetimer = new System.Windows.Forms.Timer(this.components);
            this.movietimer = new System.Windows.Forms.Timer(this.components);
            this.labelloading = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 89);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(263, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 34);
            this.label4.TabIndex = 20;
            this.label4.Text = "Selamat Berbelanja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(111, 166);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(168, 26);
            this.txtNama.TabIndex = 2;
            // 
            // btnKeranjang
            // 
            this.btnKeranjang.Location = new System.Drawing.Point(353, 355);
            this.btnKeranjang.Name = "btnKeranjang";
            this.btnKeranjang.Size = new System.Drawing.Size(130, 37);
            this.btnKeranjang.TabIndex = 4;
            this.btnKeranjang.Text = "Keranjang";
            this.btnKeranjang.UseVisualStyleBackColor = true;
            this.btnKeranjang.Click += new System.EventHandler(this.btnKeranjang_Click);
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(111, 301);
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(120, 26);
            this.nudJumlah.TabIndex = 5;
            this.nudJumlah.ValueChanged += new System.EventHandler(this.nudJumlah_ValueChanged);
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Location = new System.Drawing.Point(31, 216);
            this.Item.Name = "Item";
            this.Item.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Item.Size = new System.Drawing.Size(41, 20);
            this.Item.TabIndex = 6;
            this.Item.Text = "Item";
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(111, 208);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(168, 28);
            this.cmbItem.TabIndex = 7;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // cmbUkuran
            // 
            this.cmbUkuran.FormattingEnabled = true;
            this.cmbUkuran.Location = new System.Drawing.Point(111, 242);
            this.cmbUkuran.Name = "cmbUkuran";
            this.cmbUkuran.Size = new System.Drawing.Size(168, 28);
            this.cmbUkuran.TabIndex = 8;
            this.cmbUkuran.SelectedIndexChanged += new System.EventHandler(this.cmbUkuran_SelectedIndexChanged);
            // 
            // Ukuran
            // 
            this.Ukuran.AutoSize = true;
            this.Ukuran.Location = new System.Drawing.Point(31, 250);
            this.Ukuran.Name = "Ukuran";
            this.Ukuran.Size = new System.Drawing.Size(61, 20);
            this.Ukuran.TabIndex = 9;
            this.Ukuran.Text = "Ukuran";
            // 
            // Harga
            // 
            this.Harga.AutoSize = true;
            this.Harga.Location = new System.Drawing.Point(31, 355);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(53, 20);
            this.Harga.TabIndex = 10;
            this.Harga.Text = "Harga";
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(111, 355);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(168, 26);
            this.txtHarga.TabIndex = 11;
            // 
            // Jumlah
            // 
            this.Jumlah.AutoSize = true;
            this.Jumlah.Location = new System.Drawing.Point(31, 307);
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Size = new System.Drawing.Size(60, 20);
            this.Jumlah.TabIndex = 12;
            this.Jumlah.Text = "Jumlah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Diskon";
            // 
            // txtDiskon
            // 
            this.txtDiskon.Location = new System.Drawing.Point(445, 172);
            this.txtDiskon.Name = "txtDiskon";
            this.txtDiskon.Size = new System.Drawing.Size(168, 26);
            this.txtDiskon.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pembelian di atas 50.000 diskon 10%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Tambah Pesanan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(15, 422);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(773, 144);
            this.listBox1.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 585);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "Batal Pesanan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 585);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 37);
            this.button3.TabIndex = 19;
            this.button3.Text = "Lanjut Check Out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 669);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 42);
            this.progressBar1.TabIndex = 20;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fadetimer
            // 
            this.fadetimer.Tick += new System.EventHandler(this.fadetimer_Tick);
            // 
            // movietimer
            // 
            this.movietimer.Tick += new System.EventHandler(this.movietimer_Tick);
            // 
            // labelloading
            // 
            this.labelloading.AutoSize = true;
            this.labelloading.Location = new System.Drawing.Point(2, 683);
            this.labelloading.Name = "labelloading";
            this.labelloading.Size = new System.Drawing.Size(74, 20);
            this.labelloading.TabIndex = 21;
            this.labelloading.Text = "Loading..";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 712);
            this.Controls.Add(this.labelloading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiskon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Jumlah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.Ukuran);
            this.Controls.Add(this.cmbUkuran);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.nudJumlah);
            this.Controls.Add(this.btnKeranjang);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void fadetimer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnKeranjang;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.ComboBox cmbUkuran;
        private System.Windows.Forms.Label Ukuran;
        private System.Windows.Forms.Label Harga;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label Jumlah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiskon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer fadetimer;
        private System.Windows.Forms.Timer movietimer;
        private System.Windows.Forms.Label labelloading;
    }
}