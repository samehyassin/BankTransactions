namespace BankTransactions.Forms
{
    partial class frmWithdrawalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWithdrawalForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnwthClose = new System.Windows.Forms.Button();
            this.btnwthDelete = new System.Windows.Forms.Button();
            this.btnwthUpdate = new System.Windows.Forms.Button();
            this.btnwthSave = new System.Windows.Forms.Button();
            this.dtpWthDate = new System.Windows.Forms.DateTimePicker();
            this.txtWthAmount = new System.Windows.Forms.TextBox();
            this.txtWthRefNumber = new System.Windows.Forms.TextBox();
            this.txtWthNote = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxwthEmployeeName = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(348, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cash Withdrawal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Withdrawal Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(34, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Withdrawal Ref Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(526, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Employee Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(526, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Note";
            // 
            // btnwthClose
            // 
            this.btnwthClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwthClose.ForeColor = System.Drawing.Color.Red;
            this.btnwthClose.Location = new System.Drawing.Point(440, 334);
            this.btnwthClose.Name = "btnwthClose";
            this.btnwthClose.Size = new System.Drawing.Size(115, 36);
            this.btnwthClose.TabIndex = 36;
            this.btnwthClose.Text = "Close";
            this.btnwthClose.UseVisualStyleBackColor = true;
            this.btnwthClose.Click += new System.EventHandler(this.btnwthClose_Click);
            // 
            // btnwthDelete
            // 
            this.btnwthDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwthDelete.Location = new System.Drawing.Point(317, 334);
            this.btnwthDelete.Name = "btnwthDelete";
            this.btnwthDelete.Size = new System.Drawing.Size(115, 36);
            this.btnwthDelete.TabIndex = 35;
            this.btnwthDelete.Text = "Delete";
            this.btnwthDelete.UseVisualStyleBackColor = true;
            // 
            // btnwthUpdate
            // 
            this.btnwthUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwthUpdate.Location = new System.Drawing.Point(194, 334);
            this.btnwthUpdate.Name = "btnwthUpdate";
            this.btnwthUpdate.Size = new System.Drawing.Size(115, 36);
            this.btnwthUpdate.TabIndex = 34;
            this.btnwthUpdate.Text = "Update";
            this.btnwthUpdate.UseVisualStyleBackColor = true;
            // 
            // btnwthSave
            // 
            this.btnwthSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwthSave.Location = new System.Drawing.Point(71, 334);
            this.btnwthSave.Name = "btnwthSave";
            this.btnwthSave.Size = new System.Drawing.Size(115, 36);
            this.btnwthSave.TabIndex = 33;
            this.btnwthSave.Text = "Save";
            this.btnwthSave.UseVisualStyleBackColor = true;
            // 
            // dtpWthDate
            // 
            this.dtpWthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpWthDate.Location = new System.Drawing.Point(277, 128);
            this.dtpWthDate.Name = "dtpWthDate";
            this.dtpWthDate.Size = new System.Drawing.Size(217, 26);
            this.dtpWthDate.TabIndex = 37;
            // 
            // txtWthAmount
            // 
            this.txtWthAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtWthAmount.Location = new System.Drawing.Point(277, 172);
            this.txtWthAmount.Name = "txtWthAmount";
            this.txtWthAmount.Size = new System.Drawing.Size(217, 26);
            this.txtWthAmount.TabIndex = 38;
            // 
            // txtWthRefNumber
            // 
            this.txtWthRefNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtWthRefNumber.Location = new System.Drawing.Point(277, 209);
            this.txtWthRefNumber.Name = "txtWthRefNumber";
            this.txtWthRefNumber.Size = new System.Drawing.Size(217, 26);
            this.txtWthRefNumber.TabIndex = 39;
            // 
            // txtWthNote
            // 
            this.txtWthNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtWthNote.Location = new System.Drawing.Point(697, 172);
            this.txtWthNote.Multiline = true;
            this.txtWthNote.Name = "txtWthNote";
            this.txtWthNote.Size = new System.Drawing.Size(217, 108);
            this.txtWthNote.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // cbxwthEmployeeName
            // 
            this.cbxwthEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxwthEmployeeName.FormattingEnabled = true;
            this.cbxwthEmployeeName.Location = new System.Drawing.Point(697, 130);
            this.cbxwthEmployeeName.Name = "cbxwthEmployeeName";
            this.cbxwthEmployeeName.Size = new System.Drawing.Size(217, 28);
            this.cbxwthEmployeeName.TabIndex = 43;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(881, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(927, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // frmWithdrawalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 445);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cbxwthEmployeeName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtWthNote);
            this.Controls.Add(this.txtWthRefNumber);
            this.Controls.Add(this.txtWthAmount);
            this.Controls.Add(this.dtpWthDate);
            this.Controls.Add(this.btnwthClose);
            this.Controls.Add(this.btnwthDelete);
            this.Controls.Add(this.btnwthUpdate);
            this.Controls.Add(this.btnwthSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWithdrawalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdrawal Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnwthClose;
        private System.Windows.Forms.Button btnwthDelete;
        private System.Windows.Forms.Button btnwthUpdate;
        private System.Windows.Forms.Button btnwthSave;
        private System.Windows.Forms.DateTimePicker dtpWthDate;
        private System.Windows.Forms.TextBox txtWthAmount;
        private System.Windows.Forms.TextBox txtWthRefNumber;
        private System.Windows.Forms.TextBox txtWthNote;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxwthEmployeeName;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}