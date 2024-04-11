namespace PatientManagement
{
    partial class DeletePatientForm
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
            this.textBoxOib = new System.Windows.Forms.TextBox();
            this.bottunDelete = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "OIB:";
            // 
            // textBoxOib
            // 
            this.textBoxOib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxOib.Location = new System.Drawing.Point(82, 28);
            this.textBoxOib.Name = "textBoxOib";
            this.textBoxOib.Size = new System.Drawing.Size(202, 26);
            this.textBoxOib.TabIndex = 1;
            // 
            // bottunDelete
            // 
            this.bottunDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bottunDelete.Location = new System.Drawing.Point(39, 78);
            this.bottunDelete.Name = "bottunDelete";
            this.bottunDelete.Size = new System.Drawing.Size(245, 36);
            this.bottunDelete.TabIndex = 2;
            this.bottunDelete.Text = "DELETE PATIENT";
            this.bottunDelete.UseVisualStyleBackColor = true;
            this.bottunDelete.Click += new System.EventHandler(this.bottunDelete_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(12, 118);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 20);
            this.labelError.TabIndex = 3;
            // 
            // DeletePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 147);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.bottunDelete);
            this.Controls.Add(this.textBoxOib);
            this.Controls.Add(this.label1);
            this.Name = "DeletePatientForm";
            this.Text = "DeletePatientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOib;
        private System.Windows.Forms.Button bottunDelete;
        private System.Windows.Forms.Label labelError;
    }
}