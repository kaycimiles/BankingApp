using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

      

        private void logButton_Click(object sender, EventArgs e)
        {
            banking_dbEntities dbe = new banking_dbEntities();
            if (userText.Text!=string.Empty || passText.Text!=string.Empty)
            {
                var user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(userText.Text));
                if (user1!=null)
                {
                    if (user1.Password.Equals(passText.Text))
                    {
                        Menu m1 = new Menu();
                        m1.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password");
            }
        }
    }
}
