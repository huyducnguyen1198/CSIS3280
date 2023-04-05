namespace SLSPolymorphism
{
    partial class LibraryForm
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
            this.libItemCBox = new System.Windows.Forms.ComboBox();
            this.bookRBut = new System.Windows.Forms.RadioButton();
            this.eBookRBut = new System.Windows.Forms.RadioButton();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.submitBut = new System.Windows.Forms.Button();
            this.resetBut = new System.Windows.Forms.Button();
            this.cloneTBox = new System.Windows.Forms.TextBox();
            this.cloneChkBox = new System.Windows.Forms.CheckBox();
            this.cloneLabel = new System.Windows.Forms.Label();
            this.publisherTBox = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.issueTBox = new System.Windows.Forms.TextBox();
            this.issueLabel = new System.Windows.Forms.Label();
            this.genreCBox = new System.Windows.Forms.ComboBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.urlTBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.locationCBox = new System.Windows.Forms.ComboBox();
            this.locLabel = new System.Windows.Forms.Label();
            this.authorTBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.isbnTBox = new System.Windows.Forms.TextBox();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.infoTBox = new System.Windows.Forms.TextBox();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // libItemCBox
            // 
            this.libItemCBox.FormattingEnabled = true;
            this.libItemCBox.Items.AddRange(new object[] {
            "Book",
            "Journal",
            "Magazine"});
            this.libItemCBox.Location = new System.Drawing.Point(107, 76);
            this.libItemCBox.Name = "libItemCBox";
            this.libItemCBox.Size = new System.Drawing.Size(241, 33);
            this.libItemCBox.TabIndex = 0;
            this.libItemCBox.SelectedIndexChanged += new System.EventHandler(this.libItemCBox_SelectedIndexChanged);
            // 
            // bookRBut
            // 
            this.bookRBut.AutoSize = true;
            this.bookRBut.Location = new System.Drawing.Point(529, 76);
            this.bookRBut.Name = "bookRBut";
            this.bookRBut.Size = new System.Drawing.Size(92, 29);
            this.bookRBut.TabIndex = 1;
            this.bookRBut.TabStop = true;
            this.bookRBut.Text = "Book";
            this.bookRBut.UseVisualStyleBackColor = true;
            this.bookRBut.Visible = false;
            this.bookRBut.CheckedChanged += new System.EventHandler(this.bookRBut_CheckedChanged);
            // 
            // eBookRBut
            // 
            this.eBookRBut.AutoSize = true;
            this.eBookRBut.Location = new System.Drawing.Point(665, 76);
            this.eBookRBut.Name = "eBookRBut";
            this.eBookRBut.Size = new System.Drawing.Size(106, 29);
            this.eBookRBut.TabIndex = 2;
            this.eBookRBut.TabStop = true;
            this.eBookRBut.Text = "EBook";
            this.eBookRBut.UseVisualStyleBackColor = true;
            this.eBookRBut.Visible = false;
            this.eBookRBut.CheckedChanged += new System.EventHandler(this.eBookRBut_CheckedChanged);
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.submitBut);
            this.infoPanel.Controls.Add(this.resetBut);
            this.infoPanel.Controls.Add(this.cloneTBox);
            this.infoPanel.Controls.Add(this.cloneChkBox);
            this.infoPanel.Controls.Add(this.cloneLabel);
            this.infoPanel.Controls.Add(this.publisherTBox);
            this.infoPanel.Controls.Add(this.publisherLabel);
            this.infoPanel.Controls.Add(this.issueTBox);
            this.infoPanel.Controls.Add(this.issueLabel);
            this.infoPanel.Controls.Add(this.genreCBox);
            this.infoPanel.Controls.Add(this.genreLabel);
            this.infoPanel.Controls.Add(this.urlTBox);
            this.infoPanel.Controls.Add(this.urlLabel);
            this.infoPanel.Controls.Add(this.locationCBox);
            this.infoPanel.Controls.Add(this.locLabel);
            this.infoPanel.Controls.Add(this.authorTBox);
            this.infoPanel.Controls.Add(this.authorLabel);
            this.infoPanel.Controls.Add(this.isbnTBox);
            this.infoPanel.Controls.Add(this.isbnLabel);
            this.infoPanel.Controls.Add(this.nameTBox);
            this.infoPanel.Controls.Add(this.nameLabel);
            this.infoPanel.Location = new System.Drawing.Point(143, 170);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(726, 433);
            this.infoPanel.TabIndex = 3;
            this.infoPanel.Visible = false;
            // 
            // submitBut
            // 
            this.submitBut.Location = new System.Drawing.Point(248, 371);
            this.submitBut.Name = "submitBut";
            this.submitBut.Size = new System.Drawing.Size(123, 42);
            this.submitBut.TabIndex = 19;
            this.submitBut.Text = "Submit";
            this.submitBut.UseVisualStyleBackColor = true;
            this.submitBut.Click += new System.EventHandler(this.submitBut_Click);
            // 
            // resetBut
            // 
            this.resetBut.Location = new System.Drawing.Point(585, 3);
            this.resetBut.Name = "resetBut";
            this.resetBut.Size = new System.Drawing.Size(123, 42);
            this.resetBut.TabIndex = 18;
            this.resetBut.Text = "reset";
            this.resetBut.UseVisualStyleBackColor = true;
            this.resetBut.Click += new System.EventHandler(this.resetBut_Click);
            // 
            // cloneTBox
            // 
            this.cloneTBox.Location = new System.Drawing.Point(248, 296);
            this.cloneTBox.Name = "cloneTBox";
            this.cloneTBox.Size = new System.Drawing.Size(100, 31);
            this.cloneTBox.TabIndex = 17;
            this.cloneTBox.Visible = false;
            // 
            // cloneChkBox
            // 
            this.cloneChkBox.AutoSize = true;
            this.cloneChkBox.Location = new System.Drawing.Point(183, 296);
            this.cloneChkBox.Name = "cloneChkBox";
            this.cloneChkBox.Size = new System.Drawing.Size(28, 27);
            this.cloneChkBox.TabIndex = 16;
            this.cloneChkBox.UseVisualStyleBackColor = true;
            this.cloneChkBox.CheckedChanged += new System.EventHandler(this.cloneChkBox_CheckedChanged);
            // 
            // cloneLabel
            // 
            this.cloneLabel.AutoSize = true;
            this.cloneLabel.Location = new System.Drawing.Point(51, 298);
            this.cloneLabel.Name = "cloneLabel";
            this.cloneLabel.Size = new System.Drawing.Size(68, 25);
            this.cloneLabel.TabIndex = 15;
            this.cloneLabel.Text = "Clone";
            // 
            // publisherTBox
            // 
            this.publisherTBox.Location = new System.Drawing.Point(183, 138);
            this.publisherTBox.Name = "publisherTBox";
            this.publisherTBox.Size = new System.Drawing.Size(330, 31);
            this.publisherTBox.TabIndex = 14;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(51, 146);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(102, 25);
            this.publisherLabel.TabIndex = 13;
            this.publisherLabel.Text = "Publisher";
            // 
            // issueTBox
            // 
            this.issueTBox.Location = new System.Drawing.Point(183, 83);
            this.issueTBox.Name = "issueTBox";
            this.issueTBox.Size = new System.Drawing.Size(330, 31);
            this.issueTBox.TabIndex = 12;
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.Location = new System.Drawing.Point(51, 90);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(63, 25);
            this.issueLabel.TabIndex = 11;
            this.issueLabel.Text = "Issue";
            // 
            // genreCBox
            // 
            this.genreCBox.FormattingEnabled = true;
            this.genreCBox.Location = new System.Drawing.Point(183, 239);
            this.genreCBox.Name = "genreCBox";
            this.genreCBox.Size = new System.Drawing.Size(330, 33);
            this.genreCBox.TabIndex = 10;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(51, 248);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(71, 25);
            this.genreLabel.TabIndex = 9;
            this.genreLabel.Text = "Genre";
            // 
            // urlTBox
            // 
            this.urlTBox.Location = new System.Drawing.Point(183, 189);
            this.urlTBox.Name = "urlTBox";
            this.urlTBox.Size = new System.Drawing.Size(330, 31);
            this.urlTBox.TabIndex = 8;
            this.urlTBox.Visible = false;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(51, 196);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(54, 25);
            this.urlLabel.TabIndex = 7;
            this.urlLabel.Text = "URL";
            this.urlLabel.Visible = false;
            // 
            // locationCBox
            // 
            this.locationCBox.FormattingEnabled = true;
            this.locationCBox.Items.AddRange(new object[] {
            "Book",
            "Journal",
            "Magazine"});
            this.locationCBox.Location = new System.Drawing.Point(183, 187);
            this.locationCBox.Name = "locationCBox";
            this.locationCBox.Size = new System.Drawing.Size(330, 33);
            this.locationCBox.TabIndex = 4;
            // 
            // locLabel
            // 
            this.locLabel.AutoSize = true;
            this.locLabel.Location = new System.Drawing.Point(51, 195);
            this.locLabel.Name = "locLabel";
            this.locLabel.Size = new System.Drawing.Size(94, 25);
            this.locLabel.TabIndex = 6;
            this.locLabel.Text = "Location";
            // 
            // authorTBox
            // 
            this.authorTBox.Location = new System.Drawing.Point(183, 138);
            this.authorTBox.Name = "authorTBox";
            this.authorTBox.Size = new System.Drawing.Size(330, 31);
            this.authorTBox.TabIndex = 5;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(51, 145);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(75, 25);
            this.authorLabel.TabIndex = 4;
            this.authorLabel.Text = "Author";
            // 
            // isbnTBox
            // 
            this.isbnTBox.Location = new System.Drawing.Point(183, 82);
            this.isbnTBox.Name = "isbnTBox";
            this.isbnTBox.Size = new System.Drawing.Size(330, 31);
            this.isbnTBox.TabIndex = 3;
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(51, 89);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(60, 25);
            this.isbnLabel.TabIndex = 2;
            this.isbnLabel.Text = "ISBN";
            // 
            // nameTBox
            // 
            this.nameTBox.Location = new System.Drawing.Point(183, 30);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(330, 31);
            this.nameTBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(51, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // infoTBox
            // 
            this.infoTBox.Location = new System.Drawing.Point(875, 199);
            this.infoTBox.Multiline = true;
            this.infoTBox.Name = "infoTBox";
            this.infoTBox.Size = new System.Drawing.Size(447, 404);
            this.infoTBox.TabIndex = 4;
            this.infoTBox.Visible = false;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 754);
            this.Controls.Add(this.infoTBox);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.eBookRBut);
            this.Controls.Add(this.bookRBut);
            this.Controls.Add(this.libItemCBox);
            this.Name = "LibraryForm";
            this.Text = "LibraryForm";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox libItemCBox;
        private System.Windows.Forms.RadioButton bookRBut;
        private System.Windows.Forms.RadioButton eBookRBut;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.TextBox isbnTBox;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.TextBox nameTBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox authorTBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.ComboBox locationCBox;
        private System.Windows.Forms.Label locLabel;
        private System.Windows.Forms.TextBox urlTBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.ComboBox genreCBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox publisherTBox;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox issueTBox;
        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.TextBox cloneTBox;
        private System.Windows.Forms.CheckBox cloneChkBox;
        private System.Windows.Forms.Label cloneLabel;
        private System.Windows.Forms.Button resetBut;
        private System.Windows.Forms.Button submitBut;
        private System.Windows.Forms.TextBox infoTBox;
    }
}