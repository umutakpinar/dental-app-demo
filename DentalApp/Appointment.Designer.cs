namespace DentalApp
{
    partial class Appointment
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPatientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTreatmentId = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.tbxSessionInfo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAppointmentCompleted = new System.Windows.Forms.Label();
            this.comboBoxIsSessionCompleted = new System.Windows.Forms.ComboBox();
            this.btnSaveSession = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSessionHeader = new System.Windows.Forms.TextBox();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteSession = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(366, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 33);
            this.label5.TabIndex = 43;
            this.label5.Text = "Patient : ";
            // 
            // tbxPatientName
            // 
            this.tbxPatientName.Enabled = false;
            this.tbxPatientName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPatientName.Location = new System.Drawing.Point(465, 66);
            this.tbxPatientName.Name = "tbxPatientName";
            this.tbxPatientName.Size = new System.Drawing.Size(300, 36);
            this.tbxPatientName.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 45;
            this.label1.Text = "Treatment ID  :";
            // 
            // tbxTreatmentId
            // 
            this.tbxTreatmentId.Enabled = false;
            this.tbxTreatmentId.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTreatmentId.Location = new System.Drawing.Point(208, 66);
            this.tbxTreatmentId.Name = "tbxTreatmentId";
            this.tbxTreatmentId.Size = new System.Drawing.Size(130, 36);
            this.tbxTreatmentId.TabIndex = 44;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(208, 122);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(130, 33);
            this.dateTimePickerDate.TabIndex = 1;
            this.dateTimePickerDate.Value = new System.DateTime(2022, 12, 26, 0, 0, 0, 0);
            // 
            // tbxSessionInfo
            // 
            this.tbxSessionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSessionInfo.Location = new System.Drawing.Point(27, 294);
            this.tbxSessionInfo.Name = "tbxSessionInfo";
            this.tbxSessionInfo.Size = new System.Drawing.Size(1204, 309);
            this.tbxSessionInfo.TabIndex = 4;
            this.tbxSessionInfo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 33);
            this.label2.TabIndex = 50;
            this.label2.Text = "Appointment Date :";
            // 
            // lblAppointmentCompleted
            // 
            this.lblAppointmentCompleted.AutoSize = true;
            this.lblAppointmentCompleted.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentCompleted.Location = new System.Drawing.Point(554, 626);
            this.lblAppointmentCompleted.Name = "lblAppointmentCompleted";
            this.lblAppointmentCompleted.Size = new System.Drawing.Size(238, 33);
            this.lblAppointmentCompleted.TabIndex = 51;
            this.lblAppointmentCompleted.Text = "Appointment Completed :";
            // 
            // comboBoxIsSessionCompleted
            // 
            this.comboBoxIsSessionCompleted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsSessionCompleted.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxIsSessionCompleted.FormattingEnabled = true;
            this.comboBoxIsSessionCompleted.Items.AddRange(new object[] {
            "Incompleted",
            "Completed"});
            this.comboBoxIsSessionCompleted.Location = new System.Drawing.Point(798, 622);
            this.comboBoxIsSessionCompleted.Name = "comboBoxIsSessionCompleted";
            this.comboBoxIsSessionCompleted.Size = new System.Drawing.Size(215, 37);
            this.comboBoxIsSessionCompleted.TabIndex = 5;
            // 
            // btnSaveSession
            // 
            this.btnSaveSession.BackColor = System.Drawing.Color.LightGreen;
            this.btnSaveSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveSession.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveSession.Location = new System.Drawing.Point(1031, 622);
            this.btnSaveSession.Name = "btnSaveSession";
            this.btnSaveSession.Size = new System.Drawing.Size(200, 40);
            this.btnSaveSession.TabIndex = 6;
            this.btnSaveSession.Text = "Save Changes";
            this.btnSaveSession.UseVisualStyleBackColor = false;
            this.btnSaveSession.Click += new System.EventHandler(this.btnSaveSession_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 33);
            this.label6.TabIndex = 54;
            this.label6.Text = "Session Info :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(21, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 33);
            this.label7.TabIndex = 55;
            this.label7.Text = "Session Header :";
            // 
            // tbxSessionHeader
            // 
            this.tbxSessionHeader.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSessionHeader.Location = new System.Drawing.Point(208, 178);
            this.tbxSessionHeader.Name = "tbxSessionHeader";
            this.tbxSessionHeader.Size = new System.Drawing.Size(859, 36);
            this.tbxSessionHeader.TabIndex = 3;
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAppointment.Location = new System.Drawing.Point(20, 9);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(134, 35);
            this.lblAppointment.TabIndex = 57;
            this.lblAppointment.Text = ".................";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(364, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 33);
            this.label3.TabIndex = 59;
            this.label3.Text = "Appointment Time :";
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CalendarFont = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(555, 122);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(210, 33);
            this.dateTimePickerTime.TabIndex = 2;
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteSession.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteSession.Location = new System.Drawing.Point(24, 621);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteSession.TabIndex = 60;
            this.btnDeleteSession.Text = "Delete Session";
            this.btnDeleteSession.UseVisualStyleBackColor = false;
            this.btnDeleteSession.Click += new System.EventHandler(this.btnDeleteSession_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnDeleteSession);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.tbxSessionHeader);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSaveSession);
            this.Controls.Add(this.comboBoxIsSessionCompleted);
            this.Controls.Add(this.lblAppointmentCompleted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSessionInfo);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTreatmentId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxPatientName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Appointment_FormClosing);
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTreatmentId;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.RichTextBox tbxSessionInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAppointmentCompleted;
        private System.Windows.Forms.ComboBox comboBoxIsSessionCompleted;
        private System.Windows.Forms.Button btnSaveSession;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxSessionHeader;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Button btnDeleteSession;
    }
}