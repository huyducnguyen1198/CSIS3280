using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization_Exception
{
    public enum BookType
    {
        NONE = -1,
        SCIENCE = 0,
        ARTS = 1,
        MATHS = 2,
        HISTORY = 3,
        EDUCATION = 4,

    };
    public enum JournalType
    {
        NONE = -1,
        SCIENCE = 0,
        ARTS = 1,
        MATHS = 2,
        HISTORY = 3,
        EDUCATION = 4,
        FOOD = 5,
        FAMILY = 6,
        WOMAN = 7,
        TECH = 8,
        POLITIC = 9,
        NATURE = 10,
    };
    public enum LocationInLibrary
    {
        NONE = -1,
        FIRSTFLOOR = 0,
        SECONDFLOOR = 1,
        THIRDFLOOR = 2,
        ONLINE = 3,
    }
    public enum MagazineType
    {
        NONE = -1,
        SCIENCE = 0,
        ARTS = 1,
        MATHS = 2,
        HISTORY = 3,
        EDUCATION = 4,
        FOOD = 5,
        FAMILY = 6,
        WOMAN = 7,
    };
    public partial class BookForm : Form
    {
        
        public BookForm()
        {
            
            InitializeComponent();
            this.submitBut.MouseEnter += submitBut_MouseEnter;
            this.submitBut.MouseLeave += submitBut_MouseLeave;

            this.resetBut.MouseEnter += resetBut_MouseEnter;
            this.resetBut.MouseLeave += resetBut_MouseLeave;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(600, 400);

            // for this assignment, check book hard cover only
            this.libItemCBox.SelectedIndex = 0;
            this.bookRBut.Checked = true;
            this.libItemCBox.Visible = false;
            this.eBookRBut.Visible = false;

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
            
            String name = "";
            String author = "";
            String publisher = "";
            String isbn = "";
            String url = "";
            String genre = "";
            String location = "";
            int clone = 1;


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
                isbn = this.isbnTBox.Text;
                author = this.authorTBox.Text;
            }
            else if (this.libItemCBox.Text == "Magazine")
            {
                this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "Issue:", this.issueTBox.Text) + Environment.NewLine);
                this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "Publisher:", this.publisherTBox.Text) + Environment.NewLine);
                isbn = this.issueTBox.Text;
                publisher = this.publisherTBox.Text;
            }
            else
            {
                this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "ISBN:", this.isbnTBox.Text) + Environment.NewLine);
                this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "Publisher:", this.publisherTBox.Text) + Environment.NewLine);
                isbn = this.isbnTBox.Text;
                publisher = this.publisherTBox.Text;
            }

            if(this.libItemCBox.Text == "Book")
            {
                if(eBookRBut.Checked)
                {
                    this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "URL:", this.urlTBox.Text) + Environment.NewLine);
                    url = this.urlTBox.Text;
                }
            }
            else
            {
                this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "Location:", this.locationCBox.Text) + Environment.NewLine);
                location= this.locationCBox.Text;
            }

            this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "Genre:", this.genreCBox.Text) + Environment.NewLine);
            if (cloneChkBox.Checked)
                if (cloneTBox.Text.Length > 0)
                {
                    this.infoTBox.AppendText(String.Format("{0, -10} {1,-30}", "Clone Number:", this.cloneTBox.Text) + Environment.NewLine);
                    clone = int.Parse(this.cloneTBox.Text);
                }
                else
                {
                    clone = 1;
                }


            try
            {
                name = this.nameTBox.Text;
                if (name == String.Empty){
                    throw new BookNameEmptyException();
                }
                saveBookToFile(name, author, isbn, genre, location, clone);
                this.resetBut_Click(sender, e);
            }
            catch (BookNameEmptyException ex)
            {
                MessageBox.Show("Book name is empty");
                Console.WriteLine(ex.Message);
            }
            

        }

        private void saveBookToFile(
            String name,
            String author,
            String isbn,
            String genre,
            String location,
            int clone)
        {

            // save dialog
            Stream myStream;
            SaveFileDialog sf  = new SaveFileDialog();
            sf.Filter = "All files(*.*)|*.*|txt files(*.txt)|*.txt";
            sf.FilterIndex = 2;
            sf.RestoreDirectory= true;

            if(sf.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = sf.OpenFile()) != null){
                    using (StreamWriter sw = new StreamWriter(myStream))
                    {
                        sw.WriteLine("Book Title: " + name);
                        sw.WriteLine("Book Author: " + author);
                        sw.WriteLine("Book ISBN: " + isbn);
                        sw.WriteLine("Book genre: " + genre);
                        sw.WriteLine("Book Location: " + location);
                        sw.WriteLine("Number of clone: " + clone);
                    }

                }
            }
        }
    }
}
