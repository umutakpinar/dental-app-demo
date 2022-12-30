using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalApp
{
    public partial class PatientDetails : Form
    {
        Form1 mainForm;
        DbHelper dbHelper;
        String loggedDoctorId = null;
        String patient_id = null;

        public PatientDetails(String loggedDoctorId, Form1 _mainForm)
        {
            this.loggedDoctorId = loggedDoctorId;
            InitializeComponent();
            this.mainForm = _mainForm;
        }

        public PatientDetails(String loggedDoctorId, String _patient_id, Form1 _mainForm)
        {
            this.loggedDoctorId = loggedDoctorId;
            this.patient_id = _patient_id;
            InitializeComponent();
            this.mainForm = _mainForm;
        }

        private void refreshMainForm()
        {
            mainForm.RefreshTables();
        }
        private void PatientDetails_Load(object sender, EventArgs e)
        {
            dbHelper = new DbHelper();
            if (patient_id != null) //demek ki varolan patientı editleyeceğiz
            {
                lblProcess.Text = "Patient " + patient_id;

                ArrayList patientInfo = dbHelper.GetPatientDetails(patient_id);
                
                tbxPatientName.Text = patientInfo[0].ToString();
                tbxPatientSurname.Text = patientInfo[1].ToString();
                tbxPatientAge.Text = patientInfo[2].ToString();
                tbxPatientTcNo.Text = patientInfo[3].ToString();
                tbxPatientPhone.Text = patientInfo[4].ToString();
                tbxBloodgroup.Text = patientInfo[5].ToString();
                tbxNotesAboutPatient.Text = patientInfo[6].ToString();
                tbxAllergies.Text = patientInfo[7].ToString();
                tbxContagiousDisease.Text = patientInfo[8].ToString();
                tbxSystematicDisease.Text = patientInfo[9].ToString();
                tbxPastTreatments.Text = patientInfo[10].ToString();
                tbxRegularlyUsedDrugs.Text = patientInfo[11].ToString();
            }
            else //demek ki yeni bir patient eklenecek
            {
                btnDelete.Visible = false;
                lblProcess.Text = "Adding New Patient";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int affectedRowCount = 0;
            if (patient_id != null) //demek ki varolan patientı update edeceğiz saveye basınca
            {
                
                if (CheckTextBoxes()) //gerekli alanlar doluysa güncelle
                {
                    try
                    {
                        affectedRowCount = dbHelper.SetData("UPDATE Patient SET patient_name = '"+ tbxPatientName.Text.ToString() + "', patient_surname = '" + tbxPatientSurname.Text.ToString() + "', patient_age = " + tbxPatientAge.Text +", tcNo = '" + tbxPatientTcNo.Text.ToString() + "', patient_phone = '" + tbxPatientPhone.Text.ToString() +"', blood_group = '" + tbxBloodgroup.Text.ToString() + "', patient_notes = '" + tbxNotesAboutPatient.Text.ToString() +"', allergies = '" + tbxAllergies.Text.ToString() +"', contagious_disease = '" + tbxContagiousDisease.Text.ToString() +"', systematic_discomfort = '" + tbxSystematicDisease.Text.ToString() +"', past_treatments = '" + tbxPastTreatments.Text.ToString() +"', regularly_used_drugs = '" + tbxRegularlyUsedDrugs.Text.ToString() +"' WHERE patient_id = " + patient_id +"; ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (affectedRowCount != 0)
                    {
                        MessageBox.Show("Patient updated!\nPlease click refresh button in Main Screen to see the changes!");
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");
                    }
                }
            }
            else //demek ki yeni bir patient eklenecek saveye basınca
            {
                try
                {
                    if (CheckTextBoxes())
                    {
                        affectedRowCount = dbHelper.SetData("INSERT INTO Patient (patient_name,patient_surname,patient_age,tcNo,patient_phone,blood_group,record_date,patient_notes,allergies,contagious_disease,systematic_discomfort,past_treatments,regularly_used_drugs,doctor_id) VALUES ('" + tbxPatientName.Text + "', '" + tbxPatientSurname.Text + "', " + tbxPatientAge.Text + ", '" + tbxPatientTcNo.Text + "', '" + tbxPatientPhone.Text + "', '" + tbxBloodgroup.Text + "',GETDATE(), '" + tbxNotesAboutPatient.Text + "', '" + tbxAllergies.Text + "', '" + tbxContagiousDisease.Text + "', '" + tbxSystematicDisease.Text + "', '" + tbxPastTreatments.Text + "', '" + tbxRegularlyUsedDrugs.Text + "', " + this.loggedDoctorId + " )");
                        //affectedRowCount = dbHelper.SetData("INSERT INTO Patient (patient_name,patient_surname,patient_age,tcNo,patient_phone,blood_group,record_date,patient_notes,allergies,contagious_disease,systematic_discomfort,past_treatments,regularly_used_drugs,doctor_id) VALUES ('Onur', 'Akpinar', 23 , '22558375002', '5319312231', 'A+',GETDATE(), '', '', '', '', '', '', '"+this.loggedDoctorId+"' )");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error. Please show this error to developer : " + ex.Message);
                }
                if (affectedRowCount != 0)
                {
                    MessageBox.Show("Patient created!\nPlease click refresh button in Main Screen to see the changes!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Adding patient cancelled!");
                }
            }
        }

        private bool CheckTextBoxes()
        {
            
                if(tbxPatientName.Text != "" 
                    && tbxPatientSurname.Text != ""
                    && tbxPatientAge.Text != ""
                    && tbxPatientTcNo.Text != ""
                    && tbxPatientPhone.Text != ""
                    )
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(tbxPatientTcNo.Text, "^[1-9]{1}[0-9]{9}[02468]{1}$"))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong identification number!\nPlease fix and retry.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill first 5 details about patient!\nName-Surname, Age,TcNo,Phone");
                    return false;
                }
            
        }

        private void tbxPatientAge_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbxPatientAge.Text, "[^0-9]"))
            {
                MessageBox.Show("Enter only numbers!");
                tbxPatientAge.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult msg = MessageBox.Show("Do you really want to delete this patient?\nThis process can not be undone.", "Warning!", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    /* Buraya şunu eklemeyi unutma eğer hasta silinirse diğer tablolardaki sessionlar vb de silinmeli */
                    //dbHelper.SetData("DELETE FROM TreatmentSession WHERE Treatment.patient_id = " + patient_id + " AND Treatment.treatment_id = TreatmentSession.treatment_id");
                    //dbHelper.SetData("DELETE FROM Treatment WHERE patient_id = " + patient_id + ";");
                    dbHelper.SetData("DELETE FROM Patient WHERE patient_id = " + patient_id + ";");
                    //Burada belki de payment ve session tablosundan da silmek gerekli?

                    MessageBox.Show("Patient and its related tables are deleted!\nPlease refresh the tables to see effect!");
                    this.Close();
                }
                else if (msg == DialogResult.No)
                {
                    /* Do nothing */
                }
            }
            catch (Exception ex)
            {
                var dialogRes = MessageBox.Show("Error!\nProbably, the patient you are trying to delete has treatments or sessions in database.\nPlease delete them before deleting the patient.");
            }



        }

        private void PatientDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshMainForm();
        }
    }
}
