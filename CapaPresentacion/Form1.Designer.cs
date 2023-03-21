namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtAge = new TextBox();
            txtDni = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DimGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(570, 374);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(603, 91);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(687, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 27);
            txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(687, 132);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(214, 27);
            txtSurname.TabIndex = 4;
            txtSurname.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(614, 56);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(603, 132);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "Apellido";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(687, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(687, 175);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(214, 27);
            txtAge.TabIndex = 7;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(687, 49);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(214, 27);
            txtDni.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(687, 311);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(214, 27);
            txtAddress.TabIndex = 9;
            txtAddress.TextChanged += textBox6_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(687, 264);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(214, 27);
            txtPhone.TabIndex = 10;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(603, 178);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 11;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(603, 52);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 12;
            label5.Text = "DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(603, 314);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 13;
            label6.Text = "Domicilio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(603, 267);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 14;
            label7.Text = "Teléfono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(603, 221);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 15;
            label8.Text = "Email";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.ForeColor = SystemColors.HighlightText;
            btnAdd.Location = new Point(605, 354);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(296, 36);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Agregar persona";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.ForeColor = SystemColors.HighlightText;
            btnUpdate.Location = new Point(12, 410);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 38);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Editar persona";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = SystemColors.HighlightText;
            btnDelete.Location = new Point(444, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 38);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Eliminar persona";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(913, 470);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtDni);
            Controls.Add(txtAge);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtSurname);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.DimGray;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtName;
        private TextBox txtSurname;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtAge;
        private TextBox txtDni;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}