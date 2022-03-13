namespace Tugas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.bttn_proses = new System.Windows.Forms.Button();
            this.label_empty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Data :";
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(12, 61);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(465, 31);
            this.txtBox1.TabIndex = 1;
            // 
            // bttn_proses
            // 
            this.bttn_proses.Location = new System.Drawing.Point(12, 115);
            this.bttn_proses.Name = "bttn_proses";
            this.bttn_proses.Size = new System.Drawing.Size(112, 34);
            this.bttn_proses.TabIndex = 2;
            this.bttn_proses.Text = "Proses";
            this.bttn_proses.UseVisualStyleBackColor = true;
            this.bttn_proses.Click += new System.EventHandler(this.bttn_proses_Click);
            // 
            // label_empty
            // 
            this.label_empty.AutoSize = true;
            this.label_empty.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_empty.ForeColor = System.Drawing.Color.Black;
            this.label_empty.Location = new System.Drawing.Point(12, 175);
            this.label_empty.Name = "label_empty";
            this.label_empty.Size = new System.Drawing.Size(145, 46);
            this.label_empty.TabIndex = 3;
            this.label_empty.Text = "[EMPTY]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 279);
            this.Controls.Add(this.label_empty);
            this.Controls.Add(this.bttn_proses);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBox1;
        private Button bttn_proses;
        private Label label_empty;
    }
}