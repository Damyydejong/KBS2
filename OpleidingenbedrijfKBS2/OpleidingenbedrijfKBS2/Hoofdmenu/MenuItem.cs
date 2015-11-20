using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpleidingenbedrijfKBS2.Hoofdmenu
{
    class MenuItem
    {
        public string Name { get; set; }
        public UserControl userControl { get; set; }


        public MenuItem(string Name, UserControl userControl)
        {
            this.Name = Name;
            this.userControl = userControl; 
        }
    }
}
