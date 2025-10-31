namespace ödev1
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
            basla = new Button();
            dene = new Button();
            DEBUG = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            hak = new Label();
            label4 = new Label();
            yesil = new Label();
            kırmızı = new Label();
            label7 = new Label();
            mavi = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // basla
            // 
            basla.Location = new Point(134, 178);
            basla.Name = "basla";
            basla.Size = new Size(99, 64);
            basla.TabIndex = 0;
            basla.Text = "Başla/Yeniden Başla";
            basla.UseVisualStyleBackColor = true;
            basla.Click += basla_Click;
            // 
            // dene
            // 
            dene.Location = new Point(597, 178);
            dene.Name = "dene";
            dene.Size = new Size(99, 64);
            dene.TabIndex = 1;
            dene.Text = "Dene";
            dene.UseVisualStyleBackColor = true;
            dene.Click += Dene_Click;
            // 
            // DEBUG
            // 
            DEBUG.Location = new Point(672, 375);
            DEBUG.Name = "DEBUG";
            DEBUG.Size = new Size(105, 51);
            DEBUG.TabIndex = 2;
            DEBUG.Text = "DEBUG";
            DEBUG.UseVisualStyleBackColor = true;
            DEBUG.Click += DEBUG_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Azonix", 19.6981125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(271, 189);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 37);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gabriola", 27.8490562F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(64, 64, 0);
            label1.Location = new Point(153, 22);
            label1.Name = "label1";
            label1.Size = new Size(520, 76);
            label1.TabIndex = 4;
            label1.Text = "4 BASAMAKLI SAYI BİLME OYUNU";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(326, 98);
            label2.Name = "label2";
            label2.Size = new Size(266, 32);
            label2.TabIndex = 5;
            label2.Text = "DENEME HAKKINIZ KALDI";
            // 
            // hak
            // 
            hak.AutoSize = true;
            hak.Font = new Font("Impact", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            hak.Location = new Point(263, 98);
            hak.Name = "hak";
            hak.Size = new Size(39, 32);
            hak.TabIndex = 6;
            hak.Text = "10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(298, 273);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 7;
            label4.Text = "yeşil ışık";
            // 
            // yesil
            // 
            yesil.AutoSize = true;
            yesil.ForeColor = Color.Lime;
            yesil.Location = new Point(287, 273);
            yesil.Name = "yesil";
            yesil.Size = new Size(15, 17);
            yesil.TabIndex = 8;
            yesil.Text = "0";
            yesil.Click += yesil_Click;
            // 
            // kırmızı
            // 
            kırmızı.AutoSize = true;
            kırmızı.ForeColor = Color.Red;
            kırmızı.Location = new Point(484, 273);
            kırmızı.Name = "kırmızı";
            kırmızı.Size = new Size(15, 17);
            kırmızı.TabIndex = 9;
            kırmızı.Text = "0";
            kırmızı.Click += kırmızı_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(495, 273);
            label7.Name = "label7";
            label7.Size = new Size(67, 17);
            label7.TabIndex = 10;
            label7.Text = "kırmızı ışık";
            // 
            // mavi
            // 
            mavi.AutoSize = true;
            mavi.ForeColor = Color.Blue;
            mavi.Location = new Point(389, 325);
            mavi.Name = "mavi";
            mavi.Size = new Size(15, 17);
            mavi.TabIndex = 11;
            mavi.Text = "0";
            mavi.Click += mavi_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(401, 325);
            label9.Name = "label9";
            label9.Size = new Size(57, 17);
            label9.TabIndex = 12;
            label9.Text = "mavi ışık";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(mavi);
            Controls.Add(label7);
            Controls.Add(kırmızı);
            Controls.Add(yesil);
            Controls.Add(label4);
            Controls.Add(hak);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(DEBUG);
            Controls.Add(dene);
            Controls.Add(basla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button basla;
        private Button dene;
        private Button DEBUG;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label hak;
        private Label label4;
        private Label yesil;
        private Label kırmızı;
        private Label label7;
        private Label mavi;
        private Label label9;
    }
}
