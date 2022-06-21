using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Kontroller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Doldur(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                if (item is TextBox)
                    item.Text = "Merhaba";
                else if (item is GroupBox)
                {
                    Doldur(item.Controls);
                }
                    
            }
        }

        private void btnTextBoxDoldur_Click(object sender, EventArgs e)
        {
            Doldur(this.Controls);
        }

        private void btnGrpTextSil_Click(object sender, EventArgs e)
        {
            Temizle(grp1.Controls);
        }

        private void btnTextBoxTemizle_Click(object sender, EventArgs e)
        {
            Temizle(this.Controls);
        }

        private void Temizle(Control.ControlCollection controls)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                else if (item is GroupBox)
                    Temizle(item.Controls);
            }
        }

        private void btnGrpTextDoldur_Click(object sender, EventArgs e)
        {
            Doldur(grp1.Controls);
        }
    }
}
