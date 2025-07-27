namespace Aplikassi_pemesanan_baju
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textnama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textsandi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.movietimer = new System.Windows.Forms.Timer(this.components);
            this.fadetimer = new System.Windows.Forms.Timer(this.components);
            this.labelLoading = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // textnama
            // 
            this.textnama.Location = new System.Drawing.Point(235, 320);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(224, 26);
            this.textnama.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sandi";
            // 
            // textsandi
            // 
            this.textsandi.Location = new System.Drawing.Point(235, 394);
            this.textsandi.Name = "textsandi";
            this.textsandi.Size = new System.Drawing.Size(224, 26);
            this.textsandi.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Silahkan Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 563);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(703, 47);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // movietimer
            // 
            this.movietimer.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // fadetimer
            // 
            this.fadetimer.Tick += new System.EventHandler(this.fadetimer_Tick);
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.Color.AliceBlue;
            this.labelLoading.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(-1, 575);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(91, 24);
            this.labelLoading.TabIndex = 7;
            this.labelLoading.Text = "Loading..";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(197, 189);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(304, 332);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aplikassi_pemesanan_baju.Properties.Resources.b5ae19e2ff80badebcad2b1867af21f6;
            this.pictureBox1.Location = new System.Drawing.Point(261, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(706, 636);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textsandi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textnama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textnama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textsandi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer movietimer;
        private System.Windows.Forms.Timer fadetimer;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

