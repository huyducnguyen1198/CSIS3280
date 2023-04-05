using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization_Exception
{
    public partial class SerializeForm : Form

    {
        private OpenFileDialog op;
        private OpenFileDialog ofDeserialize;
        private SaveFileDialog sp;
        public SerializeForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(600, 400);
            op = new OpenFileDialog()
            {
                FileName = "Select a Text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text File"
            };
            ofDeserialize = new OpenFileDialog()
            {
                FileName = "Select a bin file",
                Filter = "Bin file (*.dat)|*.dat"
            };
            sp = new SaveFileDialog()
            {
                FileName = "Save a text file",
                Filter = "Text files (*.dat)|*.dat|Text files (*.txt)|*.txt",
                Title = "Save text file"
            };
        }


        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            if(op.ShowDialog() == DialogResult.OK)
            {
               
                // open file and read content
                var filePath = op.FileName;
                tBoxOpenDialog.Text = filePath;
                    
            }
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {

            try {

                if(sp.ShowDialog() == DialogResult.OK) {
                    //get file path from opening text file
                    var filePath = tBoxOpenDialog.Text;
                    FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                    StreamReader rs = new StreamReader(fs);
                    String bookInfo = rs.ReadToEnd();


                    // open file to write serialization
                    FileInfo fi = new FileInfo(filePath);

                    //get serialized.dat file name from sp dialog
                    String fname = sp.FileName;
                    FileStream serializedFS = new FileStream(fname, FileMode.Create);
                    //serialize
                    BinaryFormatter bf = new BinaryFormatter();

                    try
                    {
                        bf.Serialize(serializedFS, bookInfo);
                    }
                    catch (SerializationException ex)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + ex.Message);
                        throw;

                    }
                    
                    finally
                    {
                        serializedFS.Close();
                    }
                }
                
            }
            catch(SecurityException ex)
            {
                Console.WriteLine("Security exception. Reason: " + ex.Message);
                throw;

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Failed to open file. " + ex.Message);
                throw;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Failed to open file. " + ex.Message);
                throw;
            }
            finally
            {
                sp.Reset();
            }
        }
        
        private void btnSaveDialog_Click(object sender, EventArgs e)
        {

            if(ofDeserialize.ShowDialog() == DialogResult.OK)
            {
                //get file name from dialog and open file

                var filePath = ofDeserialize.FileName;
                this.tBoxSaveDialog.Text = filePath;

               
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {

            try
            {
                String bookInfo = "";
                var filePath = this.tBoxSaveDialog.Text;
                FileStream fs = new FileStream(filePath, FileMode.Open);

                sp.Filter = "Text file (*.txt)|*.txt";
                FileInfo fi = new FileInfo(filePath);

                sp.FileName = fi.Name.Split('.')[0] + "Deserialized.txt";
                if (sp.ShowDialog() == DialogResult.OK)
                {
                    FileStream deserialized = new FileStream(sp.FileName, FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();

                    try
                    {

                        //deserilaize

                        //new file for Deserialized file
                        bookInfo = (String)bf.Deserialize(fs);
                        using (StreamWriter sr = new StreamWriter(deserialized))
                        {
                            sr.Write(bookInfo);

                        }

                    }
                    catch (SerializationException ex)
                    {
                        Console.WriteLine("Failed to Deserialize. Reason: " + ex.Message);
                        throw;
                    }
                    finally
                    {
                        deserialized.Close();
                    }

                    MessageBox.Show(bookInfo);
                }
            }
            catch (SecurityException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Failed to open file. " + ex.Message);
                throw;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Failed to open file. " + ex.Message);
                throw;
            }

        }
    }
}
