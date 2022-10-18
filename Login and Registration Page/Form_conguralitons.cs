using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_and_Registration_Page
{
    public partial class Form_conguralitons : Form
    {
        public Form_conguralitons()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_Login frmlogin= new Form_Login();
            this.Hide();
            frmlogin.ShowDialog();
        }
    }
}
