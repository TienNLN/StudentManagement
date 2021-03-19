namespace Lab_Group
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtColumnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnStudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnStudentDoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnStudentSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnStudentMajorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txt_boxStudentID = new System.Windows.Forms.TextBox();
            this.txt_boxSurname = new System.Windows.Forms.TextBox();
            this.txt_boxName = new System.Windows.Forms.TextBox();
            this.txt_boxMajorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboboxSex = new System.Windows.Forms.ComboBox();
            this.datePickerDOB = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtColumnStudentID,
            this.txtColumnStudentSurname,
            this.txtColumnStudentName,
            this.txtColumnStudentDoB,
            this.txtColumnStudentSex,
            this.txtColumnStudentMajorID});
            this.dataGridView.Location = new System.Drawing.Point(1, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(643, 426);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // txtColumnStudentID
            // 
            this.txtColumnStudentID.HeaderText = "Student ID";
            this.txtColumnStudentID.Name = "txtColumnStudentID";
            this.txtColumnStudentID.ReadOnly = true;
            // 
            // txtColumnStudentSurname
            // 
            this.txtColumnStudentSurname.HeaderText = "Surname";
            this.txtColumnStudentSurname.Name = "txtColumnStudentSurname";
            this.txtColumnStudentSurname.ReadOnly = true;
            // 
            // txtColumnStudentName
            // 
            this.txtColumnStudentName.HeaderText = "Name";
            this.txtColumnStudentName.Name = "txtColumnStudentName";
            this.txtColumnStudentName.ReadOnly = true;
            // 
            // txtColumnStudentDoB
            // 
            this.txtColumnStudentDoB.HeaderText = "Date of Birth";
            this.txtColumnStudentDoB.Name = "txtColumnStudentDoB";
            this.txtColumnStudentDoB.ReadOnly = true;
            // 
            // txtColumnStudentSex
            // 
            this.txtColumnStudentSex.HeaderText = "Sex";
            this.txtColumnStudentSex.Name = "txtColumnStudentSex";
            this.txtColumnStudentSex.ReadOnly = true;
            // 
            // txtColumnStudentMajorID
            // 
            this.txtColumnStudentMajorID.HeaderText = "Major ID";
            this.txtColumnStudentMajorID.Name = "txtColumnStudentMajorID";
            this.txtColumnStudentMajorID.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(717, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(866, 334);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(1000, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(717, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(866, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1000, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txt_boxStudentID
            // 
            this.txt_boxStudentID.Enabled = false;
            this.txt_boxStudentID.Location = new System.Drawing.Point(806, 12);
            this.txt_boxStudentID.Name = "txt_boxStudentID";
            this.txt_boxStudentID.Size = new System.Drawing.Size(269, 20);
            this.txt_boxStudentID.TabIndex = 7;
            // 
            // txt_boxSurname
            // 
            this.txt_boxSurname.Enabled = false;
            this.txt_boxSurname.Location = new System.Drawing.Point(806, 57);
            this.txt_boxSurname.Name = "txt_boxSurname";
            this.txt_boxSurname.Size = new System.Drawing.Size(269, 20);
            this.txt_boxSurname.TabIndex = 8;
            // 
            // txt_boxName
            // 
            this.txt_boxName.Enabled = false;
            this.txt_boxName.Location = new System.Drawing.Point(806, 102);
            this.txt_boxName.Name = "txt_boxName";
            this.txt_boxName.Size = new System.Drawing.Size(269, 20);
            this.txt_boxName.TabIndex = 9;
            // 
            // txt_boxMajorID
            // 
            this.txt_boxMajorID.Enabled = false;
            this.txt_boxMajorID.Location = new System.Drawing.Point(806, 246);
            this.txt_boxMajorID.Name = "txt_boxMajorID";
            this.txt_boxMajorID.Size = new System.Drawing.Size(269, 20);
            this.txt_boxMajorID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(700, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sex:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Major ID:";
            // 
            // comboboxSex
            // 
            this.comboboxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxSex.Enabled = false;
            this.comboboxSex.FormattingEnabled = true;
            this.comboboxSex.Location = new System.Drawing.Point(806, 198);
            this.comboboxSex.Name = "comboboxSex";
            this.comboboxSex.Size = new System.Drawing.Size(135, 21);
            this.comboboxSex.TabIndex = 19;
            this.comboboxSex.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // datePickerDOB
            // 
            this.datePickerDOB.Enabled = false;
            this.datePickerDOB.Location = new System.Drawing.Point(806, 151);
            this.datePickerDOB.Name = "datePickerDOB";
            this.datePickerDOB.Size = new System.Drawing.Size(200, 20);
            this.datePickerDOB.TabIndex = 20;
            this.datePickerDOB.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 450);
            this.Controls.Add(this.datePickerDOB);
            this.Controls.Add(this.comboboxSex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_boxMajorID);
            this.Controls.Add(this.txt_boxName);
            this.Controls.Add(this.txt_boxSurname);
            this.Controls.Add(this.txt_boxStudentID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnStudentSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnStudentDoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnStudentSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnStudentMajorID;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txt_boxStudentID;
        private System.Windows.Forms.TextBox txt_boxSurname;
        private System.Windows.Forms.TextBox txt_boxName;
        private System.Windows.Forms.TextBox txt_boxMajorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboboxSex;
        private System.Windows.Forms.DateTimePicker datePickerDOB;
    }
}

