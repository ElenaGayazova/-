namespace WinRSA
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLog1 = new System.Windows.Forms.TextBox();
            this.btSend1 = new System.Windows.Forms.Button();
            this.tbMessage1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLog2 = new System.Windows.Forms.TextBox();
            this.btSend2 = new System.Windows.Forms.Button();
            this.tbMessage2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLog1);
            this.groupBox1.Controls.Add(this.btSend1);
            this.groupBox1.Controls.Add(this.tbMessage1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Окно 1";
            // 
            // tbLog1
            // 
            this.tbLog1.Location = new System.Drawing.Point(7, 45);
            this.tbLog1.Multiline = true;
            this.tbLog1.Name = "tbLog1";
            this.tbLog1.Size = new System.Drawing.Size(337, 375);
            this.tbLog1.TabIndex = 2;
            // 
            // btSend1
            // 
            this.btSend1.Location = new System.Drawing.Point(113, 17);
            this.btSend1.Name = "btSend1";
            this.btSend1.Size = new System.Drawing.Size(75, 23);
            this.btSend1.TabIndex = 1;
            this.btSend1.Text = "Отправить";
            this.btSend1.UseVisualStyleBackColor = true;
            this.btSend1.Click += new System.EventHandler(this.btSend1_Click);
            // 
            // tbMessage1
            // 
            this.tbMessage1.Location = new System.Drawing.Point(6, 19);
            this.tbMessage1.Name = "tbMessage1";
            this.tbMessage1.Size = new System.Drawing.Size(100, 20);
            this.tbMessage1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbLog2);
            this.groupBox2.Controls.Add(this.btSend2);
            this.groupBox2.Controls.Add(this.tbMessage2);
            this.groupBox2.Location = new System.Drawing.Point(368, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 426);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Окно 1";
            // 
            // tbLog2
            // 
            this.tbLog2.Location = new System.Drawing.Point(7, 45);
            this.tbLog2.Multiline = true;
            this.tbLog2.Name = "tbLog2";
            this.tbLog2.Size = new System.Drawing.Size(337, 375);
            this.tbLog2.TabIndex = 2;
            // 
            // btSend2
            // 
            this.btSend2.Location = new System.Drawing.Point(113, 17);
            this.btSend2.Name = "btSend2";
            this.btSend2.Size = new System.Drawing.Size(75, 23);
            this.btSend2.TabIndex = 1;
            this.btSend2.Text = "Отправить";
            this.btSend2.UseVisualStyleBackColor = true;
            this.btSend2.Click += new System.EventHandler(this.btSend1_Click);
            // 
            // tbMessage2
            // 
            this.tbMessage2.Location = new System.Drawing.Point(6, 19);
            this.tbMessage2.Name = "tbMessage2";
            this.tbMessage2.Size = new System.Drawing.Size(100, 20);
            this.tbMessage2.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "Шифрование сообщение с RSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLog1;
        private System.Windows.Forms.Button btSend1;
        private System.Windows.Forms.TextBox tbMessage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbLog2;
        private System.Windows.Forms.Button btSend2;
        private System.Windows.Forms.TextBox tbMessage2;
    }
}

