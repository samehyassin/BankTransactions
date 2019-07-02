namespace BankTransactions.Forms
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.chbIsActive = new System.Windows.Forms.CheckBox();
            this.btnEmpClose = new System.Windows.Forms.Button();
            this.btnEmpDelete = new System.Windows.Forms.Button();
            this.btnEmpEdit = new System.Windows.Forms.Button();
            this.btnEmpSave = new System.Windows.Forms.Button();
            this.picbxEmpClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxEmpClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(157, 22);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(174, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 30);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(174, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 30);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(174, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 30);
            this.textBox3.TabIndex = 7;
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
            this.btnEmpClose.Location = new System.Drawing.Point(417, 271);
            this.btnEmpClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpClose.Name = "btnEmpClose";
            this.btnEmpClose.Size = new System.Drawing.Size(112, 42);
            this.btnEmpClose.TabIndex = 22;
            this.btnEmpClose.Text = "Close";
            this.btnEmpClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpClose.UseVisualStyleBackColor = true;
            // 
            // btnEmpDelete
            // 
            this.btnEmpDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnEmpDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpDelete.Image")));
            this.btnEmpDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpDelete.Location = new System.Drawing.Point(275, 271);
            this.btnEmpDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpDelete.Name = "btnEmpDelete";
            this.btnEmpDelete.Size = new System.Drawing.Size(112, 42);
            this.btnEmpDelete.TabIndex = 21;
            this.btnEmpDelete.Text = "Delete";
            this.btnEmpDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpDelete.UseVisualStyleBackColor = true;
            // 
            // btnEmpEdit
            // 
            this.btnEmpEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnEmpEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpEdit.Image")));
            this.btnEmpEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpEdit.Location = new System.Drawing.Point(144, 271);
            this.btnEmpEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpEdit.Name = "btnEmpEdit";
            this.btnEmpEdit.Size = new System.Drawing.Size(112, 42);
            this.btnEmpEdit.TabIndex = 20;
            this.btnEmpEdit.Text = "Edit";
            this.btnEmpEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpEdit.UseVisualStyleBackColor = true;
            // 
            // btnEmpSave
            // 
            this.btnEmpSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnEmpSave.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpSave.Image")));
            this.btnEmpSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpSave.Location = new System.Drawing.Point(12, 271);
            this.btnEmpSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpSave.Name = "btnEmpSave";
            this.btnEmpSave.Size = new System.Drawing.Size(112, 42);
            this.btnEmpSave.TabIndex = 19;
            this.btnEmpSave.Text = "Save";
            this.btnEmpSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpSave.UseVisualStyleBackColor = true;
            // 
            // picbxEmpClose
            // 
            this.picbxEmpClose.Image = ((System.Drawing.Image)(resources.GetObject("picbxEmpClose.Image")));
            this.picbxEmpClose.Location = new System.Drawing.Point(547, 12);
            this.picbxEmpClose.Name = "picbxEmpClose";
            this.picbxEmpClose.Size = new System.Drawing.Size(30, 30);
            this.picbxEmpClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbxEmpClose.TabIndex = 23;
            this.picbxEmpClose.TabStop = false;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 341);
            this.Controls.Add(this.picbxEmpClose);
            this.Controls.Add(this.btnEmpClose);
            this.Controls.Add(this.btnEmpDelete);
            this.Controls.Add(this.btnEmpEdit);
            this.Controls.Add(this.btnEmpSave);
            this.Controls.Add(this.chbIsActive);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees Form";
            ((System.ComponentModel.ISupportInitialize)(this.picbxEmpClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox chbIsActive;
        private System.Windows.Forms.Button btnEmpClose;
        private System.Windows.Forms.Button btnEmpDelete;
        private System.Windows.Forms.Button btnEmpEdit;
        private System.Windows.Forms.Button btnEmpSave;
        private System.Windows.Forms.PictureBox picbxEmpClose;
    }
}