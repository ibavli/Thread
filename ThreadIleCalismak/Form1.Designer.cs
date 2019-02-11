namespace ThreadIleCalismak
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
            this.btnDongu = new System.Windows.Forms.Button();
            this.btnMesaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDongu
            // 
            this.btnDongu.Location = new System.Drawing.Point(27, 13);
            this.btnDongu.Name = "btnDongu";
            this.btnDongu.Size = new System.Drawing.Size(100, 40);
            this.btnDongu.TabIndex = 0;
            this.btnDongu.Text = "Döngü";
            this.btnDongu.UseVisualStyleBackColor = true;
            this.btnDongu.Click += new System.EventHandler(this.btnDongu_Click);
            // 
            // btnMesaj
            // 
            this.btnMesaj.Location = new System.Drawing.Point(27, 69);
            this.btnMesaj.Name = "btnMesaj";
            this.btnMesaj.Size = new System.Drawing.Size(100, 40);
            this.btnMesaj.TabIndex = 1;
            this.btnMesaj.Text = "Mesaj";
            this.btnMesaj.UseVisualStyleBackColor = true;
            this.btnMesaj.Click += new System.EventHandler(this.btnMesaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMesaj);
            this.Controls.Add(this.btnDongu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDongu;
        private System.Windows.Forms.Button btnMesaj;
    }
}

