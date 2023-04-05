using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAssignment4
{
    public partial class Form1 : Form
    {

        public delegate void EventHandlerCS3280(object sender, bool e);
        EventHandlerCS3280 cs3280EventHander = null;
        event EventHandlerCS3280 cs3280Event;

        public Form1()
        {
            InitializeComponent();
            //TODO: Initialize the EventHandlerCS3280 delegate correctly here
            // associate it with chkTest_CheckedChanged handler. 
            cs3280EventHander = new EventHandlerCS3280(this.chkTest_CheckedChanged);
            //TODO: intialize the event cs3280Event and associate it with newly Created delegate.
            EventHandlerCS3280 chk2Hanlder = new EventHandlerCS3280(this.chk2_CheckedChanged);
            EventHandlerCS3280 lblHanlder = new EventHandlerCS3280(this.lblCheckOrUnchecked_Click);
            cs3280Event += cs3280EventHander;
            cs3280Event += chk2Hanlder;
            cs3280Event+= lblHanlder;
            //



        }



        public void chkTest_CheckedChanged(Object sender, bool checkedStatus)
        {

            MessageBox.Show("CS 3280 Event Fired: Currently checkbox is " + (checkedStatus ? "checked" : "unchekced"));


        }

        private void BtnTest_Click(object sender, EventArgs e)
        {

            //TODO: Fire the event here and and pass checkbox checked status here. 
            //see if it flows to chkTest_CheckedChanged event. 
            
            cs3280Event.Invoke(sender, this.chkTest.Checked);

        }

        private void chk2_CheckedChanged(object sender, bool e)
        {
            this.chk2.Checked = !this.chk2.Checked;
        }

        private void lblCheckOrUnchecked_Click(object sender, bool e)
        {
            if(chkTest.Checked)
            {
                this.lblCheckOrUnchecked.Text = "Uncheck Me Right now!";
            }
            else
            {
                this.lblCheckOrUnchecked.Text = "Check Me Right now!";

            }
        }
    }
}
