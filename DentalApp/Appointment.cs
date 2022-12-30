using System;
using System.Data;
using System.Windows.Forms;

namespace DentalApp
{
    public partial class Appointment : Form
    {
        Form1 parentForm1;
        TreatementDetails parentFormTreatmentDetails;
        String[] strSelectedSessionDatelist; //Eski date & time verisi //Bu veri yalnıza mevcut olan bir appointment(session) editlenirse doldurulaak çünkü aynı aynı zamanda appoitnment var hocam diye hata vermemesi adına zaten o zamanda o var yani o hesap yani db'den gelen datae ve saat berisi ilk index date ilinci index saati tutar
        String treatment_id;
        String patient_name;
        DbHelper dbHelper;
        String appointmentHeaderText;
        String session_id;
        bool isCreateNewAppointment;

        public Appointment(String _session_id,Form1 _form) //Burdan geliyorsa var olanı düzelteecek
        {
            InitializeComponent();
            this.session_id = _session_id;
            appointmentHeaderText = "Edit Existing Appointment";
            isCreateNewAppointment = false;
            parentForm1 = _form;
        }
        public Appointment(String _treatment_id, String _patient_name, TreatementDetails _form) //Buradan geliyorsa yeni seans açacak
        {
            InitializeComponent();
            this.patient_name = _patient_name;
            this.treatment_id = _treatment_id;
            appointmentHeaderText = "Create New Appointment";
            isCreateNewAppointment = true;
            parentFormTreatmentDetails = _form;
        }


        private void Appointment_Load(object sender, EventArgs e)
        {
            dbHelper = new DbHelper();
            lblAppointment.Text = appointmentHeaderText;
            if (isCreateNewAppointment) //demek ki yeni appoitment oluşturulacak
            {
                btnDeleteSession.Visible = false;
                btnDeleteSession.Enabled = false;
                lblAppointmentCompleted.Visible = false;
                comboBoxIsSessionCompleted.Visible = false;
                comboBoxIsSessionCompleted.Enabled = false;

                tbxTreatmentId.Text = treatment_id;
                tbxPatientName.Text = patient_name;
            }
            else //demek ki varolan appointment düzenlenecek 
            {


                DataSet sessionInfoDataSet = dbHelper.getAppointmentDetails(session_id);
                var sessionInfo = sessionInfoDataSet.Tables[0].Rows[0];
                DataSet patientInfoDataSet = dbHelper.getPatientInfoDataSet(sessionInfo["patient_id"].ToString());
                var patientInfo = patientInfoDataSet.Tables[0].Rows[0];

                //Burada treatment_id global değişkenine dbHelper'dan gelen veriyi ata
                treatment_id = sessionInfo["treatment_id"].ToString();
                tbxTreatmentId.Text = treatment_id;
                tbxPatientName.Text = patientInfo["patient_name"].ToString();
                tbxSessionHeader.Text = sessionInfo["session_header"].ToString();
                tbxSessionInfo.Text = sessionInfo["session_info"].ToString();  //12.26.20
                strSelectedSessionDatelist = sessionInfo["session_date"].ToString().Split(' ');
                //MessageBox.Show(strSelectedSessionDatelist[0] + strSelectedSessionDatelist[1]); //test için yazıldı
                dateTimePickerDate.Value = DateTime.Parse(strSelectedSessionDatelist[0]);
                dateTimePickerTime.Value = DateTime.Parse(strSelectedSessionDatelist[1]);
                comboBoxIsSessionCompleted.SelectedIndex = Convert.ToInt32(sessionInfo["isApplied"].ToString());

            }
        }

        private void btnSaveSession_Click(object sender, EventArgs e)
        {
            String selectedDate = dateTimePickerDate.Value.ToString("yyyy.MM.dd"); //şu anda seçilen date sql'e kaydedebilmek adına bu tipte aldık (dd.MM.yyyy) yazıyordu az önce
            String sorgulaDate = dateTimePickerDate.Value.ToString("dd.MM.yyyy");
            String selectedTime = dateTimePickerTime.Value.ToString("HH:mm");
            String selectedDateTimeOriginal = dateTimePickerDate.Value.ToString("MM.dd.yyyy") + " " + selectedTime;
            String selectedDateTime = selectedDate + " " + selectedTime; //Yeni (şu an seçilen) date time verisi
            String selectedDateTime2 = sorgulaDate + " " + selectedTime; //Yeni (şu an seçilen) date time verisi
            String session_header = tbxSessionHeader.Text;
            String sessin_info = tbxSessionInfo.Text;
            int isApplied;
            if (comboBoxIsSessionCompleted.Text == "")
            {
                isApplied = 0;
            }
            else
            {
                isApplied = comboBoxIsSessionCompleted.SelectedIndex;
            }


            int affectedRow = 0;
            if (isCreateNewAppointment) //demek ki yeni appointment oluşturulacak
            {
                if (isThisDateTimeBusy(selectedDateTimeOriginal) != true)
                {
                    affectedRow = dbHelper.SetData("INSERT INTO TreatmentSession (treatment_id,session_date,session_header,session_info,isApplied) VALUES ('" + treatment_id + "','" + selectedDateTime + "','" + session_header + "','" + sessin_info + "'," + isApplied.ToString() + ");");
                }
                else
                {
                    MessageBox.Show("You have a different appointment in this date.\nSelect another date.");
                }
            }
            else //demek ki varolan appointment düzenlenecek
            {
                //MessageBox.Show(String.Format("selectedDateTime2 : {0}\nstrSelectedSessionDatelist[1&2] :{1}\nResult : {2} ", selectedDateTime2, (strSelectedSessionDatelist[0] + " " + strSelectedSessionDatelist[1].Substring(0,strSelectedSessionDatelist[1].Length - 3)).ToString(), selectedDateTime2 == (strSelectedSessionDatelist[0] + " " + strSelectedSessionDatelist[1].Substring(0, strSelectedSessionDatelist[1].Length - 3)).ToString())); //test için yazıldı
                
               if (selectedDateTime2 != (strSelectedSessionDatelist[0] + " " + strSelectedSessionDatelist[1].Substring(0, strSelectedSessionDatelist[1].Length - 3)).ToString() ) 
               {
                   if (isThisDateTimeBusy(selectedDateTimeOriginal) == false)
                   {
                       affectedRow = dbHelper.SetData("UPDATE TreatmentSession SET session_date = '" + selectedDateTimeOriginal + "', session_header = '" + session_header + "', session_info = '" + sessin_info + "', isApplied = " + isApplied.ToString() + "  WHERE session_id = " + session_id );
                   }
                   else
                   {
                       MessageBox.Show("You have a different appointment in this date.\nSelect another date.");
                   }
               }
               else //Eğer eski ve yeni tarih birbirine eşit ise demek ki
               {
                   affectedRow = dbHelper.SetData("UPDATE TreatmentSession SET session_date = '" + selectedDateTimeOriginal + "', session_header = '" + session_header + "', session_info = '" + sessin_info + "', isApplied = " + isApplied.ToString() + "  WHERE session_id = " + session_id);
               }
               
            }

            if (affectedRow == 1)
            {
                MessageBox.Show("Session saved! Please refresh the tables!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something gone wrong!");
            }

        }

        private bool isThisDateTimeBusy(String _selectedDateTime)
        {
            return dbHelper.checkThisSessionDateTimeIsBusy(_selectedDateTime);
        }

        private void btnDeleteSession_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this result?\nThis process can not be undone.", "Warning!", MessageBoxButtons.OKCancel);

            if (result.Equals(DialogResult.OK))
            {
                int affectedRow = dbHelper.SetData("DELETE FROM TreatmentSession WHERE session_id = " + session_id);

                if (affectedRow == 1)
                {
                    MessageBox.Show("Treatment succesfully deleted.\nPlease refresh the tables.");
                    //Burada bir önceki formu refresh etmek gerek.
                    /* 1-1-1--1-1-1-1--1-1-1--1-1-1-1--1-1--1--1-1-1-1-1-1-1--1-1-1-1-1-1-1-1-1-1-1-1-1-1--1-1-1-1-1-1-1-1--1-1-1-1-1-1-1-1-1-1-1-1-1--1-1-1-1--1-1-1-1-1-1---1-1-1-1--1-1-1-1-1--1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1- */
                    //Bir form hangi formdan açıldıysa bunu tutan bir instance var ise bu form kapandığında o instance çağırılıp form reload/reboot ettirilebilir.
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Process aborted.");
                }
            }

        }

        private void refreshParent()
        {
            if (isCreateNewAppointment)
            {
                parentFormTreatmentDetails.refreshTables();
            }
            else
            {
                parentForm1.RefreshTables();
            }
        }

        private void Appointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshParent();
        }
    }
}
