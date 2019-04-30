using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapert4_element_github
{
    public partial class Form1 : Form
    {        
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        Elephant lucinda = new Elephant() { Name = "Lloyd", EarSize = 33 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Elephant swap;
            swap = lloyd;
            lloyd = lucinda;
            lucinda = swap;
            swap = null;
            MessageBox.Show("objects swapped");
        }
    }
}