using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concrete;
using Entities.Concrete;

namespace Form1
{
    public partial class FormClients : Form
    {

        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
     /*   TextBox'lara maksimum karakter atanmasının kolaylaştırılmasını örneklemek için kullanmılmıştır. Bu problem form dizaynı üzerinde çözülmüştür.
      * readonly int CUSTOMER_NAME_MAX_LENGTH = 50;
        readonly int MAX_LENGTH_50 = 50;
        readonly int MAX_LENGTH_30 = 30;
     */

        public FormClients()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMainPage fmp = new FormMainPage();
            fmp.Show();
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            txtClientSearch.GotFocus += new EventHandler(this.TextGotFocus);
            txtClientSearch.LostFocus += new EventHandler(this.TextLostFocus);
         /*   TextBox karakter uzunluğu ayarlamak için kod kısmı örnek olarak bırakılmıştır. Bu problem form dizaynı üzerinde çözülmüştür.
          *   txtUpdateCustomerName.MaxLength = CUSTOMER_NAME_MAX_LENGTH;
              */
            clientsDataGridView.DataSource = customerManager.GetAll();
            
           
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.labelTime.Text = dateTime.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddName.Text) && !string.IsNullOrEmpty(txtAddSurname.Text) && !string.IsNullOrEmpty(txtAddPhoneNumber.Text))
            {
                customerManager.Add(new Customer
                {
                    CustomerName = txtAddName.Text,
                    CustomerSurname = txtAddSurname.Text,
                    PhoneNumber = txtAddPhoneNumber.Text,
                    Email = txtAddEmail.Text,
                    Country = txtAddCounty.Text,
                    City = txtAddCity.Text,
                    County = txtAddCounty.Text,
                    Address = txtAddAddress.Text,
                    HesCode = txtAddHesCode.Text,
                    Explanation = txtAddExplanation.Text

                });
                clientsDataGridView.DataSource = customerManager.GetAll();
                foreach (Control ctr in registrationGroupBox.Controls)
                {
                    if (ctr is TextBox)
                    {
                        ctr.Text = "";
                    }
                }
                MessageBox.Show("Added Succesfully!", "Submit Message", MessageBoxButtons.OK);
            }
            else
            {
                string message = "Sections with red asterisk can not be empty.";
                string title = "Error Message";
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, button);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }            
            
        }


        private void refreshButton_Click(object sender, EventArgs e)
        {
            clientsDataGridView.DataSource = customerManager.GetAll();
            //Databind sonrası ilk satırın otomatik olarak seçilmesini engeller.
            clientsDataGridView.ClearSelection();
        }

        private void registrationGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var customerName = txtClientSearch.Text;
            if (!string.IsNullOrEmpty(customerName))
            {
                List<Customer> customerList = customerManager.GetAll();
                //Her customer değişkeni için customerName'i stringe çevirip eşit olup olmadığını kontrol edip eşitse listeye dahil ediyor.
                List<Customer> matchingValues = customerList.Where(customer => customer.CustomerName.ToString().Equals(customerName)).ToList();
                // Customer list dolu mu boş mu kontrol için
                if(matchingValues.Count != 0)
                {
                    clientsDataGridView.DataSource = matchingValues;
                    clientsDataGridView.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Customer Not Found!", "Search Error", MessageBoxButtons.OK);
                   
                }
                
            }
             

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
          //CustomerName,CustomerSurname,PhoneNumber tüm kayıtlar için kritik belirlenmiştir.Bu değerlerin boş olmadığından emin olmak için kullanılan if döngüsü.
            if (!string.IsNullOrEmpty(txtUpdateCustomerName.Text) && !string.IsNullOrEmpty(txtUpdateCustomerSurname.Text) && !string.IsNullOrEmpty(txtUpdatePhoneNumber.Text))
            
            {
                int selectedIndex = clientsDataGridView.CurrentCell.RowIndex;
                customerManager.Update(new Customer
                {
                    CustomerId = Int32.Parse(txtCustomerID.Text),
                    CustomerName = txtUpdateCustomerName.Text,
                    CustomerSurname = txtUpdateCustomerSurname.Text,
                    PhoneNumber = txtUpdatePhoneNumber.Text,
                    Email = txtUpdateEmail.Text,
                    Country = txtUpdateCounty.Text,
                    City = txtUpdateCity.Text,
                    County = txtUpdateCounty.Text,
                    Address = txtUpdateAddress.Text,
                    HesCode = txtUpdateHesCode.Text,
                    Explanation = txtUpdateExplanation.Text

                });
                clientsDataGridView.DataSource = customerManager.GetAll();
                clientsDataGridView.ClearSelection();
                foreach (Control ctr in updateGroupBox.Controls)
                {
                    if (ctr is TextBox)
                    {
                        ctr.Text = "";
                    }
                }
                clientsDataGridView.Rows[selectedIndex].Selected = true;


            }
        }

        private void clientsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(clientsDataGridView.SelectedRows.Count > 0)
            {
                var row = clientsDataGridView.SelectedRows[0];
                var customer = (Customer)row.DataBoundItem;
                txtCustomerID.Text = customer.CustomerId.ToString();
                txtUpdateCustomerName.Text = customer.CustomerName;
                txtUpdateCustomerSurname.Text = customer.CustomerSurname;
                txtUpdatePhoneNumber.Text = customer.PhoneNumber;
                txtUpdateEmail.Text = customer.Email;
                txtUpdateCountry.Text = customer.Country;
                txtUpdateCity.Text = customer.City;
                txtUpdateCounty.Text = customer.County;
                txtUpdateAddress.Text = customer.Address;
                txtUpdateHesCode.Text = customer.HesCode;
                txtUpdateExplanation.Text = customer.Explanation;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string customerID = txtDeleteCustomerID.Text;
            List<Customer> customerList = customerManager.GetAll();
            
            //customer'ı customerId ye göre kontrol edip ilk bulduğu customer'ı döner.
            var match = customerList.FirstOrDefault(customer => customer.CustomerId.ToString().Equals(customerID));
            if (match != null)
            {
                customerManager.Delete(new Customer
                {

                    CustomerId = Int32.Parse(txtDeleteCustomerID.Text)

                });
                clientsDataGridView.DataSource = customerManager.GetAll();
                clientsDataGridView.ClearSelection();
                txtDeleteCustomerID.Clear();
                MessageBox.Show("Deleted " + customerID + " Succesfully!", "Delete Message", MessageBoxButtons.OK);
            }else
            {
                MessageBox.Show("Customer Not Found!", "Delete Message", MessageBoxButtons.OK);
            }        
        }
        
        // Aşağıdaki iki metod Search butonu için kullanılan TextBox'ın placeholder'ını atamak için oluşturulmuştur.
        public void TextGotFocus(object sender , EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb.Text == "Client Name")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }
        
        public void TextLostFocus(object sender , EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb.Text == "")
            {
                tb.Text = "Client Name";
                tb.ForeColor = Color.LightGray;
            }
        }

        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
