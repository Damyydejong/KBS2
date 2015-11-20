using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpleidingenbedrijfKBS2.Hoofdmenu
{
    public partial class MenuLeftView : UserControl
    {

        //Menuitems list 
        List<MenuItem> menuItems = new List<MenuItem>();


        // Adding items to the Menu List
        public MenuLeftView()
        {
            this.menuItems.Add(new MenuItem("CursusBeheer", new Cursusbeheer.TestControl()));
            this.menuItems.Add(new MenuItem("Docentbeheer", new Cursusbeheer.TestControl())); 
            InitializeComponent();
        }



        // This shows the Menuleft.  
        private void MenuLeftView_Load(object sender, EventArgs e)
        {
            int top = 0; 

            foreach (var item in menuItems)
            {
                var button = new Button();
                button.Tag = item.userControl;
                button.Click += ButtonClicked;
                button.Text = item.Name; 
                button.Height = 50;
                button.Width = 150;
                button.Top = top;
                this.Controls.Add(button);
                top += button.Height + 2; 
            }
        }


        // When button is clicked -> Show Controller. 
        private void ButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UserControl usercontrol;

            usercontrol = new Cursusbeheer.TestControl();
            usercontrol.Left = 100; 
            this.Controls.Add(usercontrol);

        }
    }
}
