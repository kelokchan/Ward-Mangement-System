using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nSaveButton = new System.Windows.Forms.Button();
            this.nDeleteButton = new System.Windows.Forms.Button();
            this.nurseDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nAddButton = new System.Windows.Forms.Button();
            this.nDateBox = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nRankBox = new System.Windows.Forms.ComboBox();
            this.nGenderBox = new System.Windows.Forms.ComboBox();
            this.nAddressBox = new System.Windows.Forms.TextBox();
            this.nEmailBox = new System.Windows.Forms.TextBox();
            this.nPhoneBox = new System.Windows.Forms.TextBox();
            this.nNameBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.pSearchBox = new System.Windows.Forms.TextBox();
            this.pSearchButton = new System.Windows.Forms.Button();
            this.pSaveButton = new System.Windows.Forms.Button();
            this.pDischargeButton = new System.Windows.Forms.Button();
            this.pDeleteButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.c_patientDataGrid = new System.Windows.Forms.DataGridView();
            this.patientDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pGenderBox = new System.Windows.Forms.ComboBox();
            this.critPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pSlider = new System.Windows.Forms.TrackBar();
            this.pShareCheckBox = new System.Windows.Forms.CheckBox();
            this.pCritCheckBox = new System.Windows.Forms.CheckBox();
            this.pAddButton = new System.Windows.Forms.Button();
            this.pDateBox = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pAddressBox = new System.Windows.Forms.TextBox();
            this.pEmailBox = new System.Windows.Forms.TextBox();
            this.pPhoneBox = new System.Windows.Forms.TextBox();
            this.pNameBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.nurseWardBox2 = new System.Windows.Forms.ListBox();
            this.c_patientWardBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.nurseWardBox = new System.Windows.Forms.ListBox();
            this.patientWardBox = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.daylabel = new System.Windows.Forms.Label();
            this.pDayBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nurseDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_patientDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.critPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSlider)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1279, 640);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.Controls.Add(this.nSaveButton);
            this.tabPage1.Controls.Add(this.nDeleteButton);
            this.tabPage1.Controls.Add(this.nurseDataGrid);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1271, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nurse";
            // 
            // nSaveButton
            // 
            this.nSaveButton.Location = new System.Drawing.Point(702, 505);
            this.nSaveButton.Name = "nSaveButton";
            this.nSaveButton.Size = new System.Drawing.Size(75, 37);
            this.nSaveButton.TabIndex = 18;
            this.nSaveButton.Text = "Save record";
            this.nSaveButton.UseVisualStyleBackColor = true;
            this.nSaveButton.Click += new System.EventHandler(this.nSaveButton_Click);
            // 
            // nDeleteButton
            // 
            this.nDeleteButton.Location = new System.Drawing.Point(621, 505);
            this.nDeleteButton.Name = "nDeleteButton";
            this.nDeleteButton.Size = new System.Drawing.Size(75, 37);
            this.nDeleteButton.TabIndex = 17;
            this.nDeleteButton.Text = "Delete nurse";
            this.nDeleteButton.UseVisualStyleBackColor = true;
            this.nDeleteButton.Click += new System.EventHandler(this.nDeleteButton_Click);
            // 
            // nurseDataGrid
            // 
            this.nurseDataGrid.AllowUserToAddRows = false;
            this.nurseDataGrid.AllowUserToDeleteRows = false;
            this.nurseDataGrid.AllowUserToOrderColumns = true;
            this.nurseDataGrid.AllowUserToResizeRows = false;
            this.nurseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nurseDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.nurseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nurseDataGrid.GridColor = System.Drawing.Color.White;
            this.nurseDataGrid.Location = new System.Drawing.Point(358, 25);
            this.nurseDataGrid.Name = "nurseDataGrid";
            this.nurseDataGrid.RowHeadersVisible = false;
            this.nurseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nurseDataGrid.Size = new System.Drawing.Size(715, 448);
            this.nurseDataGrid.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nAddButton);
            this.groupBox1.Controls.Add(this.nDateBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nRankBox);
            this.groupBox1.Controls.Add(this.nGenderBox);
            this.groupBox1.Controls.Add(this.nAddressBox);
            this.groupBox1.Controls.Add(this.nEmailBox);
            this.groupBox1.Controls.Add(this.nPhoneBox);
            this.groupBox1.Controls.Add(this.nNameBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // nAddButton
            // 
            this.nAddButton.Location = new System.Drawing.Point(54, 417);
            this.nAddButton.Name = "nAddButton";
            this.nAddButton.Size = new System.Drawing.Size(75, 23);
            this.nAddButton.TabIndex = 7;
            this.nAddButton.Text = "Add";
            this.nAddButton.UseVisualStyleBackColor = true;
            this.nAddButton.Click += new System.EventHandler(this.nAddButton_Click);
            // 
            // nDateBox
            // 
            this.nDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nDateBox.Location = new System.Drawing.Point(116, 134);
            this.nDateBox.Name = "nDateBox";
            this.nDateBox.Size = new System.Drawing.Size(150, 20);
            this.nDateBox.TabIndex = 2;
            this.nDateBox.Value = new System.DateTime(1995, 6, 22, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Rank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone no.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date of birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // nRankBox
            // 
            this.nRankBox.BackColor = System.Drawing.Color.White;
            this.nRankBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nRankBox.FormattingEnabled = true;
            this.nRankBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.nRankBox.Location = new System.Drawing.Point(116, 287);
            this.nRankBox.Name = "nRankBox";
            this.nRankBox.Size = new System.Drawing.Size(150, 21);
            this.nRankBox.TabIndex = 6;
            // 
            // nGenderBox
            // 
            this.nGenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nGenderBox.FormattingEnabled = true;
            this.nGenderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.nGenderBox.Location = new System.Drawing.Point(116, 89);
            this.nGenderBox.Name = "nGenderBox";
            this.nGenderBox.Size = new System.Drawing.Size(150, 21);
            this.nGenderBox.TabIndex = 1;
            // 
            // nAddressBox
            // 
            this.nAddressBox.Location = new System.Drawing.Point(116, 246);
            this.nAddressBox.Name = "nAddressBox";
            this.nAddressBox.Size = new System.Drawing.Size(150, 20);
            this.nAddressBox.TabIndex = 5;
            // 
            // nEmailBox
            // 
            this.nEmailBox.Location = new System.Drawing.Point(116, 209);
            this.nEmailBox.Name = "nEmailBox";
            this.nEmailBox.Size = new System.Drawing.Size(150, 20);
            this.nEmailBox.TabIndex = 4;
            // 
            // nPhoneBox
            // 
            this.nPhoneBox.Location = new System.Drawing.Point(116, 171);
            this.nPhoneBox.Name = "nPhoneBox";
            this.nPhoneBox.Size = new System.Drawing.Size(150, 20);
            this.nPhoneBox.TabIndex = 3;
            // 
            // nNameBox
            // 
            this.nNameBox.Location = new System.Drawing.Point(116, 50);
            this.nNameBox.Name = "nNameBox";
            this.nNameBox.Size = new System.Drawing.Size(150, 20);
            this.nNameBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.pSearchBox);
            this.tabPage2.Controls.Add(this.pSearchButton);
            this.tabPage2.Controls.Add(this.pSaveButton);
            this.tabPage2.Controls.Add(this.pDischargeButton);
            this.tabPage2.Controls.Add(this.pDeleteButton);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.c_patientDataGrid);
            this.tabPage2.Controls.Add(this.patientDataGrid);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1271, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patient";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(712, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Search for patient ID here:";
            // 
            // pSearchBox
            // 
            this.pSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pSearchBox.Location = new System.Drawing.Point(847, 8);
            this.pSearchBox.Name = "pSearchBox";
            this.pSearchBox.Size = new System.Drawing.Size(145, 20);
            this.pSearchBox.TabIndex = 22;
            // 
            // pSearchButton
            // 
            this.pSearchButton.Location = new System.Drawing.Point(998, 6);
            this.pSearchButton.Name = "pSearchButton";
            this.pSearchButton.Size = new System.Drawing.Size(75, 23);
            this.pSearchButton.TabIndex = 21;
            this.pSearchButton.Text = "Search";
            this.pSearchButton.UseVisualStyleBackColor = true;
            this.pSearchButton.Click += new System.EventHandler(this.pSearchButton_Click);
            // 
            // pSaveButton
            // 
            this.pSaveButton.Location = new System.Drawing.Point(783, 505);
            this.pSaveButton.Name = "pSaveButton";
            this.pSaveButton.Size = new System.Drawing.Size(75, 37);
            this.pSaveButton.TabIndex = 8;
            this.pSaveButton.Text = "Save record";
            this.pSaveButton.UseVisualStyleBackColor = true;
            this.pSaveButton.Click += new System.EventHandler(this.pSaveButton_Click);
            // 
            // pDischargeButton
            // 
            this.pDischargeButton.Location = new System.Drawing.Point(702, 505);
            this.pDischargeButton.Name = "pDischargeButton";
            this.pDischargeButton.Size = new System.Drawing.Size(75, 37);
            this.pDischargeButton.TabIndex = 7;
            this.pDischargeButton.Text = "Discharge patient";
            this.pDischargeButton.UseVisualStyleBackColor = true;
            this.pDischargeButton.Click += new System.EventHandler(this.pDischargeButton_Click);
            // 
            // pDeleteButton
            // 
            this.pDeleteButton.Location = new System.Drawing.Point(621, 505);
            this.pDeleteButton.Name = "pDeleteButton";
            this.pDeleteButton.Size = new System.Drawing.Size(75, 37);
            this.pDeleteButton.TabIndex = 6;
            this.pDeleteButton.Text = "Delete patient";
            this.pDeleteButton.UseVisualStyleBackColor = true;
            this.pDeleteButton.Click += new System.EventHandler(this.pDeleteButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(358, 264);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Critical patient";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(358, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Patient";
            // 
            // c_patientDataGrid
            // 
            this.c_patientDataGrid.AllowUserToAddRows = false;
            this.c_patientDataGrid.AllowUserToDeleteRows = false;
            this.c_patientDataGrid.AllowUserToOrderColumns = true;
            this.c_patientDataGrid.AllowUserToResizeRows = false;
            this.c_patientDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.c_patientDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.c_patientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.c_patientDataGrid.GridColor = System.Drawing.Color.White;
            this.c_patientDataGrid.Location = new System.Drawing.Point(361, 280);
            this.c_patientDataGrid.Name = "c_patientDataGrid";
            this.c_patientDataGrid.RowHeadersVisible = false;
            this.c_patientDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.c_patientDataGrid.Size = new System.Drawing.Size(712, 219);
            this.c_patientDataGrid.TabIndex = 3;
            this.c_patientDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.c_patientDataGrid_CellClick);
            // 
            // patientDataGrid
            // 
            this.patientDataGrid.AllowUserToAddRows = false;
            this.patientDataGrid.AllowUserToDeleteRows = false;
            this.patientDataGrid.AllowUserToOrderColumns = true;
            this.patientDataGrid.AllowUserToResizeRows = false;
            this.patientDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.patientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGrid.GridColor = System.Drawing.Color.White;
            this.patientDataGrid.Location = new System.Drawing.Point(361, 35);
            this.patientDataGrid.Name = "patientDataGrid";
            this.patientDataGrid.RowHeadersVisible = false;
            this.patientDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientDataGrid.Size = new System.Drawing.Size(712, 219);
            this.patientDataGrid.TabIndex = 2;
            this.patientDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientDataGrid_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.daylabel);
            this.groupBox2.Controls.Add(this.pDayBox);
            this.groupBox2.Controls.Add(this.pGenderBox);
            this.groupBox2.Controls.Add(this.critPanel);
            this.groupBox2.Controls.Add(this.pCritCheckBox);
            this.groupBox2.Controls.Add(this.pAddButton);
            this.groupBox2.Controls.Add(this.pDateBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.pAddressBox);
            this.groupBox2.Controls.Add(this.pEmailBox);
            this.groupBox2.Controls.Add(this.pPhoneBox);
            this.groupBox2.Controls.Add(this.pNameBox);
            this.groupBox2.Location = new System.Drawing.Point(16, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 480);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // pGenderBox
            // 
            this.pGenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pGenderBox.FormattingEnabled = true;
            this.pGenderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.pGenderBox.Location = new System.Drawing.Point(163, 84);
            this.pGenderBox.Name = "pGenderBox";
            this.pGenderBox.Size = new System.Drawing.Size(150, 21);
            this.pGenderBox.TabIndex = 1;
            // 
            // critPanel
            // 
            this.critPanel.Controls.Add(this.label15);
            this.critPanel.Controls.Add(this.label7);
            this.critPanel.Controls.Add(this.pSlider);
            this.critPanel.Controls.Add(this.pShareCheckBox);
            this.critPanel.Location = new System.Drawing.Point(26, 335);
            this.critPanel.Name = "critPanel";
            this.critPanel.Size = new System.Drawing.Size(287, 82);
            this.critPanel.TabIndex = 23;
            this.critPanel.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Illness level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "1";
            // 
            // pSlider
            // 
            this.pSlider.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pSlider.LargeChange = 1;
            this.pSlider.Location = new System.Drawing.Point(3, 23);
            this.pSlider.Maximum = 3;
            this.pSlider.Minimum = 1;
            this.pSlider.Name = "pSlider";
            this.pSlider.Size = new System.Drawing.Size(104, 45);
            this.pSlider.TabIndex = 0;
            this.pSlider.Value = 1;
            this.pSlider.Scroll += new System.EventHandler(this.pSlider_Scroll);
            // 
            // pShareCheckBox
            // 
            this.pShareCheckBox.AutoSize = true;
            this.pShareCheckBox.Location = new System.Drawing.Point(143, 26);
            this.pShareCheckBox.Name = "pShareCheckBox";
            this.pShareCheckBox.Size = new System.Drawing.Size(127, 17);
            this.pShareCheckBox.TabIndex = 1;
            this.pShareCheckBox.Text = "Unable to share ward";
            this.pShareCheckBox.UseVisualStyleBackColor = true;
            // 
            // pCritCheckBox
            // 
            this.pCritCheckBox.AutoSize = true;
            this.pCritCheckBox.Location = new System.Drawing.Point(37, 312);
            this.pCritCheckBox.Name = "pCritCheckBox";
            this.pCritCheckBox.Size = new System.Drawing.Size(98, 17);
            this.pCritCheckBox.TabIndex = 6;
            this.pCritCheckBox.Text = "Critical patient?";
            this.pCritCheckBox.UseVisualStyleBackColor = true;
            this.pCritCheckBox.CheckedChanged += new System.EventHandler(this.pCritCheckBox_CheckedChanged);
            // 
            // pAddButton
            // 
            this.pAddButton.Location = new System.Drawing.Point(54, 447);
            this.pAddButton.Name = "pAddButton";
            this.pAddButton.Size = new System.Drawing.Size(75, 23);
            this.pAddButton.TabIndex = 7;
            this.pAddButton.Text = "Add";
            this.pAddButton.UseVisualStyleBackColor = true;
            this.pAddButton.Click += new System.EventHandler(this.pAddButton_Click);
            // 
            // pDateBox
            // 
            this.pDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pDateBox.Location = new System.Drawing.Point(163, 129);
            this.pDateBox.Name = "pDateBox";
            this.pDateBox.Size = new System.Drawing.Size(150, 20);
            this.pDateBox.TabIndex = 2;
            this.pDateBox.Value = new System.DateTime(1995, 6, 22, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Phone no.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Date of birth";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Gender";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Name";
            // 
            // pAddressBox
            // 
            this.pAddressBox.Location = new System.Drawing.Point(163, 241);
            this.pAddressBox.Name = "pAddressBox";
            this.pAddressBox.Size = new System.Drawing.Size(150, 20);
            this.pAddressBox.TabIndex = 5;
            // 
            // pEmailBox
            // 
            this.pEmailBox.Location = new System.Drawing.Point(163, 204);
            this.pEmailBox.Name = "pEmailBox";
            this.pEmailBox.Size = new System.Drawing.Size(150, 20);
            this.pEmailBox.TabIndex = 4;
            // 
            // pPhoneBox
            // 
            this.pPhoneBox.Location = new System.Drawing.Point(163, 166);
            this.pPhoneBox.Name = "pPhoneBox";
            this.pPhoneBox.Size = new System.Drawing.Size(150, 20);
            this.pPhoneBox.TabIndex = 3;
            // 
            // pNameBox
            // 
            this.pNameBox.Location = new System.Drawing.Point(163, 45);
            this.pNameBox.Name = "pNameBox";
            this.pNameBox.Size = new System.Drawing.Size(150, 20);
            this.pNameBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1271, 614);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ward";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.nurseWardBox2);
            this.groupBox4.Controls.Add(this.c_patientWardBox);
            this.groupBox4.Location = new System.Drawing.Point(586, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 445);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Critical Patient Ward";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 312);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "Nurse in charge: ";
            // 
            // nurseWardBox2
            // 
            this.nurseWardBox2.FormattingEnabled = true;
            this.nurseWardBox2.Location = new System.Drawing.Point(21, 328);
            this.nurseWardBox2.Name = "nurseWardBox2";
            this.nurseWardBox2.Size = new System.Drawing.Size(378, 95);
            this.nurseWardBox2.TabIndex = 13;
            // 
            // c_patientWardBox
            // 
            this.c_patientWardBox.FormattingEnabled = true;
            this.c_patientWardBox.Location = new System.Drawing.Point(21, 40);
            this.c_patientWardBox.Name = "c_patientWardBox";
            this.c_patientWardBox.Size = new System.Drawing.Size(378, 251);
            this.c_patientWardBox.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.nurseWardBox);
            this.groupBox3.Controls.Add(this.patientWardBox);
            this.groupBox3.Location = new System.Drawing.Point(83, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 445);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Patient Ward";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 312);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "Nurse in charge: ";
            // 
            // nurseWardBox
            // 
            this.nurseWardBox.FormattingEnabled = true;
            this.nurseWardBox.Location = new System.Drawing.Point(21, 328);
            this.nurseWardBox.Name = "nurseWardBox";
            this.nurseWardBox.Size = new System.Drawing.Size(378, 95);
            this.nurseWardBox.TabIndex = 12;
            // 
            // patientWardBox
            // 
            this.patientWardBox.FormattingEnabled = true;
            this.patientWardBox.Location = new System.Drawing.Point(21, 40);
            this.patientWardBox.Name = "patientWardBox";
            this.patientWardBox.Size = new System.Drawing.Size(378, 251);
            this.patientWardBox.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // daylabel
            // 
            this.daylabel.AutoSize = true;
            this.daylabel.Location = new System.Drawing.Point(34, 278);
            this.daylabel.Name = "daylabel";
            this.daylabel.Size = new System.Drawing.Size(116, 13);
            this.daylabel.TabIndex = 25;
            this.daylabel.Text = "Days to be hospitalized";
            // 
            // pDayBox
            // 
            this.pDayBox.Location = new System.Drawing.Point(163, 278);
            this.pDayBox.Name = "pDayBox";
            this.pDayBox.Size = new System.Drawing.Size(150, 20);
            this.pDayBox.TabIndex = 24;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 589);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Ward Management System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nurseDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_patientDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.critPanel.ResumeLayout(false);
            this.critPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSlider)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nRankBox;
        private System.Windows.Forms.ComboBox nGenderBox;
        private System.Windows.Forms.TextBox nAddressBox;
        private System.Windows.Forms.TextBox nEmailBox;
        private System.Windows.Forms.TextBox nPhoneBox;
        private System.Windows.Forms.TextBox nNameBox;
        private System.Windows.Forms.Button nAddButton;
        private System.Windows.Forms.DateTimePicker nDateBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar pSlider;
        private System.Windows.Forms.CheckBox pShareCheckBox;
        private System.Windows.Forms.CheckBox pCritCheckBox;
        private System.Windows.Forms.Button pAddButton;
        private System.Windows.Forms.DateTimePicker pDateBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox pAddressBox;
        private System.Windows.Forms.TextBox pEmailBox;
        private System.Windows.Forms.TextBox pPhoneBox;
        private System.Windows.Forms.TextBox pNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel critPanel;
        private System.Windows.Forms.ComboBox pGenderBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView patientDataGrid;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView c_patientDataGrid;
        private System.Windows.Forms.DataGridView nurseDataGrid;
        private System.Windows.Forms.Button nDeleteButton;
        private System.Windows.Forms.Button pDeleteButton;
        private System.Windows.Forms.Button pDischargeButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button nSaveButton;
        private System.Windows.Forms.Button pSaveButton;
        private TextBox pSearchBox;
        private Button pSearchButton;
        private Label label18;
        private GroupBox groupBox3;
        private Label label21;
        private ListBox nurseWardBox;
        private ListBox patientWardBox;
        private GroupBox groupBox4;
        private Label label22;
        private ListBox nurseWardBox2;
        private ListBox c_patientWardBox;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Label daylabel;
        private TextBox pDayBox;

    }
}

