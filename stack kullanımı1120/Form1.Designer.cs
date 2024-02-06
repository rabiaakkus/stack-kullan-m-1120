namespace stack_kullanımı1120
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
            this.lblSira1 = new System.Windows.Forms.Label();
            this.lblSira2 = new System.Windows.Forms.Label();
            this.lblSira3 = new System.Windows.Forms.Label();
            this.btnGetir1 = new System.Windows.Forms.Button();
            this.btnGetir2 = new System.Windows.Forms.Button();
            this.btnGetir3 = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSira1
            // 
            this.lblSira1.AutoSize = true;
            this.lblSira1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSira1.Location = new System.Drawing.Point(71, 72);
            this.lblSira1.Name = "lblSira1";
            this.lblSira1.Size = new System.Drawing.Size(51, 20);
            this.lblSira1.TabIndex = 0;
            this.lblSira1.Text = "label1";
            // 
            // lblSira2
            // 
            this.lblSira2.AutoSize = true;
            this.lblSira2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSira2.Location = new System.Drawing.Point(150, 72);
            this.lblSira2.Name = "lblSira2";
            this.lblSira2.Size = new System.Drawing.Size(51, 20);
            this.lblSira2.TabIndex = 1;
            this.lblSira2.Text = "label2";
            // 
            // lblSira3
            // 
            this.lblSira3.AutoSize = true;
            this.lblSira3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSira3.Location = new System.Drawing.Point(228, 72);
            this.lblSira3.Name = "lblSira3";
            this.lblSira3.Size = new System.Drawing.Size(51, 20);
            this.lblSira3.TabIndex = 2;
            this.lblSira3.Text = "label3";
            // 
            // btnGetir1
            // 
            this.btnGetir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir1.Location = new System.Drawing.Point(30, 202);
            this.btnGetir1.Name = "btnGetir1";
            this.btnGetir1.Size = new System.Drawing.Size(75, 37);
            this.btnGetir1.TabIndex = 3;
            this.btnGetir1.Text = "Gişe 1";
            this.btnGetir1.UseVisualStyleBackColor = true;
            this.btnGetir1.Click += new System.EventHandler(this.btnGetir1_Click);
            // 
            // btnGetir2
            // 
            this.btnGetir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir2.Location = new System.Drawing.Point(140, 202);
            this.btnGetir2.Name = "btnGetir2";
            this.btnGetir2.Size = new System.Drawing.Size(75, 37);
            this.btnGetir2.TabIndex = 4;
            this.btnGetir2.Text = "Gişe 2";
            this.btnGetir2.UseVisualStyleBackColor = true;
            this.btnGetir2.Click += new System.EventHandler(this.btnGetir2_Click);
            // 
            // btnGetir3
            // 
            this.btnGetir3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir3.Location = new System.Drawing.Point(246, 202);
            this.btnGetir3.Name = "btnGetir3";
            this.btnGetir3.Size = new System.Drawing.Size(75, 37);
            this.btnGetir3.TabIndex = 5;
            this.btnGetir3.Text = "Gişe 3";
            this.btnGetir3.UseVisualStyleBackColor = true;
            this.btnGetir3.Click += new System.EventHandler(this.btnGetir3_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(30, 287);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(273, 56);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Sıra Al";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(30, 123);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(291, 26);
            this.txtAd.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(433, 415);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGetir3);
            this.Controls.Add(this.btnGetir2);
            this.Controls.Add(this.btnGetir1);
            this.Controls.Add(this.lblSira3);
            this.Controls.Add(this.lblSira2);
            this.Controls.Add(this.lblSira1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSira1;
        private System.Windows.Forms.Label lblSira2;
        private System.Windows.Forms.Label lblSira3;
        private System.Windows.Forms.Button btnGetir1;
        private System.Windows.Forms.Button btnGetir2;
        private System.Windows.Forms.Button btnGetir3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAd;
    }
}

