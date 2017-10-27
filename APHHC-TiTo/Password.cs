using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APHHC_TiTo
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }


        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                btnSignIn.Enabled = false;
            }

            else
            {
                btnSignIn.Enabled = true;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnCancel.PerformClick();
        }
    }
}
