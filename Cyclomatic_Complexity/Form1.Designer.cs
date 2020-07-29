namespace Cyclomatic_Complexity
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
            this.labelPaste = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonAnalyse = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelRisk = new System.Windows.Forms.Label();
            this.buttonRisk = new System.Windows.Forms.Button();
            this.labelSignBoard = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPaste
            // 
            this.labelPaste.AutoSize = true;
            this.labelPaste.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelPaste.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaste.ForeColor = System.Drawing.SystemColors.Info;
            this.labelPaste.Location = new System.Drawing.Point(12, 89);
            this.labelPaste.Name = "labelPaste";
            this.labelPaste.Size = new System.Drawing.Size(182, 23);
            this.labelPaste.TabIndex = 0;
            this.labelPaste.Text = "Paste your code :";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(16, 124);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(574, 285);
            this.textBoxCode.TabIndex = 1;
            // 
            // buttonAnalyse
            // 
            this.buttonAnalyse.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAnalyse.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalyse.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonAnalyse.Location = new System.Drawing.Point(629, 230);
            this.buttonAnalyse.Name = "buttonAnalyse";
            this.buttonAnalyse.Size = new System.Drawing.Size(113, 40);
            this.buttonAnalyse.TabIndex = 2;
            this.buttonAnalyse.Text = "Analyse";
            this.buttonAnalyse.UseVisualStyleBackColor = false;
            this.buttonAnalyse.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelResult.Location = new System.Drawing.Point(631, 273);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 22);
            this.labelResult.TabIndex = 3;
            // 
            // labelRisk
            // 
            this.labelRisk.AutoSize = true;
            this.labelRisk.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRisk.Location = new System.Drawing.Point(631, 363);
            this.labelRisk.Name = "labelRisk";
            this.labelRisk.Size = new System.Drawing.Size(0, 22);
            this.labelRisk.TabIndex = 4;
            // 
            // buttonRisk
            // 
            this.buttonRisk.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRisk.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRisk.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonRisk.Location = new System.Drawing.Point(629, 320);
            this.buttonRisk.Name = "buttonRisk";
            this.buttonRisk.Size = new System.Drawing.Size(143, 40);
            this.buttonRisk.TabIndex = 5;
            this.buttonRisk.Text = "Risk Level";
            this.buttonRisk.UseVisualStyleBackColor = false;
            this.buttonRisk.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelSignBoard
            // 
            this.labelSignBoard.AutoSize = true;
            this.labelSignBoard.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelSignBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSignBoard.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignBoard.ForeColor = System.Drawing.SystemColors.Info;
            this.labelSignBoard.Location = new System.Drawing.Point(12, 19);
            this.labelSignBoard.Name = "labelSignBoard";
            this.labelSignBoard.Size = new System.Drawing.Size(692, 39);
            this.labelSignBoard.TabIndex = 6;
            this.labelSignBoard.Text = "Cyclomatic Complexity Calculator for Python:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cyclomatic_Complexity.Properties.Resources.T148;
            this.pictureBox1.Location = new System.Drawing.Point(825, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSignBoard);
            this.Controls.Add(this.buttonRisk);
            this.Controls.Add(this.labelRisk);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonAnalyse);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelPaste);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPaste;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonAnalyse;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelRisk;
        private System.Windows.Forms.Button buttonRisk;
        private System.Windows.Forms.Label labelSignBoard;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

