namespace SimpleCalculator
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
            this.calBtn = new System.Windows.Forms.Button();
            this.inputBox1 = new System.Windows.Forms.TextBox();
            this.inputBox2 = new System.Windows.Forms.TextBox();
            this.plusLbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calBtn
            // 
            this.calBtn.Location = new System.Drawing.Point(450, 91);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(75, 23);
            this.calBtn.TabIndex = 0;
            this.calBtn.Text = "=";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // inputBox1
            // 
            this.inputBox1.Location = new System.Drawing.Point(120, 91);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(100, 20);
            this.inputBox1.TabIndex = 1;
            this.inputBox1.TextChanged += new System.EventHandler(this.inputBox1_TextChanged);
            // 
            // inputBox2
            // 
            this.inputBox2.Location = new System.Drawing.Point(300, 91);
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(100, 20);
            this.inputBox2.TabIndex = 2;
            this.inputBox2.TextChanged += new System.EventHandler(this.inputBox2_TextChanged);
            // 
            // plusLbl
            // 
            this.plusLbl.AutoSize = true;
            this.plusLbl.Location = new System.Drawing.Point(248, 97);
            this.plusLbl.Name = "plusLbl";
            this.plusLbl.Size = new System.Drawing.Size(13, 13);
            this.plusLbl.TabIndex = 3;
            this.plusLbl.Text = "+";
            this.plusLbl.Click += new System.EventHandler(this.plusLbl_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(589, 96);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(24, 13);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text = "ans";
            this.resultLbl.Click += new System.EventHandler(this.resultLbl_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(567, 168);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(60, 33);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.plusLbl);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.calBtn);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.TextBox inputBox1;
        private System.Windows.Forms.TextBox inputBox2;
        private System.Windows.Forms.Label plusLbl;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button clearBtn;
    }
}

