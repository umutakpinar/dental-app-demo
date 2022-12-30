namespace DentalApp
{
    partial class CreateNewTreatment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.lblSelectPatient = new System.Windows.Forms.Label();
            this.tbxSelectdPatientId = new System.Windows.Forms.TextBox();
            this.tbxTreatmentInfo = new System.Windows.Forms.RichTextBox();
            this.tbxComplaints = new System.Windows.Forms.RichTextBox();
            this.tbxTreatmentNotes = new System.Windows.Forms.RichTextBox();
            this.tbxSelectedPatientName = new System.Windows.Forms.TextBox();
            this.btnCreateTreatment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxEstimatedFee = new System.Windows.Forms.TextBox();
            this.comboBoxMoneyUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPatients.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPatients.Location = new System.Drawing.Point(46, 55);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.Size = new System.Drawing.Size(1171, 207);
            this.dataGridViewPatients.TabIndex = 0;
            this.dataGridViewPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellClick);
            // 
            // lblSelectPatient
            // 
            this.lblSelectPatient.AutoSize = true;
            this.lblSelectPatient.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelectPatient.Location = new System.Drawing.Point(53, 19);
            this.lblSelectPatient.Name = "lblSelectPatient";
            this.lblSelectPatient.Size = new System.Drawing.Size(394, 33);
            this.lblSelectPatient.TabIndex = 1;
            this.lblSelectPatient.Text = "Click and Select Patient for New Treatment";
            // 
            // tbxSelectdPatientId
            // 
            this.tbxSelectdPatientId.Enabled = false;
            this.tbxSelectdPatientId.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSelectdPatientId.Location = new System.Drawing.Point(169, 296);
            this.tbxSelectdPatientId.Name = "tbxSelectdPatientId";
            this.tbxSelectdPatientId.Size = new System.Drawing.Size(101, 36);
            this.tbxSelectdPatientId.TabIndex = 2;
            // 
            // tbxTreatmentInfo
            // 
            this.tbxTreatmentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTreatmentInfo.Location = new System.Drawing.Point(46, 390);
            this.tbxTreatmentInfo.Name = "tbxTreatmentInfo";
            this.tbxTreatmentInfo.Size = new System.Drawing.Size(350, 195);
            this.tbxTreatmentInfo.TabIndex = 3;
            this.tbxTreatmentInfo.Text = "";
            // 
            // tbxComplaints
            // 
            this.tbxComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxComplaints.Location = new System.Drawing.Point(462, 390);
            this.tbxComplaints.Name = "tbxComplaints";
            this.tbxComplaints.Size = new System.Drawing.Size(350, 195);
            this.tbxComplaints.TabIndex = 4;
            this.tbxComplaints.Text = "";
            // 
            // tbxTreatmentNotes
            // 
            this.tbxTreatmentNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTreatmentNotes.Location = new System.Drawing.Point(867, 390);
            this.tbxTreatmentNotes.Name = "tbxTreatmentNotes";
            this.tbxTreatmentNotes.Size = new System.Drawing.Size(350, 195);
            this.tbxTreatmentNotes.TabIndex = 5;
            this.tbxTreatmentNotes.Text = "";
            // 
            // tbxSelectedPatientName
            // 
            this.tbxSelectedPatientName.Enabled = false;
            this.tbxSelectedPatientName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSelectedPatientName.Location = new System.Drawing.Point(557, 296);
            this.tbxSelectedPatientName.Name = "tbxSelectedPatientName";
            this.tbxSelectedPatientName.Size = new System.Drawing.Size(255, 36);
            this.tbxSelectedPatientName.TabIndex = 6;
            // 
            // btnCreateTreatment
            // 
            this.btnCreateTreatment.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateTreatment.Location = new System.Drawing.Point(1017, 618);
            this.btnCreateTreatment.Name = "btnCreateTreatment";
            this.btnCreateTreatment.Size = new System.Drawing.Size(200, 40);
            this.btnCreateTreatment.TabIndex = 7;
            this.btnCreateTreatment.Text = "Create Treatment";
            this.btnCreateTreatment.UseVisualStyleBackColor = true;
            this.btnCreateTreatment.Click += new System.EventHandler(this.btnCreateTreatment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Treatment Info :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(458, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Complaints :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(873, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Treatment Notes :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(53, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Patient ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(458, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "Patient : ";
            // 
            // tbxEstimatedFee
            // 
            this.tbxEstimatedFee.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEstimatedFee.Location = new System.Drawing.Point(1017, 300);
            this.tbxEstimatedFee.Name = "tbxEstimatedFee";
            this.tbxEstimatedFee.Size = new System.Drawing.Size(109, 36);
            this.tbxEstimatedFee.TabIndex = 13;
            this.tbxEstimatedFee.TextChanged += new System.EventHandler(this.tbxEstimatedFee_TextChanged);
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
            this.comboBoxMoneyUnit.Location = new System.Drawing.Point(1132, 299);
            this.comboBoxMoneyUnit.Name = "comboBoxMoneyUnit";
            this.comboBoxMoneyUnit.Size = new System.Drawing.Size(85, 37);
            this.comboBoxMoneyUnit.TabIndex = 14;
            this.comboBoxMoneyUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxMoneyUnit_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(873, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estimated Fee";
            // 
            // CreateNewTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMoneyUnit);
            this.Controls.Add(this.tbxEstimatedFee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateTreatment);
            this.Controls.Add(this.tbxSelectedPatientName);
            this.Controls.Add(this.tbxTreatmentNotes);
            this.Controls.Add(this.tbxComplaints);
            this.Controls.Add(this.tbxTreatmentInfo);
            this.Controls.Add(this.tbxSelectdPatientId);
            this.Controls.Add(this.lblSelectPatient);
            this.Controls.Add(this.dataGridViewPatients);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "CreateNewTreatment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Treatment for Existing Patient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateNewTreatment_FormClosing);
            this.Load += new System.EventHandler(this.CreateNewTreatment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Label lblSelectPatient;
        private System.Windows.Forms.TextBox tbxSelectdPatientId;
        private System.Windows.Forms.RichTextBox tbxTreatmentInfo;
        private System.Windows.Forms.RichTextBox tbxComplaints;
        private System.Windows.Forms.RichTextBox tbxTreatmentNotes;
        private System.Windows.Forms.TextBox tbxSelectedPatientName;
        private System.Windows.Forms.Button btnCreateTreatment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxEstimatedFee;
        private System.Windows.Forms.ComboBox comboBoxMoneyUnit;
        private System.Windows.Forms.Label label6;
    }
}