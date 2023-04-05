namespace Serialization_Exception
{
    partial class SerializeForm
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
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.tBoxOpenDialog = new System.Windows.Forms.TextBox();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.tBoxSaveDialog = new System.Windows.Forms.TextBox();
            this.btnSaveDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Location = new System.Drawing.Point(250, 101);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(498, 44);
            this.btnOpenDialog.TabIndex = 0;
            this.btnOpenDialog.Text = "Open File for Serialization";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // tBoxOpenDialog
            // 
            this.tBoxOpenDialog.Location = new System.Drawing.Point(109, 182);
            this.tBoxOpenDialog.Name = "tBoxOpenDialog";
            this.tBoxOpenDialog.Size = new System.Drawing.Size(806, 31);
            this.tBoxOpenDialog.TabIndex = 1;
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(250, 259);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(498, 44);
            this.btnSerialize.TabIndex = 2;
            this.btnSerialize.Text = "Serialize and Save";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(250, 559);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(498, 44);
            this.btnDeserialize.TabIndex = 5;
            this.btnDeserialize.Text = "Deserialize and Create";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // tBoxSaveDialog
            // 
            this.tBoxSaveDialog.Location = new System.Drawing.Point(109, 482);
            this.tBoxSaveDialog.Name = "tBoxSaveDialog";
            this.tBoxSaveDialog.Size = new System.Drawing.Size(806, 31);
            this.tBoxSaveDialog.TabIndex = 4;
            // 
            // btnSaveDialog
            // 
            this.btnSaveDialog.Location = new System.Drawing.Point(250, 401);
            this.btnSaveDialog.Name = "btnSaveDialog";
            this.btnSaveDialog.Size = new System.Drawing.Size(498, 44);
            this.btnSaveDialog.TabIndex = 3;
            this.btnSaveDialog.Text = "Open File for Deserialization";
            this.btnSaveDialog.UseVisualStyleBackColor = true;
            this.btnSaveDialog.Click += new System.EventHandler(this.btnSaveDialog_Click);
            // 
            // SerializeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 734);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.tBoxSaveDialog);
            this.Controls.Add(this.btnSaveDialog);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.tBoxOpenDialog);
            this.Controls.Add(this.btnOpenDialog);
            this.Name = "SerializeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.TextBox tBoxOpenDialog;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.TextBox tBoxSaveDialog;
        private System.Windows.Forms.Button btnSaveDialog;
    }
}

