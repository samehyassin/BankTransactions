﻿namespace BankTransactions.Forms
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpTitle = new System.Windows.Forms.TextBox();
            this.txtEmpMobile = new System.Windows.Forms.TextBox();
            this.chbIsActive = new System.Windows.Forms.CheckBox();
            this.btnEmpClose = new System.Windows.Forms.Button();
            this.btnEmpDelete = new System.Windows.Forms.Button();
            this.btnEmpEdit = new System.Windows.Forms.Button();
            this.btnEmpSave = new System.Windows.Forms.Button();
            this.picbxEmpClose = new System.Windows.Forms.PictureBox();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxEmpClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(285, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(112, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Is Active";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(174, 103);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(195, 30);
            this.txtEmpName.TabIndex = 5;
            // 
            // txtEmpTitle
            // 
            this.txtEmpTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpTitle.Location = new System.Drawing.Point(174, 142);
            this.txtEmpTitle.Name = "txtEmpTitle";
            this.txtEmpTitle.Size = new System.Drawing.Size(195, 30);
            this.txtEmpTitle.TabIndex = 6;
            // 
            // txtEmpMobile
            // 
            this.txtEmpMobile.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpMobile.Location = new System.Drawing.Point(174, 184);
            this.txtEmpMobile.Name = "txtEmpMobile";
            this.txtEmpMobile.Size = new System.Drawing.Size(195, 30);
            this.txtEmpMobile.TabIndex = 7;
            // 
            // chbIsActive
            // 
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chbIsActive.Location = new System.Drawing.Point(203, 231);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(48, 23);
            this.chbIsActive.TabIndex = 8;
            this.chbIsActive.Text = "No";
            this.chbIsActive.UseVisualStyleBackColor = true;
            // 
            // btnEmpClose
            // 
            this.btnEmpClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnEmpClose.ForeColor = System.Drawing.Color.Red;
            this.btnEmpClose.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpClose.Image")));
            this.btnEmpClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpClose.Location = new System.Drawing.Point(499, 269);
            this.btnEmpClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpClose.Name = "btnEmpClose";
            this.btnEmpClose.Size = new System.Drawing.Size(112, 42);
            this.btnEmpClose.TabIndex = 22;
            this.btnEmpClose.Text = "Close";
            this.btnEmpClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpClose.UseVisualStyleBackColor = true;
            this.btnEmpClose.Click += new System.EventHandler(this.btnEmpClose_Click);
            // 
            // btnEmpDelete
            // 
            this.btnEmpDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnEmpDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpDelete.Image")));
            this.btnEmpDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpDelete.Location = new System.Drawing.Point(357, 269);
            this.btnEmpDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpDelete.Name = "btnEmpDelete";
            this.btnEmpDelete.Size = new System.Drawing.Size(112, 42);
            this.btnEmpDelete.TabIndex = 21;
            this.btnEmpDelete.Text = "Delete";
            this.btnEmpDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpDelete.UseVisualStyleBackColor = true;
            this.btnEmpDelete.Click += new System.EventHandler(this.btnEmpDelete_Click);
            // 
            // btnEmpEdit
            // 
            this.btnEmpEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnEmpEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpEdit.Image")));
            this.btnEmpEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpEdit.Location = new System.Drawing.Point(226, 269);
            this.btnEmpEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpEdit.Name = "btnEmpEdit";
            this.btnEmpEdit.Size = new System.Drawing.Size(112, 42);
            this.btnEmpEdit.TabIndex = 20;
            this.btnEmpEdit.Text = "Edit";
            this.btnEmpEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpEdit.UseVisualStyleBackColor = true;
            this.btnEmpEdit.Click += new System.EventHandler(this.btnEmpEdit_Click);
            // 
            // btnEmpSave
            // 
            this.btnEmpSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnEmpSave.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpSave.Image")));
            this.btnEmpSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpSave.Location = new System.Drawing.Point(94, 269);
            this.btnEmpSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpSave.Name = "btnEmpSave";
            this.btnEmpSave.Size = new System.Drawing.Size(112, 42);
            this.btnEmpSave.TabIndex = 19;
            this.btnEmpSave.Text = "Save";
            this.btnEmpSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpSave.UseVisualStyleBackColor = true;
            this.btnEmpSave.Click += new System.EventHandler(this.btnEmpSave_Click);
            // 
            // picbxEmpClose
            // 
            this.picbxEmpClose.Image = ((System.Drawing.Image)(resources.GetObject("picbxEmpClose.Image")));
            this.picbxEmpClose.Location = new System.Drawing.Point(808, 12);
            this.picbxEmpClose.Name = "picbxEmpClose";
            this.picbxEmpClose.Size = new System.Drawing.Size(30, 30);
            this.picbxEmpClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbxEmpClose.TabIndex = 23;
            this.picbxEmpClose.TabStop = false;
            this.picbxEmpClose.Click += new System.EventHandler(this.picbxEmpClose_Click);
            // 
            // dgvEmp
            // 
            this.dgvEmp.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(417, 83);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.Size = new System.Drawing.Size(395, 169);
            this.dgvEmp.TabIndex = 24;
            this.dgvEmp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 341);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.picbxEmpClose);
            this.Controls.Add(this.btnEmpClose);
            this.Controls.Add(this.btnEmpDelete);
            this.Controls.Add(this.btnEmpEdit);
            this.Controls.Add(this.btnEmpSave);
            this.Controls.Add(this.chbIsActive);
            this.Controls.Add(this.txtEmpMobile);
            this.Controls.Add(this.txtEmpTitle);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees Form";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxEmpClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpTitle;
        private System.Windows.Forms.TextBox txtEmpMobile;
        private System.Windows.Forms.CheckBox chbIsActive;
        private System.Windows.Forms.Button btnEmpClose;
        private System.Windows.Forms.Button btnEmpDelete;
        private System.Windows.Forms.Button btnEmpEdit;
        private System.Windows.Forms.Button btnEmpSave;
        private System.Windows.Forms.PictureBox picbxEmpClose;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}