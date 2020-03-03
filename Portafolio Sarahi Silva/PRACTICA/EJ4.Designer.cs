namespace PRACTICA
{
    partial class EJ4
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
            this.lblmayor = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum3 = new System.Windows.Forms.TextBox();
            this.btnmayor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero 3";
            // 
            // lblmayor
            // 
            this.lblmayor.AutoSize = true;
            this.lblmayor.Location = new System.Drawing.Point(41, 127);
            this.lblmayor.Name = "lblmayor";
            this.lblmayor.Size = new System.Drawing.Size(36, 13);
            this.lblmayor.TabIndex = 3;
            this.lblmayor.Text = "Mayor";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(81, 13);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 5;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(81, 45);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 6;
            // 
            // txtnum3
            // 
            this.txtnum3.Location = new System.Drawing.Point(81, 74);
            this.txtnum3.Name = "txtnum3";
            this.txtnum3.Size = new System.Drawing.Size(100, 20);
            this.txtnum3.TabIndex = 7;
            // 
            // btnmayor
            // 
            this.btnmayor.Location = new System.Drawing.Point(106, 100);
            this.btnmayor.Name = "btnmayor";
            this.btnmayor.Size = new System.Drawing.Size(75, 23);
            this.btnmayor.TabIndex = 8;
            this.btnmayor.Text = "Mayor";
            this.btnmayor.UseVisualStyleBackColor = true;
            this.btnmayor.Click += new System.EventHandler(this.btnmayor_Click);
            // 
            // EJ4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 175);
            this.Controls.Add(this.btnmayor);
            this.Controls.Add(this.txtnum3);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblmayor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EJ4";
            this.Text = "EJ4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmayor;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum3;
        private System.Windows.Forms.Button btnmayor;
    }
}