namespace DentalApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pagePatients = new System.Windows.Forms.TabPage();
            this.createNewPatient = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.tabTreatments = new System.Windows.Forms.TabPage();
            this.btnCreateNewTreatment = new System.Windows.Forms.Button();
            this.dataGridViewTreatments = new System.Windows.Forms.DataGridView();
            this.pageAppointments = new System.Windows.Forms.TabPage();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.pagePatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.tabTreatments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatments)).BeginInit();
            this.pageAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pagePatients);
            this.tabControl1.Controls.Add(this.tabTreatments);
            this.tabControl1.Controls.Add(this.pageAppointments);
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(68, 116);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1136, 506);
            this.tabControl1.TabIndex = 1;
            // 
            // pagePatients
            // 
            this.pagePatients.Controls.Add(this.createNewPatient);
            this.pagePatients.Controls.Add(this.dataGridViewPatients);
            this.pagePatients.Location = new System.Drawing.Point(4, 38);
            this.pagePatients.Name = "pagePatients";
            this.pagePatients.Padding = new System.Windows.Forms.Padding(3);
            this.pagePatients.Size = new System.Drawing.Size(1128, 464);
            this.pagePatients.TabIndex = 1;
            this.pagePatients.Text = "Patients";
            this.pagePatients.UseVisualStyleBackColor = true;
            // 
            // createNewPatient
            // 
            this.createNewPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.createNewPatient.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createNewPatient.Location = new System.Drawing.Point(943, 12);
            this.createNewPatient.Name = "createNewPatient";
            this.createNewPatient.Size = new System.Drawing.Size(171, 35);
            this.createNewPatient.TabIndex = 5;
            this.createNewPatient.Text = "Create New Patient";
            this.createNewPatient.UseVisualStyleBackColor = false;
            this.createNewPatient.Click += new System.EventHandler(this.createNewPatient_Click);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(14, 53);
            this.dataGridViewPatients.MultiSelect = false;
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(1100, 375);
            this.dataGridViewPatients.TabIndex = 4;
            this.dataGridViewPatients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellDoubleClick);
            // 
            // tabTreatments
            // 
            this.tabTreatments.Controls.Add(this.btnCreateNewTreatment);
            this.tabTreatments.Controls.Add(this.dataGridViewTreatments);
            this.tabTreatments.Location = new System.Drawing.Point(4, 38);
            this.tabTreatments.Name = "tabTreatments";
            this.tabTreatments.Padding = new System.Windows.Forms.Padding(3);
            this.tabTreatments.Size = new System.Drawing.Size(1128, 464);
            this.tabTreatments.TabIndex = 3;
            this.tabTreatments.Text = "Treatments";
            this.tabTreatments.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewTreatment
            // 
            this.btnCreateNewTreatment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.btnCreateNewTreatment.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateNewTreatment.Location = new System.Drawing.Point(902, 12);
            this.btnCreateNewTreatment.Name = "btnCreateNewTreatment";
            this.btnCreateNewTreatment.Size = new System.Drawing.Size(212, 35);
            this.btnCreateNewTreatment.TabIndex = 22;
            this.btnCreateNewTreatment.Text = "Create New Treatment";
            this.btnCreateNewTreatment.UseVisualStyleBackColor = false;
            this.btnCreateNewTreatment.Click += new System.EventHandler(this.btnCreateNewTreatment_Click);
            // 
            // dataGridViewTreatments
            // 
            this.dataGridViewTreatments.AllowUserToAddRows = false;
            this.dataGridViewTreatments.AllowUserToDeleteRows = false;
            this.dataGridViewTreatments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTreatments.Location = new System.Drawing.Point(14, 53);
            this.dataGridViewTreatments.MultiSelect = false;
            this.dataGridViewTreatments.Name = "dataGridViewTreatments";
            this.dataGridViewTreatments.ReadOnly = true;
            this.dataGridViewTreatments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTreatments.Size = new System.Drawing.Size(1100, 375);
            this.dataGridViewTreatments.TabIndex = 16;
            this.dataGridViewTreatments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTreatments_CellDoubleClick);
            // 
            // pageAppointments
            // 
            this.pageAppointments.Controls.Add(this.dataGridViewAppointments);
            this.pageAppointments.Location = new System.Drawing.Point(4, 38);
            this.pageAppointments.Name = "pageAppointments";
            this.pageAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.pageAppointments.Size = new System.Drawing.Size(1128, 464);
            this.pageAppointments.TabIndex = 0;
            this.pageAppointments.Text = "Appointments";
            this.pageAppointments.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.AllowUserToAddRows = false;
            this.dataGridViewAppointments.AllowUserToDeleteRows = false;
            this.dataGridViewAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(14, 53);
            this.dataGridViewAppointments.MultiSelect = false;
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.ReadOnly = true;
            this.dataGridViewAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(1100, 375);
            this.dataGridViewAppointments.TabIndex = 0;
            this.dataGridViewAppointments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointments_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "OralExpert";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoctorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.lblDoctorName.Location = new System.Drawing.Point(260, 58);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(124, 33);
            this.lblDoctorName.TabIndex = 3;
            this.lblDoctorName.Text = "Dt. John Doe";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeveloper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.lblDeveloper.Location = new System.Drawing.Point(1145, 647);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(107, 25);
            this.lblDeveloper.TabIndex = 4;
            this.lblDeveloper.Text = "BUR Software";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.lblDate.Location = new System.Drawing.Point(980, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(206, 33);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "14 Feb 2022 Saturday";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.lblTime.Location = new System.Drawing.Point(1037, 80);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 33);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "23:10:56";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.Location = new System.Drawing.Point(576, 631);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(148, 41);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh Tables";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.pagePatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.tabTreatments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatments)).EndInit();
            this.pageAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageAppointments;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.TabPage pagePatients;
        private System.Windows.Forms.Button createNewPatient;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabTreatments;
        private System.Windows.Forms.DataGridView dataGridViewTreatments;
        private System.Windows.Forms.Button btnCreateNewTreatment;
        private System.Windows.Forms.Button btnRefresh;
    }
}

