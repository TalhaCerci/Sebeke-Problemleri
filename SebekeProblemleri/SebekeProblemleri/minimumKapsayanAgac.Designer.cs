namespace SebekeProblemleri
{
    partial class minimumKapsayanAgac
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_nereden = new System.Windows.Forms.NumericUpDown();
            this.txt_nereye = new System.Windows.Forms.NumericUpDown();
            this.txt_mesafe = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.lblEnKisaMesafe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nereden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nereye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mesafe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nereden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nereye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mesafe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Yolu Çiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(9, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 478);
            this.panel1.TabIndex = 7;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick_1);
            // 
            // txt_nereden
            // 
            this.txt_nereden.Location = new System.Drawing.Point(9, 22);
            this.txt_nereden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nereden.Name = "txt_nereden";
            this.txt_nereden.Size = new System.Drawing.Size(90, 20);
            this.txt_nereden.TabIndex = 8;
            // 
            // txt_nereye
            // 
            this.txt_nereye.Location = new System.Drawing.Point(104, 22);
            this.txt_nereye.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nereye.Name = "txt_nereye";
            this.txt_nereye.Size = new System.Drawing.Size(90, 20);
            this.txt_nereye.TabIndex = 9;
            // 
            // txt_mesafe
            // 
            this.txt_mesafe.Location = new System.Drawing.Point(210, 22);
            this.txt_mesafe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_mesafe.Name = "txt_mesafe";
            this.txt_mesafe.Size = new System.Drawing.Size(90, 20);
            this.txt_mesafe.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(760, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblEnKisaMesafe
            // 
            this.lblEnKisaMesafe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnKisaMesafe.AutoSize = true;
            this.lblEnKisaMesafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnKisaMesafe.Location = new System.Drawing.Point(412, 18);
            this.lblEnKisaMesafe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnKisaMesafe.Name = "lblEnKisaMesafe";
            this.lblEnKisaMesafe.Size = new System.Drawing.Size(200, 26);
            this.lblEnKisaMesafe.TabIndex = 12;
            this.lblEnKisaMesafe.Text = "En Kısa Mesafe : ";
            // 
            // minimumKapsayanAgac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(866, 534);
            this.Controls.Add(this.lblEnKisaMesafe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_mesafe);
            this.Controls.Add(this.txt_nereye);
            this.Controls.Add(this.txt_nereden);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "minimumKapsayanAgac";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.minimumKapsayanAgac_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.txt_nereden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nereye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mesafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txt_nereden;
        private System.Windows.Forms.NumericUpDown txt_nereye;
        private System.Windows.Forms.NumericUpDown txt_mesafe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEnKisaMesafe;


    }
}
