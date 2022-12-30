using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;

namespace DentalApp
{
    internal class DbHelper
    {
        private SqlConnection connection;
        private SqlCommand command;
        private DataTable dataTable;
        private SqlDataAdapter sqlDataAdapter;
        private string connectionString;

        public DbHelper()
        {
            //Buraya file nerdeyse onu koyamyı unutma hatta upload butonu ekle daha sonra ya da bağlantı adresi seç gibi bir şey olmalı!
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DENTAL.mdf;Integrated Security=True;Connect Timeout=30";
            //connectionString = @"Server=localhost\SQLEXPRESS;Database=DENTAL;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }

        public bool Login(String username, String password)
        {
            SqlDataReader dataReader;
            string query = "SELECT * FROM Doctor where username=@user AND password=@pass";
            command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("user", username);
            command.Parameters.AddWithValue("pass", password);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;   
            }
        }

        public ArrayList GetLoggedDoctor(String username)
        {
            string query = String.Format("SELECT doctor_id, fullName FROM Doctor where username='{0}';",username);
            command = new SqlCommand(query,connection);
            var dataSet = new DataSet();
            sqlDataAdapter = new SqlDataAdapter(query,connection);
            
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            ArrayList doctorInfo = new ArrayList();

            sqlDataAdapter.Fill(dataSet);
            connection.Close();

            doctorInfo.Add(dataSet.Tables[0].Rows[0]["doctor_id"]);
            doctorInfo.Add(dataSet.Tables[0].Rows[0]["fullName"]);

            return doctorInfo;
        }

        public ArrayList GetPatientDetails(String ID)
        {
            string query = String.Format("SELECT patient_name,patient_surname,patient_age,tcNo,patient_phone,blood_group,patient_notes,allergies,contagious_disease,systematic_discomfort,past_treatments,regularly_used_drugs FROM Patient where patient_id='{0}';", ID);
            command = new SqlCommand(query, connection);
            var dataSet = new DataSet();
            sqlDataAdapter = new SqlDataAdapter(query, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            ArrayList patientInfo = new ArrayList();

            sqlDataAdapter.Fill(dataSet);
            connection.Close();

            patientInfo.Add(dataSet.Tables[0].Rows[0]["patient_name"]);
            patientInfo.Add(dataSet.Tables[0].Rows[0]["patient_surname"]);
            patientInfo.Add(dataSet.Tables[0].Rows[0]["patient_age"]);
            patientInfo.Add(dataSet.Tables[0].Rows[0]["tcNo"]);
            patientInfo.Add(dataSet.Tables[0].Rows[0]["patient_phone"]);
            patientInfo.Add(dataSet.Tables[0].Rows[0]["blood_group"]);
            patientInfo.Add(dataSet.Tables[0].Rows[0]["patient_notes"]);
            patientInfo.Add(dataSet.Tables[0].Rows[0]["allergies"]);
            patientInfo.Add(dataSet.Tables[0].Rows[0]["contagious_disease"]);
            patientInfo.Add(dataSet.Tables[0].Rows[0]["systematic_discomfort"]);
            patientInfo.Add(dataSet.Tables[0].Rows[0]["past_treatments"]);
            patientInfo.Add(dataSet.Tables[0].Rows[0]["regularly_used_drugs"]);

            return patientInfo;
        }

        public DataSet getPatientInfoDataSet(String ID)
        {
            string query = String.Format("SELECT patient_name,patient_surname,patient_age,tcNo,patient_phone,blood_group,patient_notes,allergies,contagious_disease,systematic_discomfort,past_treatments,regularly_used_drugs FROM Patient where patient_id='{0}';", ID);
            command = new SqlCommand(query, connection);
            var dataSet = new DataSet();
            sqlDataAdapter = new SqlDataAdapter(query, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            ArrayList patientInfo = new ArrayList();

            sqlDataAdapter.Fill(dataSet);
            connection.Close();
            return dataSet;
        }

        public DataSet GetTreatmentDataSet(String treatment_id)
        {
            string query = String.Format("SELECT * FROM Treatment WHERE treatment_id='{0}';", treatment_id);
            //command = new SqlCommand(query, connection); ??? GEREKSİZ BURADA
            var dataSet = new DataSet();
            sqlDataAdapter = new SqlDataAdapter(query, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            sqlDataAdapter.Fill(dataSet);
            connection.Close();
            return dataSet;
        }

        public DataTable GetData(string Query) //
        {
            dataTable = new DataTable();
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            sqlDataAdapter = new SqlDataAdapter(Query, connectionString);
            sqlDataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public int SetData(string Query)
        {
            int Cnt = 0;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.CommandText = Query;
            Cnt = command.ExecuteNonQuery();
            connection.Close();
            return Cnt;
        }

        public bool checkThisSessionDateTimeIsBusy(String selectedDateTime)
        {
            string query = String.Format("SELECT 1 as 'Result' FROM TreatmentSession WHERE session_date = '" + selectedDateTime + "';");
            //command = new SqlCommand(query, connection); ??? GEREKSİZ BURADA
            var dataSet = new DataSet();
            sqlDataAdapter = new SqlDataAdapter(query, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            sqlDataAdapter.Fill(dataSet);
            connection.Close();

            try
            {
                if (dataSet.Tables[0].Rows[0]["Result"].ToString() == "1")
                {
                    return true;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException iooex) {
                return false;
            }
        }

        public DataSet getAppointmentDetails(String session_id)
        {
            DataSet dataSet = new DataSet();
            string query = "SELECT * FROM TreatmentSession, Treatment WHERE session_id = " +session_id+ " AND Treatment.treatment_id = TreatmentSession.treatment_id;";
            var sqlDataAdapter = new SqlDataAdapter(query, connection);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            sqlDataAdapter.Fill(dataSet);
            connection.Close();
            return dataSet;

        }
    }

    
}
