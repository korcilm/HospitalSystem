
namespace MyHospitalSystem.Models
{
    partial class PatientUpdateForm
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
            this.dgw_PatientList = new System.Windows.Forms.DataGridView();
            this.cmb_bloodType = new System.Windows.Forms.ComboBox();
            this.dt_birth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_address = new System.Windows.Forms.TextBox();
            this.tbx_phone = new System.Windows.Forms.TextBox();
            this.tbx_identity = new System.Windows.Forms.TextBox();
            this.tbx_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_PatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_PatientList
            // 
            this.dgw_PatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_PatientList.Location = new System.Drawing.Point(12, 12);
            this.dgw_PatientList.Name = "dgw_PatientList";
            this.dgw_PatientList.RowTemplate.Height = 25;
            this.dgw_PatientList.Size = new System.Drawing.Size(776, 167);
            this.dgw_PatientList.TabIndex = 0;
            this.dgw_PatientList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GetPatient);
            // 
            // cmb_bloodType
            // 
            this.cmb_bloodType.FormattingEnabled = true;
            this.cmb_bloodType.Location = new System.Drawing.Point(122, 347);
            this.cmb_bloodType.Name = "cmb_bloodType";
            this.cmb_bloodType.Size = new System.Drawing.Size(200, 23);
            this.cmb_bloodType.TabIndex = 31;
            // 
            // dt_birth
            // 
            this.dt_birth.Location = new System.Drawing.Point(561, 199);
            this.dt_birth.Name = "dt_birth";
            this.dt_birth.Size = new System.Drawing.Size(200, 23);
            this.dt_birth.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Blood Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Birth Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Identity Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Surname";
            // 
            // tbx_address
            // 
            this.tbx_address.Location = new System.Drawing.Point(561, 294);
            this.tbx_address.Name = "tbx_address";
            this.tbx_address.Size = new System.Drawing.Size(200, 23);
            this.tbx_address.TabIndex = 23;
            // 
            // tbx_phone
            // 
            this.tbx_phone.Location = new System.Drawing.Point(561, 247);
            this.tbx_phone.Name = "tbx_phone";
            this.tbx_phone.Size = new System.Drawing.Size(200, 23);
            this.tbx_phone.TabIndex = 22;
            // 
            // tbx_identity
            // 
            this.tbx_identity.Location = new System.Drawing.Point(122, 297);
            this.tbx_identity.Name = "tbx_identity";
            this.tbx_identity.Size = new System.Drawing.Size(200, 23);
            this.tbx_identity.TabIndex = 21;
            // 
            // tbx_surname
            // 
            this.tbx_surname.Location = new System.Drawing.Point(122, 244);
            this.tbx_surname.Name = "tbx_surname";
            this.tbx_surname.Size = new System.Drawing.Size(200, 23);
            this.tbx_surname.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(122, 196);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(200, 23);
            this.tbx_name.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatientUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 443);
            this.Controls.Add(this.cmb_bloodType);
            this.Controls.Add(this.dt_birth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_address);
            this.Controls.Add(this.tbx_phone);
            this.Controls.Add(this.tbx_identity);
            this.Controls.Add(this.tbx_surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgw_PatientList);
            this.Name = "PatientUpdateForm";
            this.Text = "PatientUpdateForm";
            this.Load += new System.EventHandler(this.PatientUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_PatientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_PatientList;
        private System.Windows.Forms.ComboBox cmb_bloodType;
        private System.Windows.Forms.DateTimePicker dt_birth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_address;
        private System.Windows.Forms.TextBox tbx_phone;
        private System.Windows.Forms.TextBox tbx_identity;
        private System.Windows.Forms.TextBox tbx_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Button button1;
    }
}