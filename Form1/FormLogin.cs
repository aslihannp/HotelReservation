using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            try
            {
                using (HotelContext context = new HotelContext())
                {
                    //using linq to query data
                    var query = from o in context.USERS
                                where o.UserName == txtUserName.Text && o.Password == txtPassword.Text
                                select o;
                    //check if user exists
                    if (query.SingleOrDefault() != null)
                    {
                        MessageBox.Show("You have been successfully logged in.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Add your code process login here
                        FormClients formClients = new FormClients();
                        formClients.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your username or password is incorrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
