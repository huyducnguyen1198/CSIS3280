using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization_Exception
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;
        SerializeForm serializeForm;
        BookForm bookForm;
        public MainForm()
        {
            InitializeComponent();
            #region create child serielize form

            childFormNumber ++;
            serializeForm = new SerializeForm();
            serializeForm.MdiParent= this;
            serializeForm.Text = "Serialize/Deserialize";
            #endregion

            #region create book form
            childFormNumber++;
            bookForm = new BookForm();
            bookForm.MdiParent= this;
            bookForm.Text = "New book";
            #endregion
        }


        private void createNewBookObjetionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serializeForm.Hide();
            bookForm.Show();
            bookForm.Location = new Point(10, 10);
        }

        private void serializeDeserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookForm.Hide();
            serializeForm.Show();
            serializeForm.Location = new Point(10, 10);

        }
    }
}
