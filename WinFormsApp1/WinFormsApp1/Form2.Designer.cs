namespace WinFormsApp1
{
    partial class Form2
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
            this.User = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.Repass = new System.Windows.Forms.Label();
            this.TxtRepass = new System.Windows.Forms.TextBox();
            this.UserType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateuser = new System.Windows.Forms.Button();
            this.searchbyUser = new System.Windows.Forms.Label();
            this.TxtSearchbyUser = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(178, 34);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(75, 20);
            this.User.TabIndex = 0;
            this.User.Text = "Username";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(183, 83);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(70, 20);
            this.Pass.TabIndex = 1;
            this.Pass.Text = "Password";
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtUser.Location = new System.Drawing.Point(285, 34);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(195, 27);
            this.TxtUser.TabIndex = 0;
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtPass.Location = new System.Drawing.Point(285, 83);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(195, 27);
            this.TxtPass.TabIndex = 1;
            // 
            // Repass
            // 
            this.Repass.AutoSize = true;
            this.Repass.Location = new System.Drawing.Point(133, 132);
            this.Repass.Name = "Repass";
            this.Repass.Size = new System.Drawing.Size(120, 20);
            this.Repass.TabIndex = 4;
            this.Repass.Text = "Retype Password";
            this.Repass.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtRepass
            // 
            this.TxtRepass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtRepass.Location = new System.Drawing.Point(285, 132);
            this.TxtRepass.Name = "TxtRepass";
            this.TxtRepass.Size = new System.Drawing.Size(195, 27);
            this.TxtRepass.TabIndex = 2;
            // 
            // UserType
            // 
            this.UserType.AutoSize = true;
            this.UserType.Location = new System.Drawing.Point(186, 181);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(67, 20);
            this.UserType.TabIndex = 6;
            this.UserType.Text = "Usertype";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.comboBox1.Location = new System.Drawing.Point(285, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(139, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(517, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(391, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateuser
            // 
            this.btnCreateuser.Location = new System.Drawing.Point(265, 236);
            this.btnCreateuser.Name = "btnCreateuser";
            this.btnCreateuser.Size = new System.Drawing.Size(94, 29);
            this.btnCreateuser.TabIndex = 5;
            this.btnCreateuser.Text = "Create User";
            this.btnCreateuser.UseVisualStyleBackColor = true;
            this.btnCreateuser.Click += new System.EventHandler(this.btnCreateuser_Click);
            // 
            // searchbyUser
            // 
            this.searchbyUser.AutoSize = true;
            this.searchbyUser.Location = new System.Drawing.Point(133, 296);
            this.searchbyUser.Name = "searchbyUser";
            this.searchbyUser.Size = new System.Drawing.Size(143, 20);
            this.searchbyUser.TabIndex = 13;
            this.searchbyUser.Text = "Search by Username";
            // 
            // TxtSearchbyUser
            // 
            this.TxtSearchbyUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtSearchbyUser.Location = new System.Drawing.Point(285, 289);
            this.TxtSearchbyUser.Name = "TxtSearchbyUser";
            this.TxtSearchbyUser.Size = new System.Drawing.Size(195, 27);
            this.TxtSearchbyUser.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(511, 188);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(78, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 543);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Login";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtSearchbyUser);
            this.Controls.Add(this.searchbyUser);
            this.Controls.Add(this.btnCreateuser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.TxtRepass);
            this.Controls.Add(this.Repass);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.User);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label User;
        private Label Pass;
        private TextBox TxtUser;
        private TextBox TxtPass;
        private Label Repass;
        private TextBox TxtRepass;
        private Label UserType;
        private ComboBox comboBox1;
        private Button btnSave;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnCreateuser;
        private Label searchbyUser;
        private TextBox TxtSearchbyUser;
        private DataGridView dataGridView1;
        private Label label1;
        private GroupBox groupBox1;
    }
}