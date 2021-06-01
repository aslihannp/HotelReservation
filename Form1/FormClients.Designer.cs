namespace Form1
{
    partial class FormClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeClientGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.txtDeleteCustomerID = new System.Windows.Forms.TextBox();
            this.updateGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.txtUpdateExplanation = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpdateHesCode = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtUpdateCustomerName = new System.Windows.Forms.TextBox();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateCounty = new System.Windows.Forms.TextBox();
            this.txtUpdateCustomerSurname = new System.Windows.Forms.TextBox();
            this.txtUpdateCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateCountry = new System.Windows.Forms.TextBox();
            this.txtUpdatePhoneNumber = new System.Windows.Forms.TextBox();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.registrationGroupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddExplanation = new System.Windows.Forms.TextBox();
            this.txtAddHesCode = new System.Windows.Forms.TextBox();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.txtAddCounty = new System.Windows.Forms.TextBox();
            this.txtAddCity = new System.Windows.Forms.TextBox();
            this.txtAddCountry = new System.Windows.Forms.TextBox();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countyLabel = new System.Windows.Forms.Label();
            this.explanationLabel = new System.Windows.Forms.Label();
            this.hesCodelabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.customerSurnameLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientSearch = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.removeClientGroupBox.SuspendLayout();
            this.updateGroupBox.SuspendLayout();
            this.registrationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBack.Location = new System.Drawing.Point(3, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(83, 30);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removeClientGroupBox);
            this.panel1.Controls.Add(this.updateGroupBox);
            this.panel1.Controls.Add(this.registrationGroupBox);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.clientsDataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtClientSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 714);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // removeClientGroupBox
            // 
            this.removeClientGroupBox.Controls.Add(this.buttonDelete);
            this.removeClientGroupBox.Controls.Add(this.customerIDLabel);
            this.removeClientGroupBox.Controls.Add(this.txtDeleteCustomerID);
            this.removeClientGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.removeClientGroupBox.Location = new System.Drawing.Point(447, 364);
            this.removeClientGroupBox.Name = "removeClientGroupBox";
            this.removeClientGroupBox.Size = new System.Drawing.Size(499, 82);
            this.removeClientGroupBox.TabIndex = 7;
            this.removeClientGroupBox.TabStop = false;
            this.removeClientGroupBox.Text = "Remove Client";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDelete.Location = new System.Drawing.Point(243, 40);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(194, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete Client";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerIDLabel.Location = new System.Drawing.Point(53, 45);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(71, 13);
            this.customerIDLabel.TabIndex = 0;
            this.customerIDLabel.Text = "Customer ID :";
            // 
            // txtDeleteCustomerID
            // 
            this.txtDeleteCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDeleteCustomerID.Location = new System.Drawing.Point(130, 42);
            this.txtDeleteCustomerID.MaxLength = 50;
            this.txtDeleteCustomerID.Name = "txtDeleteCustomerID";
            this.txtDeleteCustomerID.Size = new System.Drawing.Size(97, 20);
            this.txtDeleteCustomerID.TabIndex = 2;
            // 
            // updateGroupBox
            // 
            this.updateGroupBox.Controls.Add(this.buttonUpdate);
            this.updateGroupBox.Controls.Add(this.txtUpdateExplanation);
            this.updateGroupBox.Controls.Add(this.label17);
            this.updateGroupBox.Controls.Add(this.label16);
            this.updateGroupBox.Controls.Add(this.label15);
            this.updateGroupBox.Controls.Add(this.CustomerID);
            this.updateGroupBox.Controls.Add(this.label2);
            this.updateGroupBox.Controls.Add(this.txtUpdateHesCode);
            this.updateGroupBox.Controls.Add(this.txtCustomerID);
            this.updateGroupBox.Controls.Add(this.txtUpdateCustomerName);
            this.updateGroupBox.Controls.Add(this.txtUpdateAddress);
            this.updateGroupBox.Controls.Add(this.label3);
            this.updateGroupBox.Controls.Add(this.txtUpdateCounty);
            this.updateGroupBox.Controls.Add(this.txtUpdateCustomerSurname);
            this.updateGroupBox.Controls.Add(this.txtUpdateCity);
            this.updateGroupBox.Controls.Add(this.label4);
            this.updateGroupBox.Controls.Add(this.txtUpdateCountry);
            this.updateGroupBox.Controls.Add(this.txtUpdatePhoneNumber);
            this.updateGroupBox.Controls.Add(this.txtUpdateEmail);
            this.updateGroupBox.Controls.Add(this.label5);
            this.updateGroupBox.Controls.Add(this.label11);
            this.updateGroupBox.Controls.Add(this.label6);
            this.updateGroupBox.Controls.Add(this.label7);
            this.updateGroupBox.Controls.Add(this.label10);
            this.updateGroupBox.Controls.Add(this.label8);
            this.updateGroupBox.Controls.Add(this.label9);
            this.updateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateGroupBox.Location = new System.Drawing.Point(447, 451);
            this.updateGroupBox.Name = "updateGroupBox";
            this.updateGroupBox.Size = new System.Drawing.Size(689, 260);
            this.updateGroupBox.TabIndex = 6;
            this.updateGroupBox.TabStop = false;
            this.updateGroupBox.Text = "Update Customer Info";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdate.Location = new System.Drawing.Point(426, 219);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(204, 29);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update Client";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // txtUpdateExplanation
            // 
            this.txtUpdateExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateExplanation.Location = new System.Drawing.Point(411, 142);
            this.txtUpdateExplanation.MaxLength = 100;
            this.txtUpdateExplanation.Multiline = true;
            this.txtUpdateExplanation.Name = "txtUpdateExplanation";
            this.txtUpdateExplanation.Size = new System.Drawing.Size(232, 70);
            this.txtUpdateExplanation.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(146, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 20);
            this.label17.TabIndex = 3;
            this.label17.Text = "*";
            this.label17.Click += new System.EventHandler(this.label12_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(146, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "*";
            this.label16.Click += new System.EventHandler(this.label12_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(146, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "*";
            this.label15.Click += new System.EventHandler(this.label12_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomerID.Location = new System.Drawing.Point(38, 27);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(71, 13);
            this.CustomerID.TabIndex = 0;
            this.CustomerID.Text = "Customer ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name :";
            // 
            // txtUpdateHesCode
            // 
            this.txtUpdateHesCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateHesCode.Location = new System.Drawing.Point(411, 111);
            this.txtUpdateHesCode.MaxLength = 10;
            this.txtUpdateHesCode.Name = "txtUpdateHesCode";
            this.txtUpdateHesCode.Size = new System.Drawing.Size(232, 20);
            this.txtUpdateHesCode.TabIndex = 2;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerID.Location = new System.Drawing.Point(167, 25);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(172, 20);
            this.txtCustomerID.TabIndex = 2;
            // 
            // txtUpdateCustomerName
            // 
            this.txtUpdateCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateCustomerName.Location = new System.Drawing.Point(167, 54);
            this.txtUpdateCustomerName.MaxLength = 50;
            this.txtUpdateCustomerName.Name = "txtUpdateCustomerName";
            this.txtUpdateCustomerName.Size = new System.Drawing.Size(172, 20);
            this.txtUpdateCustomerName.TabIndex = 2;
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateAddress.Location = new System.Drawing.Point(411, 21);
            this.txtUpdateAddress.MaxLength = 50;
            this.txtUpdateAddress.Multiline = true;
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(232, 84);
            this.txtUpdateAddress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Surname :";
            // 
            // txtUpdateCounty
            // 
            this.txtUpdateCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateCounty.Location = new System.Drawing.Point(125, 222);
            this.txtUpdateCounty.MaxLength = 20;
            this.txtUpdateCounty.Name = "txtUpdateCounty";
            this.txtUpdateCounty.Size = new System.Drawing.Size(214, 20);
            this.txtUpdateCounty.TabIndex = 2;
            // 
            // txtUpdateCustomerSurname
            // 
            this.txtUpdateCustomerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateCustomerSurname.Location = new System.Drawing.Point(167, 78);
            this.txtUpdateCustomerSurname.MaxLength = 50;
            this.txtUpdateCustomerSurname.Name = "txtUpdateCustomerSurname";
            this.txtUpdateCustomerSurname.Size = new System.Drawing.Size(172, 20);
            this.txtUpdateCustomerSurname.TabIndex = 2;
            // 
            // txtUpdateCity
            // 
            this.txtUpdateCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateCity.Location = new System.Drawing.Point(125, 196);
            this.txtUpdateCity.MaxLength = 20;
            this.txtUpdateCity.Name = "txtUpdateCity";
            this.txtUpdateCity.Size = new System.Drawing.Size(214, 20);
            this.txtUpdateCity.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone Number :";
            // 
            // txtUpdateCountry
            // 
            this.txtUpdateCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateCountry.Location = new System.Drawing.Point(125, 168);
            this.txtUpdateCountry.MaxLength = 20;
            this.txtUpdateCountry.Name = "txtUpdateCountry";
            this.txtUpdateCountry.Size = new System.Drawing.Size(214, 20);
            this.txtUpdateCountry.TabIndex = 2;
            // 
            // txtUpdatePhoneNumber
            // 
            this.txtUpdatePhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdatePhoneNumber.Location = new System.Drawing.Point(167, 110);
            this.txtUpdatePhoneNumber.MaxLength = 10;
            this.txtUpdatePhoneNumber.Name = "txtUpdatePhoneNumber";
            this.txtUpdatePhoneNumber.Size = new System.Drawing.Size(172, 20);
            this.txtUpdatePhoneNumber.TabIndex = 2;
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateEmail.Location = new System.Drawing.Point(125, 138);
            this.txtUpdateEmail.MaxLength = 50;
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(214, 20);
            this.txtUpdateEmail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(345, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Explanation :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Country :";
            this.label6.Click += new System.EventHandler(this.label7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(38, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "City : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(345, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Hes Code :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(38, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "County :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(349, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Addresss :";
            // 
            // registrationGroupBox
            // 
            this.registrationGroupBox.Controls.Add(this.label14);
            this.registrationGroupBox.Controls.Add(this.label13);
            this.registrationGroupBox.Controls.Add(this.label12);
            this.registrationGroupBox.Controls.Add(this.txtAddExplanation);
            this.registrationGroupBox.Controls.Add(this.txtAddHesCode);
            this.registrationGroupBox.Controls.Add(this.txtAddAddress);
            this.registrationGroupBox.Controls.Add(this.txtAddCounty);
            this.registrationGroupBox.Controls.Add(this.txtAddCity);
            this.registrationGroupBox.Controls.Add(this.txtAddCountry);
            this.registrationGroupBox.Controls.Add(this.txtAddEmail);
            this.registrationGroupBox.Controls.Add(this.txtAddPhoneNumber);
            this.registrationGroupBox.Controls.Add(this.txtAddSurname);
            this.registrationGroupBox.Controls.Add(this.txtAddName);
            this.registrationGroupBox.Controls.Add(this.addButton);
            this.registrationGroupBox.Controls.Add(this.countryLabel);
            this.registrationGroupBox.Controls.Add(this.countyLabel);
            this.registrationGroupBox.Controls.Add(this.explanationLabel);
            this.registrationGroupBox.Controls.Add(this.hesCodelabel);
            this.registrationGroupBox.Controls.Add(this.addressLabel);
            this.registrationGroupBox.Controls.Add(this.cityLabel);
            this.registrationGroupBox.Controls.Add(this.emailLabel);
            this.registrationGroupBox.Controls.Add(this.phoneNumberLabel);
            this.registrationGroupBox.Controls.Add(this.customerSurnameLabel);
            this.registrationGroupBox.Controls.Add(this.customerNameLabel);
            this.registrationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registrationGroupBox.Location = new System.Drawing.Point(12, 364);
            this.registrationGroupBox.Name = "registrationGroupBox";
            this.registrationGroupBox.Size = new System.Drawing.Size(429, 347);
            this.registrationGroupBox.TabIndex = 5;
            this.registrationGroupBox.TabStop = false;
            this.registrationGroupBox.Text = "Registration";
            this.registrationGroupBox.Enter += new System.EventHandler(this.registrationGroupBox_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(104, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "*";
            this.label14.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(104, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "*";
            this.label13.Click += new System.EventHandler(this.label12_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(104, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "*";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtAddExplanation
            // 
            this.txtAddExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddExplanation.Location = new System.Drawing.Point(72, 291);
            this.txtAddExplanation.MaxLength = 100;
            this.txtAddExplanation.Multiline = true;
            this.txtAddExplanation.Name = "txtAddExplanation";
            this.txtAddExplanation.Size = new System.Drawing.Size(172, 47);
            this.txtAddExplanation.TabIndex = 2;
            // 
            // txtAddHesCode
            // 
            this.txtAddHesCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddHesCode.Location = new System.Drawing.Point(263, 194);
            this.txtAddHesCode.MaxLength = 10;
            this.txtAddHesCode.Name = "txtAddHesCode";
            this.txtAddHesCode.Size = new System.Drawing.Size(150, 20);
            this.txtAddHesCode.TabIndex = 2;
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddAddress.Location = new System.Drawing.Point(72, 239);
            this.txtAddAddress.MaxLength = 50;
            this.txtAddAddress.Multiline = true;
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(172, 39);
            this.txtAddAddress.TabIndex = 2;
            // 
            // txtAddCounty
            // 
            this.txtAddCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddCounty.Location = new System.Drawing.Point(72, 194);
            this.txtAddCounty.MaxLength = 20;
            this.txtAddCounty.Name = "txtAddCounty";
            this.txtAddCounty.Size = new System.Drawing.Size(119, 20);
            this.txtAddCounty.TabIndex = 2;
            // 
            // txtAddCity
            // 
            this.txtAddCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddCity.Location = new System.Drawing.Point(263, 155);
            this.txtAddCity.MaxLength = 20;
            this.txtAddCity.Name = "txtAddCity";
            this.txtAddCity.Size = new System.Drawing.Size(150, 20);
            this.txtAddCity.TabIndex = 2;
            // 
            // txtAddCountry
            // 
            this.txtAddCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddCountry.Location = new System.Drawing.Point(72, 155);
            this.txtAddCountry.MaxLength = 20;
            this.txtAddCountry.Name = "txtAddCountry";
            this.txtAddCountry.Size = new System.Drawing.Size(119, 20);
            this.txtAddCountry.TabIndex = 2;
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddEmail.Location = new System.Drawing.Point(72, 125);
            this.txtAddEmail.MaxLength = 50;
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(225, 20);
            this.txtAddEmail.TabIndex = 2;
            // 
            // txtAddPhoneNumber
            // 
            this.txtAddPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddPhoneNumber.Location = new System.Drawing.Point(125, 92);
            this.txtAddPhoneNumber.MaxLength = 10;
            this.txtAddPhoneNumber.Name = "txtAddPhoneNumber";
            this.txtAddPhoneNumber.Size = new System.Drawing.Size(172, 20);
            this.txtAddPhoneNumber.TabIndex = 2;
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddSurname.Location = new System.Drawing.Point(125, 58);
            this.txtAddSurname.MaxLength = 50;
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(172, 20);
            this.txtAddSurname.TabIndex = 2;
            // 
            // txtAddName
            // 
            this.txtAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddName.Location = new System.Drawing.Point(125, 27);
            this.txtAddName.MaxLength = 50;
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(172, 20);
            this.txtAddName.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addButton.Location = new System.Drawing.Point(282, 261);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(98, 62);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Client";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countryLabel.Location = new System.Drawing.Point(6, 158);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(49, 13);
            this.countryLabel.TabIndex = 0;
            this.countryLabel.Text = "Country :";
            this.countryLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // countyLabel
            // 
            this.countyLabel.AutoSize = true;
            this.countyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countyLabel.Location = new System.Drawing.Point(6, 197);
            this.countyLabel.Name = "countyLabel";
            this.countyLabel.Size = new System.Drawing.Size(46, 13);
            this.countyLabel.TabIndex = 0;
            this.countyLabel.Text = "County :";
            // 
            // explanationLabel
            // 
            this.explanationLabel.AutoSize = true;
            this.explanationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.explanationLabel.Location = new System.Drawing.Point(6, 294);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(68, 13);
            this.explanationLabel.TabIndex = 0;
            this.explanationLabel.Text = "Explanation :";
            // 
            // hesCodelabel
            // 
            this.hesCodelabel.AutoSize = true;
            this.hesCodelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesCodelabel.Location = new System.Drawing.Point(197, 197);
            this.hesCodelabel.Name = "hesCodelabel";
            this.hesCodelabel.Size = new System.Drawing.Size(60, 13);
            this.hesCodelabel.TabIndex = 0;
            this.hesCodelabel.Text = "Hes Code :";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addressLabel.Location = new System.Drawing.Point(6, 247);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(56, 13);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Addresss :";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cityLabel.Location = new System.Drawing.Point(198, 158);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(33, 13);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "City : ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailLabel.Location = new System.Drawing.Point(6, 128);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email :";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(6, 95);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.phoneNumberLabel.TabIndex = 0;
            this.phoneNumberLabel.Text = "Phone Number :";
            // 
            // customerSurnameLabel
            // 
            this.customerSurnameLabel.AutoSize = true;
            this.customerSurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerSurnameLabel.Location = new System.Drawing.Point(6, 61);
            this.customerSurnameLabel.Name = "customerSurnameLabel";
            this.customerSurnameLabel.Size = new System.Drawing.Size(102, 13);
            this.customerSurnameLabel.TabIndex = 0;
            this.customerSurnameLabel.Text = "Customer Surname :";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerNameLabel.Location = new System.Drawing.Point(6, 30);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(88, 13);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name :";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(994, 403);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(103, 43);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1061, 376);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Location = new System.Drawing.Point(3, 48);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.ReadOnly = true;
            this.clientsDataGridView.Size = new System.Drawing.Size(1144, 310);
            this.clientsDataGridView.TabIndex = 1;
            this.clientsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsDataGridView_CellClick);
            this.clientsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsDataGridView_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 42);
            this.panel2.TabIndex = 0;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(991, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(52, 13);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "labelTime";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(493, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTS";
            // 
            // txtClientSearch
            // 
            this.txtClientSearch.ForeColor = System.Drawing.Color.LightGray;
            this.txtClientSearch.Location = new System.Drawing.Point(952, 378);
            this.txtClientSearch.MaxLength = 50;
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.Size = new System.Drawing.Size(103, 20);
            this.txtClientSearch.TabIndex = 2;
            this.txtClientSearch.Text = "Client Name";
            this.txtClientSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 714);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClients";
            this.Load += new System.EventHandler(this.FormClients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.removeClientGroupBox.ResumeLayout(false);
            this.removeClientGroupBox.PerformLayout();
            this.updateGroupBox.ResumeLayout(false);
            this.updateGroupBox.PerformLayout();
            this.registrationGroupBox.ResumeLayout(false);
            this.registrationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox txtClientSearch;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox removeClientGroupBox;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.GroupBox updateGroupBox;
        private System.Windows.Forms.GroupBox registrationGroupBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label customerSurnameLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label countyLabel;
        private System.Windows.Forms.Label hesCodelabel;
        private System.Windows.Forms.Label explanationLabel;
        private System.Windows.Forms.TextBox txtAddExplanation;
        private System.Windows.Forms.TextBox txtAddHesCode;
        private System.Windows.Forms.TextBox txtAddAddress;
        private System.Windows.Forms.TextBox txtAddCounty;
        private System.Windows.Forms.TextBox txtAddCity;
        private System.Windows.Forms.TextBox txtAddCountry;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddPhoneNumber;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox txtUpdateExplanation;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpdateHesCode;
        private System.Windows.Forms.TextBox txtUpdateCustomerName;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateCounty;
        private System.Windows.Forms.TextBox txtUpdateCustomerSurname;
        private System.Windows.Forms.TextBox txtUpdateCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdateCountry;
        private System.Windows.Forms.TextBox txtUpdatePhoneNumber;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDeleteCustomerID;
    }
}