﻿namespace CS3280WinEmployee
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.chkMarried = new System.Windows.Forms.CheckBox();
            this.radioSalaried = new System.Windows.Forms.RadioButton();
            this.radioCommision = new System.Windows.Forms.RadioButton();
            this.radioBaseComission = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtComission = new System.Windows.Forms.TextBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtEmployeeInfo = new System.Windows.Forms.TextBox();
            this.deptCBox = new System.Windows.Forms.ComboBox();
            this.dGridEmp = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(453, 109);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(265, 31);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(247, 116);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(116, 25);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(247, 178);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(115, 25);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(453, 170);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(265, 31);
            this.txtLastname.TabIndex = 2;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(247, 236);
            this.lblSSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(55, 25);
            this.lblSSN.TabIndex = 5;
            this.lblSSN.Text = "SSN";
            this.lblSSN.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(453, 229);
            this.txtSSN.Margin = new System.Windows.Forms.Padding(4);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(265, 31);
            this.txtSSN.TabIndex = 4;
            this.txtSSN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(247, 298);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(156, 25);
            this.lblAddress1.TabIndex = 7;
            this.lblAddress1.Text = "Address Line 1";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(453, 290);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(265, 31);
            this.txtAddress1.TabIndex = 6;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(247, 359);
            this.lblAddress2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(156, 25);
            this.lblAddress2.TabIndex = 9;
            this.lblAddress2.Text = "Address Line 2";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(453, 351);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(265, 31);
            this.txtAddress2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 426);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "State";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "UT",
            "CA",
            "NV",
            "OR",
            "WA",
            "CO",
            "NY"});
            this.cmbState.Location = new System.Drawing.Point(453, 415);
            this.cmbState.Margin = new System.Windows.Forms.Padding(4);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(160, 33);
            this.cmbState.TabIndex = 11;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // chkMarried
            // 
            this.chkMarried.AutoSize = true;
            this.chkMarried.Location = new System.Drawing.Point(252, 500);
            this.chkMarried.Margin = new System.Windows.Forms.Padding(4);
            this.chkMarried.Name = "chkMarried";
            this.chkMarried.Size = new System.Drawing.Size(273, 29);
            this.chkMarried.TabIndex = 12;
            this.chkMarried.Text = "Is Married (For taxation)";
            this.chkMarried.UseVisualStyleBackColor = true;
            this.chkMarried.CheckedChanged += new System.EventHandler(this.chkMarried_CheckedChanged);
            // 
            // radioSalaried
            // 
            this.radioSalaried.AutoSize = true;
            this.radioSalaried.Location = new System.Drawing.Point(33, 56);
            this.radioSalaried.Margin = new System.Windows.Forms.Padding(4);
            this.radioSalaried.Name = "radioSalaried";
            this.radioSalaried.Size = new System.Drawing.Size(122, 29);
            this.radioSalaried.TabIndex = 13;
            this.radioSalaried.TabStop = true;
            this.radioSalaried.Text = "Salaried";
            this.radioSalaried.UseVisualStyleBackColor = true;
            this.radioSalaried.CheckedChanged += new System.EventHandler(this.radioSalaried_CheckedChanged);
            // 
            // radioCommision
            // 
            this.radioCommision.AutoSize = true;
            this.radioCommision.Location = new System.Drawing.Point(219, 56);
            this.radioCommision.Margin = new System.Windows.Forms.Padding(4);
            this.radioCommision.Name = "radioCommision";
            this.radioCommision.Size = new System.Drawing.Size(160, 29);
            this.radioCommision.TabIndex = 14;
            this.radioCommision.TabStop = true;
            this.radioCommision.Text = "Commission";
            this.radioCommision.UseVisualStyleBackColor = true;
            this.radioCommision.CheckedChanged += new System.EventHandler(this.radioCommision_CheckedChanged);
            // 
            // radioBaseComission
            // 
            this.radioBaseComission.AutoSize = true;
            this.radioBaseComission.Location = new System.Drawing.Point(432, 56);
            this.radioBaseComission.Margin = new System.Windows.Forms.Padding(4);
            this.radioBaseComission.Name = "radioBaseComission";
            this.radioBaseComission.Size = new System.Drawing.Size(204, 29);
            this.radioBaseComission.TabIndex = 15;
            this.radioBaseComission.TabStop = true;
            this.radioBaseComission.Text = "Base+Comission";
            this.radioBaseComission.UseVisualStyleBackColor = true;
            this.radioBaseComission.CheckedChanged += new System.EventHandler(this.radioBaseComission_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSalaried);
            this.groupBox1.Controls.Add(this.radioCommision);
            this.groupBox1.Controls.Add(this.radioBaseComission);
            this.groupBox1.Location = new System.Drawing.Point(156, 559);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(728, 125);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(156, 735);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(132, 31);
            this.txtSalary.TabIndex = 20;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(151, 706);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(195, 25);
            this.lblSalary.TabIndex = 21;
            this.lblSalary.Text = "Salary/Base Salary";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(396, 706);
            this.lblCommission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(175, 25);
            this.lblCommission.TabIndex = 23;
            this.lblCommission.Text = "Commisson Rate";
            // 
            // txtComission
            // 
            this.txtComission.Location = new System.Drawing.Point(401, 735);
            this.txtComission.Margin = new System.Windows.Forms.Padding(4);
            this.txtComission.Name = "txtComission";
            this.txtComission.Size = new System.Drawing.Size(132, 31);
            this.txtComission.TabIndex = 22;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(637, 706);
            this.lblSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(66, 25);
            this.lblSales.TabIndex = 25;
            this.lblSales.Text = "Sales";
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(643, 735);
            this.txtSales.Margin = new System.Windows.Forms.Padding(4);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(132, 31);
            this.txtSales.TabIndex = 24;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1007, 580);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(149, 48);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtEmployeeInfo
            // 
            this.txtEmployeeInfo.Location = new System.Drawing.Point(1087, 151);
            this.txtEmployeeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeInfo.Multiline = true;
            this.txtEmployeeInfo.Name = "txtEmployeeInfo";
            this.txtEmployeeInfo.Size = new System.Drawing.Size(565, 326);
            this.txtEmployeeInfo.TabIndex = 27;
            // 
            // deptCBox
            // 
            this.deptCBox.FormattingEnabled = true;
            this.deptCBox.Location = new System.Drawing.Point(680, 426);
            this.deptCBox.Name = "deptCBox";
            this.deptCBox.Size = new System.Drawing.Size(247, 33);
            this.deptCBox.TabIndex = 28;
            // 
            // dGridEmp
            // 
            this.dGridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridEmp.Location = new System.Drawing.Point(35, 773);
            this.dGridEmp.Name = "dGridEmp";
            this.dGridEmp.RowHeadersWidth = 82;
            this.dGridEmp.RowTemplate.Height = 33;
            this.dGridEmp.Size = new System.Drawing.Size(1742, 527);
            this.dGridEmp.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 1312);
            this.Controls.Add(this.dGridEmp);
            this.Controls.Add(this.deptCBox);
            this.Controls.Add(this.txtEmployeeInfo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.txtComission);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkMarried);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "EmployeeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.CheckBox chkMarried;
        private System.Windows.Forms.RadioButton radioSalaried;
        private System.Windows.Forms.RadioButton radioCommision;
        private System.Windows.Forms.RadioButton radioBaseComission;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtComission;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtEmployeeInfo;
        private System.Windows.Forms.ComboBox deptCBox;
        private System.Windows.Forms.DataGridView dGridEmp;
    }
}

