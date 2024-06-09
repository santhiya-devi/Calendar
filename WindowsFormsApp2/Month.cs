using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Month : UserControl
    {
        public Month()
        {
            InitializeComponent();
        }

        private void m1_MouseEnter(object sender, EventArgs e)
        {
            Label l1 = (Label)sender;
            l1.BackColor = Color.AliceBlue;
        }

        private void m1_MouseLeave(object sender, EventArgs e)
        {
            Label l1 = (Label)sender;
            l1.BackColor = Color.Transparent;
        }
    }
}
