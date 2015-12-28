using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    /* This is the Driver class for the Ward Management System. 
       all the methods and handlers necessary to use the classes are defined here */
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Lists to holds properties of each classes
        public static List<Nurse> nurseList = new List<Nurse>();
        public static List<Patient> patientList = new List<Patient>();
        public static List<Critical_patient> c_patientList = new List<Critical_patient>();

        public void addNurse(Nurse nurseOb)
        {
            int n_count;
            string n_id = "";
            try
            {
                n_count = nurseOb.getID(nurseDataGrid);
                if (n_count < 10)
                {
                    n_id = "N000";
                }
                else if (n_count < 100)
                {
                    n_id = "N00";
                }
                else
                {
                    n_id = "N0";
                }
                nurseOb.Name = nNameBox.Text;
                nurseOb.Gender = (nGenderBox.SelectedIndex == 0) ? "Male" : "Female";
                nurseOb.DateOfBirth = Convert.ToDateTime(nDateBox.Text);
                nurseOb.ID = n_id + n_count;
                nurseOb.Email = nEmailBox.Text;
                nurseOb.Address = nAddressBox.Text;
                nurseOb.PhoneNo = nPhoneBox.Text;
                nurseOb.Rank = Convert.ToInt16(nRankBox.Text);
                nurseList.Add(nurseOb);
                BindingList<Nurse> binded_Nurse = new BindingList<Nurse>(nurseList);
                nurseDataGrid.DataSource = binded_Nurse;
                nurseDataGrid.CurrentCell = nurseDataGrid.Rows[nurseDataGrid.Rows.Count - 1].Cells[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //addPatient method -> method Overloading
        public void addPatient(Patient patientOb)
        {
            int p_count;
            string p_id = "";
            try
            {
                p_count = patientOb.getID(patientDataGrid);

                if (p_count < 10)
                {
                    p_id = "P000";
                }
                else if (p_count < 100)
                {
                    p_id = "P00";
                }
                else
                {
                    p_id = "P0";
                }

                patientOb.Name = pNameBox.Text;
                patientOb.Gender = (pGenderBox.SelectedIndex == 0) ? "Male" : "Female";
                patientOb.DateOfBirth = Convert.ToDateTime(pDateBox.Text);
                patientOb.ID = p_id + p_count;
                patientOb.Email = pEmailBox.Text;
                patientOb.Address = pAddressBox.Text;
                patientOb.PhoneNo = pPhoneBox.Text;
                patientOb.dayHospitalized = Convert.ToInt32(pDayBox.Text);
                patientOb.Discharged = false;
                patientList.Add(patientOb);
                BindingList<Patient> binded_Patient = new BindingList<Patient>(patientList);
                patientDataGrid.DataSource = binded_Patient;
                patientDataGrid.CurrentCell = patientDataGrid.Rows[patientDataGrid.Rows.Count - 1].Cells[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addPatient(Critical_patient c_patientOb)
        {
            int c_p_count;
            string c_p_id = "";
            try
            {
                c_p_count = c_patientOb.getID(c_patientDataGrid);

                if (c_p_count < 10)
                {
                    c_p_id = "CP000";
                }
                else if (c_p_count < 100)
                {
                    c_p_id = "CP00";
                }
                else
                {
                    c_p_id = "CP0";
                }

                c_patientOb.Name = pNameBox.Text;
                c_patientOb.Gender = (pGenderBox.SelectedIndex == 0) ? "Male" : "Female";
                c_patientOb.DateOfBirth = Convert.ToDateTime(pDateBox.Text);
                c_patientOb.ID = c_p_id + c_p_count;
                c_patientOb.Email = pEmailBox.Text;
                c_patientOb.Address = pAddressBox.Text;
                c_patientOb.PhoneNo = pPhoneBox.Text;
                c_patientOb.Critical = true;
                c_patientOb.IllnessLevel = Convert.ToInt16(pSlider.Value);
                c_patientOb.ShareWard = (pShareCheckBox.Checked) ? false : true;
                c_patientOb.dayHospitalized = Convert.ToInt32(pDayBox.Text);
                c_patientOb.Discharged = false;
                c_patientList.Add(c_patientOb);
                BindingList<Critical_patient> binded_c_Patient = new BindingList<Critical_patient>(c_patientList);
                c_patientDataGrid.DataSource = binded_c_Patient;
                c_patientDataGrid.CurrentCell = c_patientDataGrid.Rows[c_patientDataGrid.Rows.Count - 1].Cells[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadNurse()
        {
            Nurse nurse = new Nurse();
            nurseList = XML.xmlDeserialize(nurse);
            BindingList<Nurse> binded_Nurse = new BindingList<Nurse>(nurseList);
            nurseDataGrid.DataSource = binded_Nurse;
        }

        public void loadPatient()
        {
            Patient patient = new Patient();
            patientList = XML.xmlDeserialize(patient);
            BindingList<Patient> binded_Patient = new BindingList<Patient>(patientList);
            patientDataGrid.DataSource = binded_Patient;
        }

        public void loadCritPatient()
        {
            Critical_patient cpatient = new Critical_patient();
            c_patientList = XML.xmlDeserialize(cpatient);
            BindingList<Critical_patient> binded_c_Patient = new BindingList<Critical_patient>(c_patientList);
            c_patientDataGrid.DataSource = binded_c_Patient;
        }

        public void loadWard()
        {
            Nurse nurseOb = new Nurse();
            Patient patientOb = new Patient();
            Critical_patient c_patientOb = new Critical_patient();
            Ward wardOb = new Ward();
            wardOb.load_NurseWard(nurseWardBox, nurseOb, nurseList);
            wardOb.load_HighRankNurseWard(nurseWardBox2, nurseOb, nurseList);
            wardOb.load_PatientWard(patientWardBox, patientOb, patientList);
            wardOb.load_CPatientWard(c_patientWardBox, c_patientOb, c_patientList);
        }

        //deleteRow method -> method Overloading
        public void deleteRow(Nurse nurseOb, DataGridView dgv)
        {
            int index = dgv.CurrentCell.RowIndex;
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                dgv.Rows.RemoveAt(row.Index);
            }
        }

        public void deleteRow(Patient patientOb, DataGridView dgv)
        {
            int index = dgv.CurrentCell.RowIndex;
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                dgv.Rows.RemoveAt(row.Index);
            }
        }

        public void deleteRow(Critical_patient c_patientOb, DataGridView dgv)
        {
            int index = dgv.CurrentCell.RowIndex;
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                dgv.Rows.RemoveAt(row.Index);
            }  
        }

        //dischargePatient -> method Overloading
        public void dischargePatient(Patient patientOb, DataGridView patientDataGrid)
        {
            int index = patientDataGrid.CurrentCell.RowIndex;
            patientList[index].Discharged = true;
            for (int i = patientWardBox.Items.Count - 1; i >= 0; --i)
            {
                string name = patientDataGrid.Rows[index].Cells[0].Value.ToString();
                if (patientWardBox.Items[i].ToString().Contains(name))
                {
                    patientWardBox.Items.RemoveAt(i);
                }
            }
        }

        public void dischargePatient(Critical_patient c_patientOb, DataGridView c_patientDataGrid)
        {
            int index = c_patientDataGrid.CurrentCell.RowIndex;
            c_patientList[index].Discharged = true;
            for (int i = c_patientWardBox.Items.Count - 1; i >= 0; --i)
            {
                string name = c_patientDataGrid.Rows[index].Cells[0].Value.ToString();
                if (c_patientWardBox.Items[i].ToString().Contains(name))
                {
                    c_patientWardBox.Items.RemoveAt(i);
                }
            }
        }

        public void searchPatient()
        {
            string searchInput = pSearchBox.Text.ToUpper();
            try
            {
                if (searchInput.StartsWith("P"))
                {
                    var result = patientList.Find(f => f.ID == searchInput);
                    var index = patientList.IndexOf(result);
                    patientDataGrid.CurrentCell = patientDataGrid.Rows[index].Cells[0];
                }
                else if (searchInput.StartsWith("CP"))
                {
                    var result = c_patientList.Find(f => f.ID == searchInput);
                    var index = c_patientList.IndexOf(result);
                    c_patientDataGrid.CurrentCell = c_patientDataGrid.Rows[index].Cells[0];
                }
                else
                {
                    MessageBox.Show("No result");
                }
            }
            catch
            {
                MessageBox.Show("No result");
            }

        }

        private void nAddButton_Click(object sender, EventArgs e)
        {
            Nurse nurseOb = new Nurse();
            Ward wardOb = new Ward();
            addNurse(nurseOb);
        }

        private void pAddButton_Click(object sender, EventArgs e)
        {
            Patient patientOb = new Patient();
            Critical_patient c_patientOb = new Critical_patient();
            if (!pCritCheckBox.Checked)
            {
                addPatient(patientOb);
            }
            else
            {
                addPatient(c_patientOb);
            }
        }

        private void pSlider_Scroll(object sender, EventArgs e)
        {
            label7.Text = pSlider.Value.ToString();
        }

        private void pCritCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pCritCheckBox.Checked)
            {
                critPanel.Visible = true;
            }
            else
            {
                critPanel.Visible = false;
            }
        }

        private void patientDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            c_patientDataGrid.CurrentCell = null;
        }

        private void c_patientDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            patientDataGrid.CurrentCell = null;
        }

        private void pDeleteButton_Click(object sender, EventArgs e)
        {
            if (patientDataGrid.SelectedRows.Count > 0)
            {
                Patient patientOb = new Patient();
                deleteRow(patientOb, patientDataGrid);
            }
            else
            {
                Critical_patient c_patientOb = new Critical_patient();
                deleteRow(c_patientOb, c_patientDataGrid);
            }
        }

        private void nDeleteButton_Click(object sender, EventArgs e)
        {
            Nurse nurseOb = new Nurse();
            deleteRow(nurseOb, nurseDataGrid);
        }

        private void pDischargeButton_Click(object sender, EventArgs e)
        {
            Patient patientOb = new Patient();
            Critical_patient c_patientOb = new Critical_patient();
            if ( patientDataGrid.SelectedRows.Count>0)
            {
                dischargePatient(patientOb, patientDataGrid);
                patientDataGrid.Refresh();
            }
            else if (c_patientDataGrid.SelectedRows.Count > 0)
            {
                dischargePatient(c_patientOb, c_patientDataGrid);
                c_patientDataGrid.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a patient");
            }      
        }

        private void nSaveButton_Click(object sender, EventArgs e)
        {
            XML.xmlSerialize(nurseList, "Nurses.xml");
        }

        private void pSaveButton_Click(object sender, EventArgs e)
        {
            XML.xmlSerialize(patientList, "Patients.xml");
            XML.xmlSerialize(c_patientList, "Critical_patients.xml");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadNurse();
            loadPatient();
            loadCritPatient();
            loadWard();
            nurseDataGrid.ClearSelection();
            //nGenderBox.SelectedIndex = 0;
            //nRankBox.SelectedIndex = 0;
            nNameBox.Select();
        }

        private void pSearchButton_Click(object sender, EventArgs e)
        {
            patientDataGrid.ClearSelection();
            c_patientDataGrid.ClearSelection();
            searchPatient();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            Nurse nurseOb = new Nurse();
            Patient patientOb = new Patient();
            Critical_patient c_patientOb = new Critical_patient();
            Ward wardOb = new Ward();
            switch (tabControl1.SelectedIndex)
            {
                case 0: 
                    nNameBox.Focus();
                    break;

                case 1: 
                    patientDataGrid.ClearSelection();
                    c_patientDataGrid.ClearSelection();
                    pGenderBox.SelectedIndex = 0;
                    pNameBox.Focus();
                    break;

                case 2:
                    nurseWardBox.Items.Clear();
                    nurseWardBox2.Items.Clear();
                    patientWardBox.Items.Clear();
                    c_patientWardBox.Items.Clear();
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                    loadWard();
                    if (((double)(patientWardBox.Items.Count) / 5) > nurseWardBox.Items.Count) //To determine is there is sufficient nurse in ward
                    {
                        errorProvider1.SetError(nurseWardBox, "Insufficient nurse in charge!");
                    }
                    if (c_patientWardBox.Items.Count > nurseWardBox2.Items.Count)
                    {
                        errorProvider2.SetError(nurseWardBox2, "Insufficient high ranked nurse in charge!");
                    }
                    break;
            }
        }


    }
}