namespace SharingApp
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
            this.btnShareFb = new System.Windows.Forms.Button();
            this.btnShareTwitter = new System.Windows.Forms.Button();
            this.btnShareVK = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnShareLinkedin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShareFb
            // 
            this.btnShareFb.Location = new System.Drawing.Point(33, 64);
            this.btnShareFb.Name = "btnShareFb";
            this.btnShareFb.Size = new System.Drawing.Size(100, 23);
            this.btnShareFb.TabIndex = 0;
            this.btnShareFb.Text = "Share FB";
            this.btnShareFb.UseVisualStyleBackColor = true;
            this.btnShareFb.Click += new System.EventHandler(this.btnShareFb_Click);
            // 
            // btnShareTwitter
            // 
            this.btnShareTwitter.Location = new System.Drawing.Point(150, 64);
            this.btnShareTwitter.Name = "btnShareTwitter";
            this.btnShareTwitter.Size = new System.Drawing.Size(100, 23);
            this.btnShareTwitter.TabIndex = 1;
            this.btnShareTwitter.Text = "Share Twitter";
            this.btnShareTwitter.UseVisualStyleBackColor = true;
            this.btnShareTwitter.Click += new System.EventHandler(this.btnShareTwitter_Click);
            // 
            // btnShareVK
            // 
            this.btnShareVK.Location = new System.Drawing.Point(33, 102);
            this.btnShareVK.Name = "btnShareVK";
            this.btnShareVK.Size = new System.Drawing.Size(100, 23);
            this.btnShareVK.TabIndex = 2;
            this.btnShareVK.Text = "Share VK";
            this.btnShareVK.UseVisualStyleBackColor = true;
            this.btnShareVK.Click += new System.EventHandler(this.btnShareVK_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(67, 27);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(142, 20);
            this.txtText.TabIndex = 3;
            this.txtText.Text = "Text to Share";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(30, 30);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(31, 13);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Text:";
            // 
            // btnShareLinkedin
            // 
            this.btnShareLinkedin.Location = new System.Drawing.Point(150, 102);
            this.btnShareLinkedin.Name = "btnShareLinkedin";
            this.btnShareLinkedin.Size = new System.Drawing.Size(100, 23);
            this.btnShareLinkedin.TabIndex = 5;
            this.btnShareLinkedin.Text = "Share Linkedin";
            this.btnShareLinkedin.UseVisualStyleBackColor = true;
            this.btnShareLinkedin.Click += new System.EventHandler(this.btnShareLinkedin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 226);
            this.Controls.Add(this.btnShareLinkedin);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnShareVK);
            this.Controls.Add(this.btnShareTwitter);
            this.Controls.Add(this.btnShareFb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShareFb;
        private System.Windows.Forms.Button btnShareTwitter;
        private System.Windows.Forms.Button btnShareVK;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnShareLinkedin;
    }
}

