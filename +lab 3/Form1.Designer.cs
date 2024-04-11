namespace PatientManagement
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.btnModifyPatient = new System.Windows.Forms.Button();
            this.btnAllPatients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PATIENT MANAGEMENT";
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPatient.Location = new System.Drawing.Point(54, 131);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(270, 39);
            this.btnNewPatient.TabIndex = 1;
            this.btnNewPatient.Text = "NEW PATIENT";
            this.btnNewPatient.UseVisualStyleBackColor = true;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePatient.Location = new System.Drawing.Point(54, 176);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(270, 39);
            this.btnDeletePatient.TabIndex = 2;
            this.btnDeletePatient.Text = "DELETE PATIENT";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // btnModifyPatient
            // 
            this.btnModifyPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyPatient.Location = new System.Drawing.Point(54, 221);
            this.btnModifyPatient.Name = "btnModifyPatient";
            this.btnModifyPatient.Size = new System.Drawing.Size(270, 39);
            this.btnModifyPatient.TabIndex = 3;
            this.btnModifyPatient.Text = "MODIFY PATIENT";
            this.btnModifyPatient.UseVisualStyleBackColor = true;
            this.btnModifyPatient.Click += new System.EventHandler(this.btnModifyPatient_Click);
            // 
            // btnAllPatients
            // 
            this.btnAllPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllPatients.Location = new System.Drawing.Point(54, 266);
            this.btnAllPatients.Name = "btnAllPatients";
            this.btnAllPatients.Size = new System.Drawing.Size(270, 39);
            this.btnAllPatients.TabIndex = 4;
            this.btnAllPatients.Text = "ALL PATIENTS";
            this.btnAllPatients.UseVisualStyleBackColor = true;
            this.btnAllPatients.Click += new System.EventHandler(this.btnAllPatients_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 340);
            this.Controls.Add(this.btnAllPatients);
            this.Controls.Add(this.btnModifyPatient);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnNewPatient);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnModifyPatient;
        private System.Windows.Forms.Button btnAllPatients;
    }
}

