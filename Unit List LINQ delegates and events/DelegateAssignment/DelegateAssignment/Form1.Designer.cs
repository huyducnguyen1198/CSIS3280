namespace DelegateAssignment
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
            this.Lbl1 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.sqrt = new System.Windows.Forms.RadioButton();
            this.sqr = new System.Windows.Forms.RadioButton();
            this.cube = new System.Windows.Forms.RadioButton();
            this.compute = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Label();
            this.rm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(118, 66);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(206, 25);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Enter Positive Value";
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(123, 132);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(134, 31);
            this.txtBox1.TabIndex = 1;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // sqrt
            // 
            this.sqrt.AutoSize = true;
            this.sqrt.Location = new System.Drawing.Point(374, 66);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(157, 29);
            this.sqrt.TabIndex = 2;
            this.sqrt.TabStop = true;
            this.sqrt.Text = "SquareRoot";
            this.sqrt.UseVisualStyleBackColor = true;
            // 
            // sqr
            // 
            this.sqr.AutoSize = true;
            this.sqr.Location = new System.Drawing.Point(374, 134);
            this.sqr.Name = "sqr";
            this.sqr.Size = new System.Drawing.Size(112, 29);
            this.sqr.TabIndex = 3;
            this.sqr.TabStop = true;
            this.sqr.Text = "Square";
            this.sqr.UseVisualStyleBackColor = true;
            // 
            // cube
            // 
            this.cube.AutoSize = true;
            this.cube.Location = new System.Drawing.Point(374, 208);
            this.cube.Name = "cube";
            this.cube.Size = new System.Drawing.Size(94, 29);
            this.cube.TabIndex = 4;
            this.cube.TabStop = true;
            this.cube.Text = "Cube";
            this.cube.UseVisualStyleBackColor = true;
            // 
            // compute
            // 
            this.compute.Location = new System.Drawing.Point(374, 275);
            this.compute.Name = "compute";
            this.compute.Size = new System.Drawing.Size(136, 56);
            this.compute.TabIndex = 5;
            this.compute.Text = "Compute";
            this.compute.UseVisualStyleBackColor = true;
            this.compute.Click += new System.EventHandler(this.compute_Click);
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Location = new System.Drawing.Point(118, 208);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(24, 25);
            this.ans.TabIndex = 6;
            this.ans.Text = "";
            // 
            // rm
            // 
            this.rm.Location = new System.Drawing.Point(263, 132);
            this.rm.Name = "rm";
            this.rm.Size = new System.Drawing.Size(45, 43);
            this.rm.TabIndex = 7;
            this.rm.Text = "<";
            this.rm.UseVisualStyleBackColor = true;
            this.rm.Click += new System.EventHandler(this.rm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rm);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.compute);
            this.Controls.Add(this.cube);
            this.Controls.Add(this.sqr);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.Lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.RadioButton sqrt;
        private System.Windows.Forms.RadioButton sqr;
        private System.Windows.Forms.RadioButton cube;
        private System.Windows.Forms.Button compute;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.Button rm;
    }
}

