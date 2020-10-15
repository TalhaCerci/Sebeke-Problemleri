namespace SebekeProblemleri
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMinKap = new System.Windows.Forms.Button();
            this.btnEnKisaYol = new System.Windows.Forms.Button();
            this.btnCPM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMinKap
            // 
            this.btnMinKap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinKap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinKap.Location = new System.Drawing.Point(13, 13);
            this.btnMinKap.Name = "btnMinKap";
            this.btnMinKap.Size = new System.Drawing.Size(200, 100);
            this.btnMinKap.TabIndex = 0;
            this.btnMinKap.Text = "Minimum Kapsayan Ağaç";
            this.btnMinKap.UseVisualStyleBackColor = true;
            this.btnMinKap.Click += new System.EventHandler(this.btnMinKap_Click);
            // 
            // btnEnKisaYol
            // 
            this.btnEnKisaYol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnKisaYol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnKisaYol.Location = new System.Drawing.Point(13, 133);
            this.btnEnKisaYol.Name = "btnEnKisaYol";
            this.btnEnKisaYol.Size = new System.Drawing.Size(200, 100);
            this.btnEnKisaYol.TabIndex = 1;
            this.btnEnKisaYol.Text = "En Kısa Yol";
            this.btnEnKisaYol.UseVisualStyleBackColor = true;
            this.btnEnKisaYol.Click += new System.EventHandler(this.btnEnKisaYol_Click);
            // 
            // btnCPM
            // 
            this.btnCPM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCPM.Location = new System.Drawing.Point(12, 250);
            this.btnCPM.Name = "btnCPM";
            this.btnCPM.Size = new System.Drawing.Size(200, 100);
            this.btnCPM.TabIndex = 2;
            this.btnCPM.Text = "CPM";
            this.btnCPM.UseVisualStyleBackColor = true;
            this.btnCPM.Click += new System.EventHandler(this.btnCPM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 362);
            this.Controls.Add(this.btnCPM);
            this.Controls.Add(this.btnEnKisaYol);
            this.Controls.Add(this.btnMinKap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMinKap;
        private System.Windows.Forms.Button btnEnKisaYol;
        private System.Windows.Forms.Button btnCPM;
    }
}

