namespace DentalApp
{
    partial class TreatementDetails
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
            this.dataGridViewSessions = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMoneyUnit = new System.Windows.Forms.ComboBox();
            this.tbxEstimatedFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPatientName = new System.Windows.Forms.TextBox();
            this.tbxTreatmentNotes = new System.Windows.Forms.RichTextBox();
            this.tbxComplaints = new System.Windows.Forms.RichTextBox();
            this.tbxTreatmentInfo = new System.Windows.Forms.RichTextBox();
            this.tbxPatientId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteTreatment = new System.Windows.Forms.Button();
            this.btnSaveTreatment = new System.Windows.Forms.Button();
            this.comboBoxIsTreatmentCompleted = new System.Windows.Forms.ComboBox();
            this.btnAddNewAppointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSessions
            // 
            this.dataGridViewSessions.AllowUserToAddRows = false;
            this.dataGridViewSessions.AllowUserToDeleteRows = false;
            this.dataGridViewSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessions.Location = new System.Drawing.Point(40, 354);
            this.dataGridViewSessions.Name = "dataGridViewSessions";
            this.dataGridViewSessions.ReadOnly = true;
            this.dataGridViewSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewSessions.Size = new System.Drawing.Size(1169, 258);
            this.dataGridViewSessions.TabIndex = 0;
            this.dataGridViewSessions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSessions_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(870, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 33);
            this.label6.TabIndex = 42;
            this.label6.Text = "Estimated Fee";
            // 
            // comboBoxMoneyUnit
            // 
            this.comboBoxMoneyUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMoneyUnit.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxMoneyUnit.FormattingEnabled = true;
            this.comboBoxMoneyUnit.Items.AddRange(new object[] {
            "₺ (TL)",
            "$ (USD)",
            "€ (EUR)"});
            this.comboBoxMoneyUnit.Location = new System.Drawing.Point(1129, 25);
            this.comboBoxMoneyUnit.Name = "comboBoxMoneyUnit";
            this.comboBoxMoneyUnit.Size = new System.Drawing.Size(85, 37);
            this.comboBoxMoneyUnit.TabIndex = 41;
            // 
            // tbxEstimatedFee
            // 
            this.tbxEstimatedFee.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEstimatedFee.Location = new System.Drawing.Point(1014, 26);
            this.tbxEstimatedFee.Name = "tbxEstimatedFee";
            this.tbxEstimatedFee.Size = new System.Drawing.Size(109, 36);
            this.tbxEstimatedFee.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(455, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 33);
            this.label5.TabIndex = 39;
            this.label5.Text = "Patient : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 33);
            this.label4.TabIndex = 38;
            this.label4.Text = "Patient ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(870, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 33);
            this.label3.TabIndex = 37;
            this.label3.Text = "Treatment Notes :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(455, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 33);
            this.label2.TabIndex = 36;
            this.label2.Text = "Complaints :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 35;
            this.label1.Text = "Treatment Info :";
            // 
            // tbxPatientName
            // 
            this.tbxPatientName.Enabled = false;
            this.tbxPatientName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPatientName.Location = new System.Drawing.Point(554, 22);
            this.tbxPatientName.Name = "tbxPatientName";
            this.tbxPatientName.Size = new System.Drawing.Size(255, 36);
            this.tbxPatientName.TabIndex = 34;
            // 
            // tbxTreatmentNotes
            // 
            this.tbxTreatmentNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTreatmentNotes.Location = new System.Drawing.Point(864, 105);
            this.tbxTreatmentNotes.Name = "tbxTreatmentNotes";
            this.tbxTreatmentNotes.Size = new System.Drawing.Size(350, 158);
            this.tbxTreatmentNotes.TabIndex = 33;
            this.tbxTreatmentNotes.Text = "";
            // 
            // tbxComplaints
            // 
            this.tbxComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxComplaints.Location = new System.Drawing.Point(459, 105);
            this.tbxComplaints.Name = "tbxComplaints";
            this.tbxComplaints.Size = new System.Drawing.Size(350, 158);
            this.tbxComplaints.TabIndex = 32;
            this.tbxComplaints.Text = "";
            // 
            // tbxTreatmentInfo
            // 
            this.tbxTreatmentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTreatmentInfo.Location = new System.Drawing.Point(43, 105);
            this.tbxTreatmentInfo.Name = "tbxTreatmentInfo";
            this.tbxTreatmentInfo.Size = new System.Drawing.Size(350, 158);
            this.tbxTreatmentInfo.TabIndex = 31;
            this.tbxTreatmentInfo.Text = "";
            // 
            // tbxPatientId
            // 
            this.tbxPatientId.Enabled = false;
            this.tbxPatientId.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPatientId.Location = new System.Drawing.Point(166, 22);
            this.tbxPatientId.Name = "tbxPatientId";
            this.tbxPatientId.Size = new System.Drawing.Size(101, 36);
            this.tbxPatientId.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(860, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 33);
            this.label7.TabIndex = 44;
            this.label7.Text = "Date Created : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(455, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 33);
            this.label8.TabIndex = 46;
            this.label8.Text = "Is Completed?";
            // 
            // tbxDate
            // 
            this.tbxDate.Enabled = false;
            this.tbxDate.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxDate.Location = new System.Drawing.Point(998, 288);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(211, 36);
            this.tbxDate.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(47, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 33);
            this.label9.TabIndex = 48;
            this.label9.Text = "Appointments";
            // 
            // btnDeleteTreatment
            // 
            this.btnDeleteTreatment.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTreatment.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteTreatment.Location = new System.Drawing.Point(784, 629);
            this.btnDeleteTreatment.Name = "btnDeleteTreatment";
            this.btnDeleteTreatment.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteTreatment.TabIndex = 49;
            this.btnDeleteTreatment.Text = "Delete Treatment";
            this.btnDeleteTreatment.UseVisualStyleBackColor = false;
            this.btnDeleteTreatment.Click += new System.EventHandler(this.btnDeleteTreatment_Click);
            // 
            // btnSaveTreatment
            // 
            this.btnSaveTreatment.BackColor = System.Drawing.Color.LightGreen;
            this.btnSaveTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveTreatment.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveTreatment.Location = new System.Drawing.Point(1009, 629);
            this.btnSaveTreatment.Name = "btnSaveTreatment";
            this.btnSaveTreatment.Size = new System.Drawing.Size(200, 40);
            this.btnSaveTreatment.TabIndex = 50;
            this.btnSaveTreatment.Text = "Save Changes";
            this.btnSaveTreatment.UseVisualStyleBackColor = false;
            this.btnSaveTreatment.Click += new System.EventHandler(this.btnSaveTreatment_Click);
            // 
            // comboBoxIsTreatmentCompleted
            // 
            this.comboBoxIsTreatmentCompleted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsTreatmentCompleted.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxIsTreatmentCompleted.FormattingEnabled = true;
            this.comboBoxIsTreatmentCompleted.Items.AddRange(new object[] {
            "Incompleted",
            "Completed"});
            this.comboBoxIsTreatmentCompleted.Location = new System.Drawing.Point(601, 291);
            this.comboBoxIsTreatmentCompleted.Name = "comboBoxIsTreatmentCompleted";
            this.comboBoxIsTreatmentCompleted.Size = new System.Drawing.Size(208, 37);
            this.comboBoxIsTreatmentCompleted.TabIndex = 51;
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewAppointment.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewAppointment.Location = new System.Drawing.Point(40, 629);
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.Size = new System.Drawing.Size(164, 40);
            this.btnAddNewAppointment.TabIndex = 52;
            this.btnAddNewAppointment.Text = "+ New Apointment";
            this.btnAddNewAppointment.UseVisualStyleBackColor = false;
            this.btnAddNewAppointment.Click += new System.EventHandler(this.btnAddNewAppointment_Click);
            // 
            // TreatementDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnAddNewAppointment);
            this.Controls.Add(this.comboBoxIsTreatmentCompleted);
            this.Controls.Add(this.btnSaveTreatment);
            this.Controls.Add(this.btnDeleteTreatment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMoneyUnit);
            this.Controls.Add(this.tbxEstimatedFee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPatientName);
            this.Controls.Add(this.tbxTreatmentNotes);
            this.Controls.Add(this.tbxComplaints);
            this.Controls.Add(this.tbxTreatmentInfo);
            this.Controls.Add(this.tbxPatientId);
            this.Controls.Add(this.dataGridViewSessions);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "TreatementDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treatement Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TreatementDetails_FormClosing);
            this.Load += new System.EventHandler(this.TreatementDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSessions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMoneyUnit;
        private System.Windows.Forms.TextBox tbxEstimatedFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPatientName;
        private System.Windows.Forms.RichTextBox tbxTreatmentNotes;
        private System.Windows.Forms.RichTextBox tbxComplaints;
        private System.Windows.Forms.RichTextBox tbxTreatmentInfo;
        private System.Windows.Forms.TextBox tbxPatientId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteTreatment;
        private System.Windows.Forms.Button btnSaveTreatment;
        private System.Windows.Forms.ComboBox comboBoxIsTreatmentCompleted;
        private System.Windows.Forms.Button btnAddNewAppointment;
    }
}