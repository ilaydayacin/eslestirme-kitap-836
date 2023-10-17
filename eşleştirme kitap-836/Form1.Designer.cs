namespace eşleştirme_kitap_836
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbResim = new System.Windows.Forms.RadioButton();
            this.lbUzanti = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbUzanti);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uzantı türü";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbResim);
            this.groupBox2.Controls.Add(this.rbVideo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(249, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dosya türü";
            // 
            // btnKontrol
            // 
            this.btnKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrol.Location = new System.Drawing.Point(121, 220);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(213, 111);
            this.btnKontrol.TabIndex = 2;
            this.btnKontrol.Text = "Kontrol et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Location = new System.Drawing.Point(27, 57);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(125, 24);
            this.rbVideo.TabIndex = 0;
            this.rbVideo.TabStop = true;
            this.rbVideo.Text = "Video dosyası";
            this.rbVideo.UseVisualStyleBackColor = true;
            // 
            // rbResim
            // 
            this.rbResim.AutoSize = true;
            this.rbResim.Location = new System.Drawing.Point(27, 99);
            this.rbResim.Name = "rbResim";
            this.rbResim.Size = new System.Drawing.Size(129, 24);
            this.rbResim.TabIndex = 1;
            this.rbResim.TabStop = true;
            this.rbResim.Text = "Resim dosyası";
            this.rbResim.UseVisualStyleBackColor = true;
            // 
            // lbUzanti
            // 
            this.lbUzanti.FormattingEnabled = true;
            this.lbUzanti.ItemHeight = 20;
            this.lbUzanti.Items.AddRange(new object[] {
            "MP4",
            "JPG",
            "MOV",
            "PNG"});
            this.lbUzanti.Location = new System.Drawing.Point(20, 34);
            this.lbUzanti.Name = "lbUzanti";
            this.lbUzanti.Size = new System.Drawing.Size(150, 124);
            this.lbUzanti.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbUzanti;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbResim;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.Button btnKontrol;
    }
}

