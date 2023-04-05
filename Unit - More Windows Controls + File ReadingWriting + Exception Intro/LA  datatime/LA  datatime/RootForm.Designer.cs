namespace LADateTimePicker
{
    partial class RootForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.bttnIsBirthday = new System.Windows.Forms.Button();
            this.labelBday = new System.Windows.Forms.Label();
            this.labelClassDay = new System.Windows.Forms.Label();
            this.mTBoxSSN = new System.Windows.Forms.MaskedTextBox();
            this.tBoxSSN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSSNCheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxSSNReg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(254, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(404, 31);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(254, 234);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // bttnIsBirthday
            // 
            this.bttnIsBirthday.Location = new System.Drawing.Point(254, 577);
            this.bttnIsBirthday.Name = "bttnIsBirthday";
            this.bttnIsBirthday.Size = new System.Drawing.Size(227, 55);
            this.bttnIsBirthday.TabIndex = 2;
            this.bttnIsBirthday.Text = "Is my Birthday?";
            this.bttnIsBirthday.UseVisualStyleBackColor = true;
            this.bttnIsBirthday.Click += new System.EventHandler(this.bttnIsBirthday_Click);
            // 
            // labelBday
            // 
            this.labelBday.AutoSize = true;
            this.labelBday.Location = new System.Drawing.Point(254, 55);
            this.labelBday.Name = "labelBday";
            this.labelBday.Size = new System.Drawing.Size(126, 25);
            this.labelBday.TabIndex = 3;
            this.labelBday.Text = "My Birthday";
            // 
            // labelClassDay
            // 
            this.labelClassDay.AutoSize = true;
            this.labelClassDay.Location = new System.Drawing.Point(254, 179);
            this.labelClassDay.Name = "labelClassDay";
            this.labelClassDay.Size = new System.Drawing.Size(172, 25);
            this.labelClassDay.TabIndex = 4;
            this.labelClassDay.Text = "CS3550 Classes";
            // 
            // mTBoxSSN
            // 
            this.mTBoxSSN.Location = new System.Drawing.Point(45, 727);
            this.mTBoxSSN.Mask = "000-00-0000";
            this.mTBoxSSN.Name = "mTBoxSSN";
            this.mTBoxSSN.Size = new System.Drawing.Size(167, 31);
            this.mTBoxSSN.TabIndex = 5;
            // 
            // tBoxSSN
            // 
            this.tBoxSSN.Location = new System.Drawing.Point(292, 727);
            this.tBoxSSN.Name = "tBoxSSN";
            this.tBoxSSN.Size = new System.Drawing.Size(232, 31);
            this.tBoxSSN.TabIndex = 6;
            this.tBoxSSN.TextChanged += new System.EventHandler(this.tBoxSSN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 666);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "SSN Masked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 666);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "SSN Controlled Input";
            // 
            // btnSSNCheck
            // 
            this.btnSSNCheck.Location = new System.Drawing.Point(587, 791);
            this.btnSSNCheck.Name = "btnSSNCheck";
            this.btnSSNCheck.Size = new System.Drawing.Size(112, 50);
            this.btnSSNCheck.TabIndex = 9;
            this.btnSSNCheck.Text = "button1";
            this.btnSSNCheck.UseVisualStyleBackColor = true;
            this.btnSSNCheck.Click += new System.EventHandler(this.btnSSNCheck_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 666);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "SSN Regex (123-45-6789)";
            // 
            // tBoxSSNReg
            // 
            this.tBoxSSNReg.Location = new System.Drawing.Point(587, 727);
            this.tBoxSSNReg.Name = "tBoxSSNReg";
            this.tBoxSSNReg.Size = new System.Drawing.Size(232, 31);
            this.tBoxSSNReg.TabIndex = 10;
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 921);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxSSNReg);
            this.Controls.Add(this.btnSSNCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxSSN);
            this.Controls.Add(this.mTBoxSSN);
            this.Controls.Add(this.labelClassDay);
            this.Controls.Add(this.labelBday);
            this.Controls.Add(this.bttnIsBirthday);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "RootForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button bttnIsBirthday;
        private System.Windows.Forms.Label labelBday;
        private System.Windows.Forms.Label labelClassDay;
        private System.Windows.Forms.MaskedTextBox mTBoxSSN;
        private System.Windows.Forms.TextBox tBoxSSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSSNCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxSSNReg;
    }
}

