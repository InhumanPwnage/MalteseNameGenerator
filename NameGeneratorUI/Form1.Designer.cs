namespace NameGeneratorUI
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
            this.ofdPrefix = new System.Windows.Forms.OpenFileDialog();
            this.btnPrefix = new System.Windows.Forms.Button();
            this.btnSuffix = new System.Windows.Forms.Button();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.ofdSuffix = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ofdPrefix
            // 
            this.ofdPrefix.FileName = "maltese_first_male.txt";
            // 
            // btnPrefix
            // 
            this.btnPrefix.Location = new System.Drawing.Point(12, 12);
            this.btnPrefix.Name = "btnPrefix";
            this.btnPrefix.Size = new System.Drawing.Size(75, 23);
            this.btnPrefix.TabIndex = 0;
            this.btnPrefix.Text = "Prefix";
            this.btnPrefix.UseVisualStyleBackColor = true;
            this.btnPrefix.Click += new System.EventHandler(this.btnPrefix_Click);
            // 
            // btnSuffix
            // 
            this.btnSuffix.Location = new System.Drawing.Point(12, 41);
            this.btnSuffix.Name = "btnSuffix";
            this.btnSuffix.Size = new System.Drawing.Size(75, 23);
            this.btnSuffix.TabIndex = 1;
            this.btnSuffix.Text = "Suffix";
            this.btnSuffix.UseVisualStyleBackColor = true;
            this.btnSuffix.Click += new System.EventHandler(this.btnSuffix_Click);
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(93, 17);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(0, 13);
            this.lblPrefix.TabIndex = 2;
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(93, 46);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(0, 13);
            this.lblSuffix.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 70);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(169, 20);
            this.txtResult.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(187, 70);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // ofdSuffix
            // 
            this.ofdSuffix.FileName = "maltese_surnames.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 112);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblSuffix);
            this.Controls.Add(this.lblPrefix);
            this.Controls.Add(this.btnSuffix);
            this.Controls.Add(this.btnPrefix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Name Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdPrefix;
        private System.Windows.Forms.Button btnPrefix;
        private System.Windows.Forms.Button btnSuffix;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.OpenFileDialog ofdSuffix;
    }
}

