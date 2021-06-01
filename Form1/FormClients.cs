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
    public partial class FormClients : Form
    {
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

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.labelTime.Text = dateTime.ToString();
        }
    }
}
