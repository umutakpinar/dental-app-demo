using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace DentalApp
{
    public partial class TreatementDetails : Form
    {
        Form1 form1;
        String treatment_id;
        string patient_name;
        DbHelper dbHelper;
        public TreatementDetails(String _treatment_id,String _patient_name,Form1 form)
        {
            InitializeComponent();
            this.treatment_id = _treatment_id;    
            this.patient_name = _patient_name;
            form1 = form;
        }

        private void TreatementDetails_Load(object sender, EventArgs e)
        {
            refreshTables();
        }

        private void btnDeleteTreatment_Click(object sender, EventArgs e)
        {
            /* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/
            /* BUrada alt sessionlar ve de ödemeler de silinmeli ancak alınan para payment biligisini silmedim sonuçta bir ödeme alınmış??? şimdilik eklemekedik ama eklemeyi unutma!!!!!!!!!!!!!!! */
            var dialogResult = MessageBox.Show("Do you really want to delete this treatment and its sessions?\nThis process can not be undone!","Delete treatement?",MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes)
            {
                var b = dbHelper.SetData("DELETE FROM TreatmentSession WHERE treatment_id = " + treatment_id.ToString() + " ;");
                var a = dbHelper.SetData("DELETE FROM Treatment WHERE treatment_id = " + treatment_id.ToString() + " ;");
                
                if (a == 1)
                {
                    MessageBox.Show("Treatment and it's relations are deleted. Please refresh the tables to see changes.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something gone wrong.");
                }
            }
        }

        private void btnSaveTreatment_Click(object sender, EventArgs e)
        {
            int affectedRow = dbHelper.SetData("UPDATE Treatment SET treatment_info = '"+ tbxTreatmentInfo.Text +"',complaints = '"+ tbxComplaints.Text +"',treatment_notes = '"+tbxTreatmentNotes.Text+"',estimated_fee = '"+tbxEstimatedFee.Text+"',isTreatmentCompleted = "+comboBoxIsTreatmentCompleted.SelectedIndex+",moneyUnit = '"+comboBoxMoneyUnit.Text+"' WHERE treatment_id = " + treatment_id + " ;");
            if(affectedRow >= 1)
            {
                MessageBox.Show("Treatment updated! Please refresh tables to see changes.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something go wrong.");
            }
        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment(treatment_id, patient_name, this);
            appointment.ShowDialog();
        }

        private void dataGridViewSessions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                DataGridViewRow row = dataGridViewSessions.Rows[e.RowIndex];
                //Appointment appointment = new Appointment(row.Cells["Session ID"].Value.ToString(), this);
                //appointment.ShowDialog();
            }
            catch (ArgumentOutOfRangeException exx)
            {
                MessageBox.Show("Click appointments tab in the main form for seeing details.");
            }
        }

        public void refreshTables()
        {
            dbHelper = new DbHelper();
            dataGridViewSessions.DataSource = dbHelper.GetData("SELECT session_id as 'Session ID', treatment_id as 'Treatment ID', session_date as 'Session Date/Time', session_header as 'Session Header', session_info as 'Session Info', isApplied as 'Session Completed' FROM TreatmentSession WHERE treatment_id = " + treatment_id + " ;");
            //DataGridView'i doldur
            DataSet treatementDataSet = dbHelper.GetTreatmentDataSet(treatment_id);
            DataRow treatmentInfo = treatementDataSet.Tables[0].Rows[0];

            //textboxları doldur
            tbxPatientId.Text = treatmentInfo["patient_id"].ToString();
            tbxPatientName.Text = patient_name;
            tbxEstimatedFee.Text = treatmentInfo["estimated_fee"].ToString();
            var getMoneyunitIndex = comboBoxMoneyUnit.Items.IndexOf(treatmentInfo["moneyUnit"].ToString()); ///Burada db'den kaynaklı bir sıkıntı oluyor o nedenle burada fix atıyorum 1 ve 2 değilse 0 olmalı şeklinde
            if (!(getMoneyunitIndex == 1 || getMoneyunitIndex == 2))
            {
                getMoneyunitIndex = 0;
            }
            comboBoxMoneyUnit.SelectedIndex = getMoneyunitIndex;
            tbxTreatmentInfo.Text = treatmentInfo["treatment_info"].ToString();
            tbxComplaints.Text = treatmentInfo["complaints"].ToString();
            tbxTreatmentNotes.Text = treatmentInfo["treatment_notes"].ToString();
            int isCompleted = Convert.ToInt32(treatmentInfo["isTreatmentCompleted"].ToString());
            if (isCompleted == 0 || isCompleted == 1)
            {
                comboBoxIsTreatmentCompleted.SelectedIndex = isCompleted;
            }
            else
            {
                MessageBox.Show("Can not reach treatment completed info");
            }
            tbxDate.Text = Convert.ToDateTime(treatmentInfo["application_date"].ToString()).ToString("dd.MM.yyyy");
        }

        private void refreshMain()
        {
            form1.RefreshTables();
        }

        private void TreatementDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshMain();
        }
    }
}
