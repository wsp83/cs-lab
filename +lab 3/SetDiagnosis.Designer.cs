namespace PatientManagement
{
    partial class SetDiagnosis
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
            this.labelOib = new System.Windows.Forms.Label();
            this.labelMbo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelOldDiagnosis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDiagnosis = new System.Windows.Forms.ComboBox();
            this.labelNewDiagnosis = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOib
            // 
            this.labelOib.AutoSize = true;
            this.labelOib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOib.Location = new System.Drawing.Point(13, 13);
            this.labelOib.Name = "labelOib";
            this.labelOib.Size = new System.Drawing.Size(45, 20);
            this.labelOib.TabIndex = 0;
            this.labelOib.Text = "OIB: ";
            // 
            // labelMbo
            // 
            this.labelMbo.AutoSize = true;
            this.labelMbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMbo.Location = new System.Drawing.Point(13, 47);
            this.labelMbo.Name = "labelMbo";
            this.labelMbo.Size = new System.Drawing.Size(53, 20);
            this.labelMbo.TabIndex = 1;
            this.labelMbo.Text = "MBO: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(13, 82);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name: ";
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDob.Location = new System.Drawing.Point(13, 119);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(107, 20);
            this.labelDob.TabIndex = 3;
            this.labelDob.Text = "Date of Birth: ";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(13, 159);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(44, 20);
            this.labelSex.TabIndex = 4;
            this.labelSex.Text = "Sex: ";
            // 
            // labelOldDiagnosis
            // 
            this.labelOldDiagnosis.AutoSize = true;
            this.labelOldDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldDiagnosis.Location = new System.Drawing.Point(13, 195);
            this.labelOldDiagnosis.Name = "labelOldDiagnosis";
            this.labelOldDiagnosis.Size = new System.Drawing.Size(112, 20);
            this.labelOldDiagnosis.TabIndex = 5;
            this.labelOldDiagnosis.Text = "Old diagnosis: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "New diagnosis: ";
            // 
            // comboBoxDiagnosis
            // 
            this.comboBoxDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDiagnosis.FormattingEnabled = true;
            this.comboBoxDiagnosis.Items.AddRange(new object[] {
            "A00",
            "A01",
            "A02",
            "A03",
            "A04",
            "A05",
            "A06",
            "A07",
            "A08",
            "A09"});
            this.comboBoxDiagnosis.Location = new System.Drawing.Point(151, 288);
            this.comboBoxDiagnosis.Name = "comboBoxDiagnosis";
            this.comboBoxDiagnosis.Size = new System.Drawing.Size(69, 28);
            this.comboBoxDiagnosis.TabIndex = 7;
            this.comboBoxDiagnosis.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiagnosis_SelectedIndexChanged);
            // 
            // labelNewDiagnosis
            // 
            this.labelNewDiagnosis.AutoSize = true;
            this.labelNewDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewDiagnosis.Location = new System.Drawing.Point(242, 291);
            this.labelNewDiagnosis.Name = "labelNewDiagnosis";
            this.labelNewDiagnosis.Size = new System.Drawing.Size(0, 20);
            this.labelNewDiagnosis.TabIndex = 8;
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(12, 374);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(473, 54);
            this.buttonChange.TabIndex = 9;
            this.buttonChange.Text = "CHANGE DIAGNOSIS";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // SetDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.labelNewDiagnosis);
            this.Controls.Add(this.comboBoxDiagnosis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOldDiagnosis);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelDob);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelMbo);
            this.Controls.Add(this.labelOib);
            this.Name = "SetDiagnosis";
            this.Text = "SetDiagnosis";
            this.Load += new System.EventHandler(this.SetDiagnosis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOib;
        private System.Windows.Forms.Label labelMbo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelOldDiagnosis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDiagnosis;
        private System.Windows.Forms.Label labelNewDiagnosis;
        private System.Windows.Forms.Button buttonChange;
    }
}