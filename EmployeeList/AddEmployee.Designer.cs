
namespace EmployeeList
{
    partial class AddEmployee
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.dtpStartOccupation = new System.Windows.Forms.DateTimePicker();
            this.dtpEndOccupation = new System.Windows.Forms.DateTimePicker();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDateEnd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbHired = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(147, 21);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(200, 22);
            this.tbId.TabIndex = 0;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(147, 49);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(200, 22);
            this.tbFirstName.TabIndex = 1;
            // 
            // dtpStartOccupation
            // 
            this.dtpStartOccupation.Location = new System.Drawing.Point(147, 103);
            this.dtpStartOccupation.Name = "dtpStartOccupation";
            this.dtpStartOccupation.Size = new System.Drawing.Size(200, 22);
            this.dtpStartOccupation.TabIndex = 4;
            // 
            // dtpEndOccupation
            // 
            this.dtpEndOccupation.Location = new System.Drawing.Point(147, 131);
            this.dtpEndOccupation.Name = "dtpEndOccupation";
            this.dtpEndOccupation.Size = new System.Drawing.Size(200, 22);
            this.dtpEndOccupation.TabIndex = 5;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(147, 77);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(200, 22);
            this.tbLastName.TabIndex = 6;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(147, 159);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(200, 22);
            this.tbSalary.TabIndex = 7;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(12, 24);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(89, 17);
            this.lbId.TabIndex = 8;
            this.lbId.Text = "Identyfikator:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data Zatrudnienia:";
            // 
            // lbDateEnd
            // 
            this.lbDateEnd.AutoSize = true;
            this.lbDateEnd.Location = new System.Drawing.Point(12, 136);
            this.lbDateEnd.Name = "lbDateEnd";
            this.lbDateEnd.Size = new System.Drawing.Size(113, 17);
            this.lbDateEnd.TabIndex = 12;
            this.lbDateEnd.Text = "Data Zwolnienia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Zarobki:";
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(147, 221);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(200, 101);
            this.rtbComments.TabIndex = 14;
            this.rtbComments.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Uwagi:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(147, 328);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(99, 40);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 40);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbHired
            // 
            this.cbHired.AutoSize = true;
            this.cbHired.Location = new System.Drawing.Point(147, 190);
            this.cbHired.Name = "cbHired";
            this.cbHired.Size = new System.Drawing.Size(148, 21);
            this.cbHired.TabIndex = 18;
            this.cbHired.Text = "Aktywny pracownik";
            this.cbHired.UseVisualStyleBackColor = true;
            this.cbHired.CheckedChanged += new System.EventHandler(this.cbHired_CheckedChanged);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 373);
            this.Controls.Add(this.cbHired);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbDateEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.dtpEndOccupation);
            this.Controls.Add(this.dtpStartOccupation);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbId);
            this.MaximumSize = new System.Drawing.Size(380, 420);
            this.MinimumSize = new System.Drawing.Size(380, 420);
            this.Name = "AddEmployee";
            this.Text = "Dodaj Pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.DateTimePicker dtpStartOccupation;
        private System.Windows.Forms.DateTimePicker dtpEndOccupation;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDateEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbHired;
    }
}