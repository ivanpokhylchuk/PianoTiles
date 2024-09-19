namespace PianoTiles
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.colissionLine1 = new System.Windows.Forms.PictureBox();
            this.key1 = new System.Windows.Forms.Label();
            this.key2 = new System.Windows.Forms.Label();
            this.key3 = new System.Windows.Forms.Label();
            this.key4 = new System.Windows.Forms.Label();
            this.tmrGrav = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colissionLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(160, -12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 832);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(320, -11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 817);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(480, -11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 828);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // colissionLine1
            // 
            this.colissionLine1.BackColor = System.Drawing.Color.Black;
            this.colissionLine1.Location = new System.Drawing.Point(-17, 671);
            this.colissionLine1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.colissionLine1.Name = "colissionLine1";
            this.colissionLine1.Size = new System.Drawing.Size(673, 10);
            this.colissionLine1.TabIndex = 3;
            this.colissionLine1.TabStop = false;
            // 
            // key1
            // 
            this.key1.BackColor = System.Drawing.Color.Transparent;
            this.key1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key1.Location = new System.Drawing.Point(-17, 680);
            this.key1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(187, 126);
            this.key1.TabIndex = 4;
            this.key1.Text = "Q";
            this.key1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // key2
            // 
            this.key2.BackColor = System.Drawing.Color.Transparent;
            this.key2.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key2.Location = new System.Drawing.Point(160, 680);
            this.key2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(168, 127);
            this.key2.TabIndex = 5;
            this.key2.Text = "W";
            this.key2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // key3
            // 
            this.key3.BackColor = System.Drawing.Color.Transparent;
            this.key3.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key3.Location = new System.Drawing.Point(317, 680);
            this.key3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.key3.Name = "key3";
            this.key3.Size = new System.Drawing.Size(173, 125);
            this.key3.TabIndex = 6;
            this.key3.Text = "E";
            this.key3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // key4
            // 
            this.key4.BackColor = System.Drawing.Color.Transparent;
            this.key4.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key4.Location = new System.Drawing.Point(484, 680);
            this.key4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.key4.Name = "key4";
            this.key4.Size = new System.Drawing.Size(155, 125);
            this.key4.TabIndex = 7;
            this.key4.Text = "R";
            this.key4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrGrav
            // 
            this.tmrGrav.Enabled = true;
            this.tmrGrav.Interval = 10;
            this.tmrGrav.Tick += new System.EventHandler(this.tmrGrav_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 778);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PianoTiles.Properties.Resources.delete_icon;
            this.pictureBox4.Location = new System.Drawing.Point(578, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(61, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(640, 800);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.key4);
            this.Controls.Add(this.key3);
            this.Controls.Add(this.key2);
            this.Controls.Add(this.key1);
            this.Controls.Add(this.colissionLine1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colissionLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox colissionLine1;
        private System.Windows.Forms.Label key1;
        private System.Windows.Forms.Label key2;
        private System.Windows.Forms.Label key3;
        private System.Windows.Forms.Label key4;
        private System.Windows.Forms.Timer tmrGrav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

