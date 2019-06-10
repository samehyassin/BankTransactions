namespace BankTransactions
{
    partial class frmEntryForm
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
            this.btnDebt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDebt
            // 
            this.btnDebt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebt.Location = new System.Drawing.Point(116, 156);
            this.btnDebt.Name = "btnDebt";
            this.btnDebt.Size = new System.Drawing.Size(168, 59);
            this.btnDebt.TabIndex = 0;
            this.btnDebt.Text = "Debt";
            this.btnDebt.UseVisualStyleBackColor = false;
            this.btnDebt.Click += new System.EventHandler(this.btnDebt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 59);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawal.Location = new System.Drawing.Point(306, 156);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(168, 59);
            this.btnWithdrawal.TabIndex = 0;
            this.btnWithdrawal.Text = "Withdrawal";
            this.btnWithdrawal.UseVisualStyleBackColor = false;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(460, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 410);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDebt);
            this.Name = "frmEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entry Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDebt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Button btnExit;
    }
}

