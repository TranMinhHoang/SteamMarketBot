namespace SteamBot
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGetPage = new System.Windows.Forms.Button();
            this.txtLowestPrice = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(13, 13);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(434, 20);
            this.txtURL.TabIndex = 0;
            // 
            // btnGetPage
            // 
            this.btnGetPage.Location = new System.Drawing.Point(454, 9);
            this.btnGetPage.Name = "btnGetPage";
            this.btnGetPage.Size = new System.Drawing.Size(81, 23);
            this.btnGetPage.TabIndex = 1;
            this.btnGetPage.Text = "Get Page";
            this.btnGetPage.UseVisualStyleBackColor = true;
            this.btnGetPage.Click += new System.EventHandler(this.btnGetPage_Click);
            // 
            // txtLowestPrice
            // 
            this.txtLowestPrice.Location = new System.Drawing.Point(13, 39);
            this.txtLowestPrice.Name = "txtLowestPrice";
            this.txtLowestPrice.Size = new System.Drawing.Size(100, 20);
            this.txtLowestPrice.TabIndex = 3;
            this.txtLowestPrice.Text = "LowestPrice";
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(12, 65);
            this.txtPage.Multiline = true;
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(522, 378);
            this.txtPage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 473);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.txtLowestPrice);
            this.Controls.Add(this.btnGetPage);
            this.Controls.Add(this.txtURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnGetPage;
        private System.Windows.Forms.TextBox txtLowestPrice;
        private System.Windows.Forms.TextBox txtPage;       
    }
}

