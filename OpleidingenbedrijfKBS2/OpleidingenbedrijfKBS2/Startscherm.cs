using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpleidingenbedrijfKBS2
{
    public partial class Startscherm : Form
    {


        public Startscherm()
        {  
            InitializeComponent();
        }


       // Adding controlls to the Homescreen
        public void AddControls(Control AddControl)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    AddControl.Left = 270;
                    this.Controls.Add(AddControl);
                    AddControl.Focus();
                    AddControl.BringToFront();
                });
            }
            else
            {
                AddControl.Left = 270;
                this.Controls.Add(AddControl);
                AddControl.Focus();
                AddControl.BringToFront();
            }
        }

        public void RemoveControls(Control RemoveControl)
        {
            this.Controls.Remove(RemoveControl);
            //PS.Focus();
        }

        private void menuView1_Load(object sender, EventArgs e)
        {

        }

        private void menuLeftView1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
