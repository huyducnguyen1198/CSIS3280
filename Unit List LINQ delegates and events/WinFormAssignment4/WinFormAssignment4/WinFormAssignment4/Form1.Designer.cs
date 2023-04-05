namespace WinFormAssignment4
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
            this.chkTest = new System.Windows.Forms.CheckBox();
            this.lblCheckOrUnchecked = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkTest
            // 
            this.chkTest.AutoSize = true;
            this.chkTest.Location = new System.Drawing.Point(416, 194);
            this.chkTest.Margin = new System.Windows.Forms.Padding(6);
            this.chkTest.Name = "chkTest";
            this.chkTest.Size = new System.Drawing.Size(196, 29);
            this.chkTest.TabIndex = 0;
            this.chkTest.Text = "Test Check Box";
            this.chkTest.UseVisualStyleBackColor = true;
            // 
            // lblCheckOrUnchecked
            // 
            this.lblCheckOrUnchecked.AutoSize = true;
            this.lblCheckOrUnchecked.Location = new System.Drawing.Point(416, 269);
            this.lblCheckOrUnchecked.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCheckOrUnchecked.Name = "lblCheckOrUnchecked";
            this.lblCheckOrUnchecked.Size = new System.Drawing.Size(221, 25);
            this.lblCheckOrUnchecked.TabIndex = 1;
            this.lblCheckOrUnchecked.Text = "Unchecked Right now";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(416, 329);
            this.btnTest.Margin = new System.Windows.Forms.Padding(6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(150, 44);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Click Me!";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(854, 194);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(150, 29);
            this.chk2.TabIndex = 3;
            this.chk2.Text = "checkBox1";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.chk2);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblCheckOrUnchecked);
            this.Controls.Add(this.chkTest);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkTest;
        private System.Windows.Forms.Label lblCheckOrUnchecked;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.CheckBox chk2;
    }
}

