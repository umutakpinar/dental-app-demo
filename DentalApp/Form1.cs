using System;
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
    public partial class Form1 : Form
    {
        DbHelper dbHelper;
        private int loggedDoctorId;
        private String loggedDoctorName;
        private Form form1;
        public Form1(int doctorId, String doctorName)
        {
            loggedDoctorId = doctorId;
            loggedDoctorName = doctorName;
            form1 = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbHelper = new DbHelper();
            lblDoctorName.Text = "Dt. "+loggedDoctorName;
            timer1.Start();
            RefreshTables();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }


        public void RefreshTables()
        {
            //dataGridViewAccounting.AllowUserToAddRows= false;
            dataGridViewAppointments.AllowUserToAddRows = false;
            dataGridViewPatients.AllowUserToAddRows = false;
            dataGridViewTreatments.AllowUserToAddRows = false;


            dataGridViewPatients.DataSource = dbHelper.GetData("SELECT patient_id as 'ID',patient_name as 'Name',patient_surname as 'Surname',patient_age as 'Age',tcNo as 'T.C. Number',patient_phone as 'Phone' FROM Patient");

            //Ödeme özelliğini şimdilik kaldırdık daha detaylı bir algoritma kurulunca dbdeki bu tablolar yeniden oluşturulacak
            //dataGridViewAccounting.DataSource = dbHelper.GetData(@"SELECT patient_name as 'Name',patient_surname as 'Surname', totalFee as 'Total', totalReceivedPayment as 'Received' , remainingDebt as 'Remaining Debt', Treatment.moneyUnit as 'Unit', patient_phone as 'Phone'  
            //   FROM Patient, Treatment, TreatmentPayment
            //   WHERE TreatmentPayment.treatment_id = Treatment.treatment_id
            //   AND Treatment.patient_id = Patient.patient_id");
            
            dataGridViewAppointments.DataSource = dbHelper.GetData(@"SELECT session_id as 'Session ID',session_date as 'Date', patient_name + ' ' + patient_surname as 'Patient',
                session_header as 'Header', session_info as 'Info', isApplied as 'is Completed?' FROM TreatmentSession, Treatment, Patient
                WHERE TreatmentSession.treatment_id = Treatment.treatment_id
                AND Treatment.patient_id = Patient.patient_id;");
        
            dataGridViewTreatments.DataSource = dbHelper.GetData(@"SELECT Treatment.treatment_id as 'Treatment ID', patient_name + ' ' + patient_surname as 'Patient',
                treatment_info as 'Info', complaints as 'Complaints', treatment_notes as 'Notes', estimated_fee 'Estimated Fee', isTreatmentCompleted as 'Is Treatment Completed?'
                FROM Treatment, Patient
                WHERE Treatment.patient_id = Patient.patient_id;");
        }

        private void createNewPatient_Click(object sender, EventArgs e)
        {
            PatientDetails patientDetailsForm = new PatientDetails(loggedDoctorId.ToString(),this);
            patientDetailsForm.ShowDialog();
        }

        private void dataGridViewPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String patient_id = null;
            try
            {
                DataGridViewRow row = dataGridViewPatients.Rows[e.RowIndex];

                patient_id = row.Cells["ID"].Value.ToString();
            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("Double-click on the patient you want to change the information of.");
            }

            if (patient_id != null)
            {

                //MessageBox.Show("Veriye tıklandı!" + patient_id);
                PatientDetails patientDetailsForm = new PatientDetails(loggedDoctorId.ToString(), patient_id,this);
                patientDetailsForm.ShowDialog();
            }


            //Buraya tıklanırsa hastanın bilgilerini güncelleyebileceği sayfa açıalcak bu durumda hasta bilgilerinin gözüktüğü sayfaya bu bilgilerin gönderilmesi
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTables();
        }

        private void btnCreateNewTreatment_Click(object sender, EventArgs e)
        {
            CreateNewTreatment createNewTreatmentForm = new CreateNewTreatment(this);
            createNewTreatmentForm.ShowDialog();
        }

        private void dataGridViewTreatments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*------------------------------------------------------------------------------------------------*/
            String treatment_id = null;
            String patient_name = null;
            try
            {
                DataGridViewRow row = dataGridViewTreatments.Rows[e.RowIndex];

                treatment_id = row.Cells["Treatment ID"].Value.ToString();
                patient_name = row.Cells["Patient"].Value.ToString();
            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("Double-click on the treatment you want to see the information of.");
            }

            if (treatment_id != null && patient_name != null)
            {

                //MessageBox.Show("Veriye tıklandı!" + patient_id);
                TreatementDetails treatmentDetailsForm = new TreatementDetails(treatment_id,patient_name,this);
                treatmentDetailsForm.ShowDialog();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void dataGridViewAppointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewAppointments.Rows[e.RowIndex];


                Appointment appointment = new Appointment(row.Cells["Session ID"].Value.ToString(), this);
                appointment.ShowDialog();
            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("Double click the cells not headers for details.");
            }
        }

      
    }
}
