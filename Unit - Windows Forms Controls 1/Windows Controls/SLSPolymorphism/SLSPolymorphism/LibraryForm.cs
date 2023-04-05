using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLSPolymorphism
{
    public partial class LibraryForm : Form
    {
        Librarian lib;
        public LibraryForm(Librarian lib)
        {
            
            InitializeComponent();
            this.lib = lib;
            this.submitBut.MouseEnter += submitBut_MouseEnter;
            this.submitBut.MouseLeave += submitBut_MouseLeave;

            this.resetBut.MouseEnter += resetBut_MouseEnter;
            this.resetBut.MouseLeave += resetBut_MouseLeave;
        }

        private void libItemCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.infoTBox.Visible = false;
            String opt = libItemCBox.Text;
            if (opt == "Book")
            {
                bookRBut.Visible = true;
                eBookRBut.Visible = true;
                this.genreCBox.DataSource = Enum.GetValues(typeof(BookType));

                this.authorLabel.Visible = true;
                this.authorTBox.Visible = true;
                this.publisherLabel.Visible = false;
                this.publisherTBox.Visible = false;

                this.isbnLabel.Visible = true;
                this.isbnTBox.Visible = true;
                this.issueTBox.Visible = false;
                this.issueLabel.Visible = false;

            }
            else
            {
                eBookRBut.Visible = false;
                bookRBut.Visible = false;
                this.urlLabel.Visible = false;
                this.urlTBox.Visible = false;
                this.locLabel.Visible = true;
                this.locationCBox.Visible = true;
                this.locationCBox.DataSource = Enum.GetValues(typeof(LocationInLibrary));
                this.infoPanel.Visible = true;

                if(opt == "Magazine")
                {
                    this.genreCBox.DataSource = Enum.GetValues(typeof(MagazineType));

                    this.isbnLabel.Visible = false;
                    this.isbnTBox.Visible =false;
                    this.issueLabel.Visible = true;
                    this.issueTBox.Visible = true;

                    this.publisherLabel.Visible = true;
                    this.publisherTBox.Visible = true;
                    this.authorLabel.Visible = false;
                    this.authorLabel.Visible = false;
                }
                else
                {

                    this.genreCBox.DataSource = Enum.GetValues(typeof(JournalType));

                    this.isbnLabel.Visible = true;
                    this.isbnTBox.Visible = true;
                    this.issueTBox.Visible = false;
                    this.issueLabel.Visible = false;

                    this.publisherLabel.Visible = true;
                    this.publisherTBox.Visible = true;
                    this.authorLabel.Visible = false;
                    this.authorLabel.Visible = false;
                }

            }

        }

        private void bookRBut_CheckedChanged(object sender, EventArgs e)
        {
            if (bookRBut.Checked) {
                this.urlLabel.Visible = false;
                this.urlTBox.Visible = false;
                this.locLabel.Visible = true;
                this.locationCBox.Visible = true;
                this.locationCBox.DataSource = Enum.GetValues(typeof(LocationInLibrary));
                this.infoPanel.Visible = true;

            }


        }

        private void eBookRBut_CheckedChanged(object sender, EventArgs e)
        {
            if(this.eBookRBut.Checked)
            {
                this.urlLabel.Visible = true;
                this.urlTBox.Visible = true;
                this.locLabel.Visible = false;
                this.locationCBox.Visible = false;
                this.infoPanel.Visible = true;

            }
        }

        private void cloneChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cloneChkBox.Checked)
            {
                this.cloneTBox.Visible=true;
            }
            else
            {
                this.cloneTBox.Visible = false;
            }
        }

        private void resetBut_Click(object sender, EventArgs e)
        {
            this.nameTBox.Clear();
            this.authorTBox.Clear();
            this.publisherTBox.Clear();
            this.isbnTBox.Clear();
            this.issueTBox.Clear();
            this.urlTBox.Clear();
            this.cloneChkBox.Checked = false;
            this.locationCBox.SelectedIndex = 0;
            this.genreCBox.SelectedIndex = 0;
            this.infoTBox.Clear();
            this.infoTBox.Visible = false;
        }

        private void submitBut_MouseEnter(object sender, EventArgs e)
        {
            this.submitBut.BackColor = Color.Chocolate;
            this.submitBut.Size = new Size(this.submitBut.Size.Width + 10, this.submitBut.Size.Height + 5);
        }
        private void submitBut_MouseLeave(object sender, EventArgs e)
        {
            this.submitBut.BackColor = Color.White;
            this.submitBut.Size = new Size(this.submitBut.Size.Width - 10, this.submitBut.Size.Height - 5);

        }

        private void resetBut_MouseEnter(object sender, EventArgs e)
        {
            this.resetBut.BackColor = Color.Chocolate;
            this.resetBut.Size = new Size(this.resetBut.Size.Width + 5, this.resetBut.Size.Height + 2);
        }
        private void resetBut_MouseLeave(object sender, EventArgs e)
        {
            this.resetBut.BackColor = Color.White;
            this.resetBut.Size = new Size(this.resetBut.Size.Width - 5, this.resetBut.Size.Height - 2);

        }
        private void submitBut_Click(object sender, EventArgs e)
        {
            this.infoTBox.Clear();
            this.infoTBox.Visible = true;
            if(this.libItemCBox.Text == "Book")
            {
                this.infoTBox.AppendText("New Book Info" + Environment.NewLine);

            }else if(this.libItemCBox.Text == "Magazine")
            {
                this.infoTBox.AppendText("New Magazine Info" + Environment.NewLine);
            }
            else
            {
                this.infoTBox.AppendText("New Journal Info" + Environment.NewLine);
            }

            this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "Title:", this.nameTBox.Text) + Environment.NewLine);

            if (this.libItemCBox.Text == "Book")
            {
                this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "ISBN:", this.isbnTBox.Text) + Environment.NewLine);
                this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "Author:", this.authorTBox.Text) + Environment.NewLine);
     
            }
            else if (this.libItemCBox.Text == "Magazine")
            {
                this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "Issue:", this.issueTBox.Text) + Environment.NewLine);
                this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "Publisher:", this.publisherTBox.Text) + Environment.NewLine);

            }
            else
            {
                this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "ISBN:", this.isbnTBox.Text) + Environment.NewLine);
                this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "Publisher:", this.publisherTBox.Text) + Environment.NewLine);
            }

            if(this.libItemCBox.Text == "Book")
            {
                if(eBookRBut.Checked)
                {
                    this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "URL:", this.urlTBox.Text) + Environment.NewLine);

                }
            }
            else
            {
                this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "Location:", this.locationCBox.Text) + Environment.NewLine);

            }

            this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "Genre:", this.genreCBox.Text) + Environment.NewLine);
            if(cloneChkBox.Checked)
                if(cloneTBox.Text.Length > 0)
                    this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "Clone Number:", this.cloneTBox.Text) + Environment.NewLine);



        }
    }
}
