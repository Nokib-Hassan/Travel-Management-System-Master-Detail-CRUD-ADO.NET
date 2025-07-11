namespace NkbWork
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DestinationPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.txtDestinationPlace = new System.Windows.Forms.TextBox();
            this.dptReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dptVisitDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dptDob = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(561, 617);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 32);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(726, 617);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 32);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(31, 453);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(850, 118);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DestinationPlace,
            this.VisitDate,
            this.ReturnDate,
            this.Cost,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 98);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // DestinationPlace
            // 
            this.DestinationPlace.DataPropertyName = "DestinationPlace";
            this.DestinationPlace.HeaderText = "Destination Place";
            this.DestinationPlace.Name = "DestinationPlace";
            this.DestinationPlace.ReadOnly = true;
            // 
            // VisitDate
            // 
            this.VisitDate.DataPropertyName = "VisitDate";
            this.VisitDate.HeaderText = "Visit Date";
            this.VisitDate.Name = "VisitDate";
            this.VisitDate.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDownCost);
            this.groupBox2.Controls.Add(this.txtDestinationPlace);
            this.groupBox2.Controls.Add(this.dptReturnDate);
            this.groupBox2.Controls.Add(this.dptVisitDate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(31, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(850, 117);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Return Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Visit Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Destination Place:";
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.Location = new System.Drawing.Point(175, 69);
            this.numericUpDownCost.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(150, 23);
            this.numericUpDownCost.TabIndex = 12;
            // 
            // txtDestinationPlace
            // 
            this.txtDestinationPlace.Location = new System.Drawing.Point(175, 25);
            this.txtDestinationPlace.Multiline = true;
            this.txtDestinationPlace.Name = "txtDestinationPlace";
            this.txtDestinationPlace.Size = new System.Drawing.Size(150, 25);
            this.txtDestinationPlace.TabIndex = 9;
            // 
            // dptReturnDate
            // 
            this.dptReturnDate.Location = new System.Drawing.Point(466, 69);
            this.dptReturnDate.Name = "dptReturnDate";
            this.dptReturnDate.Size = new System.Drawing.Size(248, 23);
            this.dptReturnDate.TabIndex = 10;
            // 
            // dptVisitDate
            // 
            this.dptVisitDate.Location = new System.Drawing.Point(466, 30);
            this.dptVisitDate.Name = "dptVisitDate";
            this.dptVisitDate.Size = new System.Drawing.Size(248, 23);
            this.dptVisitDate.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(766, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 65);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.dptDob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 263);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitors";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(98, 96);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(209, 23);
            this.txtContact.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Contact:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 23);
            this.txtEmail.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Email:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(427, 94);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(209, 23);
            this.txtAddress.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Address:";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(427, 63);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(209, 23);
            this.txtGender.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Gender:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(98, 66);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(209, 23);
            this.txtAge.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Age:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(427, 32);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(209, 23);
            this.txtLastName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "LastName:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(98, 36);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(209, 23);
            this.txtFirstName.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "FirstName:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(681, 206);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(151, 41);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(681, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(327, 185);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 26);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "IsActive";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dptDob
            // 
            this.dptDob.Location = new System.Drawing.Point(427, 125);
            this.dptDob.Name = "dptDob";
            this.dptDob.Size = new System.Drawing.Size(209, 23);
            this.dptDob.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "DOB:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 693);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox3);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dptDob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCost;
        private System.Windows.Forms.TextBox txtDestinationPlace;
        private System.Windows.Forms.DateTimePicker dptReturnDate;
        private System.Windows.Forms.DateTimePicker dptVisitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}