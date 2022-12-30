using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalApp
{
    public partial class CreateNewTreatment : Form
    {
        Form1 form1;
        String patient_id = null;
        String patient_name = null;
        DbHelper dbHelper;
        public CreateNewTreatment(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void CreateNewTreatment_Load(object sender, EventArgs e)
        {
            dbHelper = new DbHelper();
            dataGridViewPatients.DataSource = dbHelper.GetData("SELECT patient_id as 'ID',patient_name as 'Name',patient_surname as 'Surname',patient_age as 'Age',tcNo as 'T.C. Number',patient_phone as 'Phone' FROM Patient");
            clearAllTextBoxes();
        }

        private void clearAllTextBoxes()
        {
            tbxComplaints.Clear();
            tbxSelectdPatientId.Clear();
            tbxSelectedPatientName.Clear();
            tbxTreatmentInfo.Clear();
            tbxTreatmentNotes.Clear();
            tbxEstimatedFee.Clear();
        }

        private void tbxEstimatedFee_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbxEstimatedFee.Text, "[^0-9]"))
            {
                MessageBox.Show("Insert Numbers Only for Estimated Fee!");
                tbxEstimatedFee.Clear();
            }
        }

        private bool CheckTextBoxes()
        {
            if (tbxSelectdPatientId.Text == "" || tbxSelectedPatientName.Text == "" || tbxComplaints.Text == "")
            {
                MessageBox.Show("Please select a patient before creating treatment! and write complaints.");
                return false;
            }
            else if(tbxEstimatedFee.Text == "" || comboBoxMoneyUnit.Text == "")
            {
                MessageBox.Show("Please select a money unit!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCreateTreatment_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {

                int rowAffected = 0;
                rowAffected = dbHelper.SetData("INSERT INTO Treatment (treatment_info,patient_id,application_date,complaints,treatment_notes,estimated_fee,moneyUnit,isTreatmentCompleted) VALUES ('"+tbxTreatmentInfo.Text+"','"+ tbxSelectdPatientId.Text + "',GETDATE(),'"+ tbxComplaints.Text + "','"+ tbxTreatmentNotes.Text + "','"+ tbxEstimatedFee.Text + "','" + comboBoxMoneyUnit.Text +"',0);");
                if (rowAffected != 0)
                {
                    MessageBox.Show("Treatment Created! Please refresh the tables.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something gone wrong in our sides.");
                }

            }
        }

        private void dataGridViewPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Herhangi bir hastaya tıklanırsa o hastaya yeni bir tedavi açıalcak şekilde verileri oraya gitmeli! */

            String selected_patient_id = null;
            String selected_patient_name = null;
            try
            {
                DataGridViewRow row = dataGridViewPatients.Rows[e.RowIndex];

                selected_patient_id = row.Cells["ID"].Value.ToString();
                selected_patient_name = row.Cells["Name"].Value.ToString();
                selected_patient_name += " " + row.Cells["Surname"].Value.ToString();

                if (selected_patient_id != patient_id)
                {
                    clearAllTextBoxes();
                    patient_id = selected_patient_id;
                    patient_name = selected_patient_name;
                }
                else
                {
                    patient_id = selected_patient_id;
                    patient_name = selected_patient_name;
                }
            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("Click on the patient you want to add treatment of.");
            }

            if (patient_id != null)
            {
                tbxSelectdPatientId.Text = patient_id;
                tbxSelectedPatientName.Text = patient_name;
            }
        }

        private void comboBoxMoneyUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refreshMain()
        {
            form1.RefreshTables();
        }
        private void CreateNewTreatment_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshMain();
        }
    }
}
