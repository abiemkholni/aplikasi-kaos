namespace Aplikassi_pemesanan_baju
{
    partial class Form3
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
            this.labelMode = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSlesaiQris = new System.Windows.Forms.Button();
            this.picQRIS = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picQRIS)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(257, 103);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(51, 20);
            this.labelMode.TabIndex = 0;
            this.labelMode.Text = "label1";
            this.labelMode.Click += new System.EventHandler(this.labelMode_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "QRIS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSlesaiQris
            // 
            this.btnSlesaiQris.Location = new System.Drawing.Point(195, 443);
            this.btnSlesaiQris.Name = "btnSlesaiQris";
            this.btnSlesaiQris.Size = new System.Drawing.Size(75, 31);
            this.btnSlesaiQris.TabIndex = 3;
            this.btnSlesaiQris.Text = "Selesai";
            this.btnSlesaiQris.UseVisualStyleBackColor = true;
            this.btnSlesaiQris.Click += new System.EventHandler(this.btnSlesaiQris_Click);
            // 
            // picQRIS
            // 
            this.picQRIS.Location = new System.Drawing.Point(480, 264);
            this.picQRIS.Name = "picQRIS";
            this.picQRIS.Size = new System.Drawing.Size(256, 223);
            this.picQRIS.TabIndex = 4;
            this.picQRIS.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Detail Pesanan Anda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Silahkan Pilih Metode Pembayaran";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picQRIS);
            this.Controls.Add(this.btnSlesaiQris);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMode);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQRIS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSlesaiQris;
        private System.Windows.Forms.PictureBox picQRIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}