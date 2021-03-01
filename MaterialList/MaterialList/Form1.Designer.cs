
namespace MaterialList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ekle_button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imal_textBox6 = new System.Windows.Forms.TextBox();
            this.detay_textBox5 = new System.Windows.Forms.TextBox();
            this.yer_textBox4 = new System.Windows.Forms.TextBox();
            this.Fiyat_textBox3 = new System.Windows.Forms.TextBox();
            this.Marka_textBox2 = new System.Windows.Forms.TextBox();
            this.Ad_textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ekle_button1
            // 
            this.ekle_button1.AutoSize = true;
            this.ekle_button1.BackColor = System.Drawing.Color.Black;
            this.ekle_button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ekle_button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ekle_button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ekle_button1.ForeColor = System.Drawing.Color.White;
            this.ekle_button1.Location = new System.Drawing.Point(98, 264);
            this.ekle_button1.Name = "ekle_button1";
            this.ekle_button1.Size = new System.Drawing.Size(477, 29);
            this.ekle_button1.TabIndex = 0;
            this.ekle_button1.Text = "EKLE";
            this.ekle_button1.UseVisualStyleBackColor = false;
            this.ekle_button1.Click += new System.EventHandler(this.ekle_button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.imal_textBox6);
            this.groupBox1.Controls.Add(this.detay_textBox5);
            this.groupBox1.Controls.Add(this.yer_textBox4);
            this.groupBox1.Controls.Add(this.Fiyat_textBox3);
            this.groupBox1.Controls.Add(this.Marka_textBox2);
            this.groupBox1.Controls.Add(this.Ad_textBox1);
            this.groupBox1.Controls.Add(this.ekle_button1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 676);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MALZEMENIN ; ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(54, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 208);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EN SON EKLENENLER: ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "İMAL ŞEKLİ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "DETAY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "ALINACAĞI YER:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "FİYATI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "MARKASI / TANIMI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADI:";
            // 
            // imal_textBox6
            // 
            this.imal_textBox6.BackColor = System.Drawing.Color.Black;
            this.imal_textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imal_textBox6.ForeColor = System.Drawing.Color.White;
            this.imal_textBox6.Location = new System.Drawing.Point(264, 210);
            this.imal_textBox6.Name = "imal_textBox6";
            this.imal_textBox6.Size = new System.Drawing.Size(311, 27);
            this.imal_textBox6.TabIndex = 1;
            // 
            // detay_textBox5
            // 
            this.detay_textBox5.BackColor = System.Drawing.Color.Black;
            this.detay_textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detay_textBox5.ForeColor = System.Drawing.Color.White;
            this.detay_textBox5.Location = new System.Drawing.Point(264, 177);
            this.detay_textBox5.Name = "detay_textBox5";
            this.detay_textBox5.Size = new System.Drawing.Size(311, 27);
            this.detay_textBox5.TabIndex = 1;
            // 
            // yer_textBox4
            // 
            this.yer_textBox4.BackColor = System.Drawing.Color.Black;
            this.yer_textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yer_textBox4.ForeColor = System.Drawing.Color.White;
            this.yer_textBox4.Location = new System.Drawing.Point(264, 144);
            this.yer_textBox4.Name = "yer_textBox4";
            this.yer_textBox4.Size = new System.Drawing.Size(311, 27);
            this.yer_textBox4.TabIndex = 1;
            // 
            // Fiyat_textBox3
            // 
            this.Fiyat_textBox3.BackColor = System.Drawing.Color.Black;
            this.Fiyat_textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fiyat_textBox3.ForeColor = System.Drawing.Color.White;
            this.Fiyat_textBox3.Location = new System.Drawing.Point(264, 111);
            this.Fiyat_textBox3.Name = "Fiyat_textBox3";
            this.Fiyat_textBox3.Size = new System.Drawing.Size(311, 27);
            this.Fiyat_textBox3.TabIndex = 1;
            // 
            // Marka_textBox2
            // 
            this.Marka_textBox2.BackColor = System.Drawing.Color.Black;
            this.Marka_textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Marka_textBox2.ForeColor = System.Drawing.Color.White;
            this.Marka_textBox2.Location = new System.Drawing.Point(264, 78);
            this.Marka_textBox2.Name = "Marka_textBox2";
            this.Marka_textBox2.Size = new System.Drawing.Size(311, 27);
            this.Marka_textBox2.TabIndex = 1;
            // 
            // Ad_textBox1
            // 
            this.Ad_textBox1.BackColor = System.Drawing.Color.Black;
            this.Ad_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ad_textBox1.ForeColor = System.Drawing.Color.White;
            this.Ad_textBox1.Location = new System.Drawing.Point(264, 45);
            this.Ad_textBox1.Name = "Ad_textBox1";
            this.Ad_textBox1.Size = new System.Drawing.Size(311, 27);
            this.Ad_textBox1.TabIndex = 1;
            this.Ad_textBox1.TextChanged += new System.EventHandler(this.Ad_textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ekle_button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imal_textBox6;
        private System.Windows.Forms.TextBox detay_textBox5;
        private System.Windows.Forms.TextBox yer_textBox4;
        private System.Windows.Forms.TextBox Fiyat_textBox3;
        private System.Windows.Forms.TextBox Marka_textBox2;
        private System.Windows.Forms.TextBox Ad_textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

