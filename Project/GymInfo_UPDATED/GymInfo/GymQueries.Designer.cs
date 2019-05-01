namespace GymInfo
{
    partial class GymQueries
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
            this.clubExpBtn = new System.Windows.Forms.Button();
            this.clubDataSet1 = new GymInfo.ClubDataSet();
            this.clubTableAdapter1 = new GymInfo.ClubDataSetTableAdapters.CLUBTableAdapter();
            this.tableAdapterManager = new GymInfo.ClubDataSetTableAdapters.TableAdapterManager();
            this.tablesComboBox = new System.Windows.Forms.ComboBox();
            this.membershipCostBtn = new System.Windows.Forms.Button();
            this.membershipTableAdapter1 = new GymInfo.MembershipDataSetTableAdapters.MEMBERSHIPTableAdapter();
            this.membershipDataSet1 = new GymInfo.MembershipDataSet();
            this.employeeTableAdapter1 = new GymInfo.EmployeeDataSetTableAdapters.EMPLOYEETableAdapter();
            this.employeeDataSet1 = new GymInfo.EmployeeDataSet();
            this.employeeCostBtn = new System.Windows.Forms.Button();
            this.classRevBtn = new System.Windows.Forms.Button();
            this.classDataSet1 = new GymInfo.ClassDataSet();
            this.classTableAdapter1 = new GymInfo.ClassDataSetTableAdapters.CLASSTableAdapter();
            this.memberTotalBtn = new System.Windows.Forms.Button();
            this.memberDataSet1 = new GymInfo.MemberDataSet();
            this.memberTableAdapter1 = new GymInfo.MemberDataSetTableAdapters.MEMBERTableAdapter();
            this.noiBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clubDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // clubExpBtn
            // 
            this.clubExpBtn.Location = new System.Drawing.Point(560, 181);
            this.clubExpBtn.Name = "clubExpBtn";
            this.clubExpBtn.Size = new System.Drawing.Size(131, 73);
            this.clubExpBtn.TabIndex = 0;
            this.clubExpBtn.Text = "Total Club Expenses";
            this.clubExpBtn.UseVisualStyleBackColor = true;
            this.clubExpBtn.Visible = false;
            this.clubExpBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // clubDataSet1
            // 
            this.clubDataSet1.DataSetName = "ClubDataSet";
            this.clubDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubTableAdapter1
            // 
            this.clubTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLUBTableAdapter = this.clubTableAdapter1;
            this.tableAdapterManager.UpdateOrder = GymInfo.ClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tablesComboBox
            // 
            this.tablesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesComboBox.FormattingEnabled = true;
            this.tablesComboBox.Items.AddRange(new object[] {
            "Class",
            "Club",
            "Employee",
            "Member",
            "Membership",
            "Gym"});
            this.tablesComboBox.Location = new System.Drawing.Point(57, 197);
            this.tablesComboBox.Name = "tablesComboBox";
            this.tablesComboBox.Size = new System.Drawing.Size(218, 37);
            this.tablesComboBox.TabIndex = 2;
            this.tablesComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // membershipCostBtn
            // 
            this.membershipCostBtn.Location = new System.Drawing.Point(560, 181);
            this.membershipCostBtn.Name = "membershipCostBtn";
            this.membershipCostBtn.Size = new System.Drawing.Size(131, 73);
            this.membershipCostBtn.TabIndex = 3;
            this.membershipCostBtn.Text = "Total Membership Cost";
            this.membershipCostBtn.UseVisualStyleBackColor = true;
            this.membershipCostBtn.Visible = false;
            this.membershipCostBtn.Click += new System.EventHandler(this.membershipCostBtn_Click);
            // 
            // membershipTableAdapter1
            // 
            this.membershipTableAdapter1.ClearBeforeFill = true;
            // 
            // membershipDataSet1
            // 
            this.membershipDataSet1.DataSetName = "MembershipDataSet";
            this.membershipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeDataSet1
            // 
            this.employeeDataSet1.DataSetName = "EmployeeDataSet";
            this.employeeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeCostBtn
            // 
            this.employeeCostBtn.Location = new System.Drawing.Point(560, 181);
            this.employeeCostBtn.Name = "employeeCostBtn";
            this.employeeCostBtn.Size = new System.Drawing.Size(131, 73);
            this.employeeCostBtn.TabIndex = 4;
            this.employeeCostBtn.Text = "Total Employee Salary";
            this.employeeCostBtn.UseVisualStyleBackColor = true;
            this.employeeCostBtn.Visible = false;
            this.employeeCostBtn.Click += new System.EventHandler(this.employeeCostBtn_Click);
            // 
            // classRevBtn
            // 
            this.classRevBtn.Location = new System.Drawing.Point(560, 181);
            this.classRevBtn.Name = "classRevBtn";
            this.classRevBtn.Size = new System.Drawing.Size(131, 73);
            this.classRevBtn.TabIndex = 5;
            this.classRevBtn.Text = "Total Class Revenue";
            this.classRevBtn.UseVisualStyleBackColor = true;
            this.classRevBtn.Visible = false;
            this.classRevBtn.Click += new System.EventHandler(this.classRevBtn_Click);
            // 
            // classDataSet1
            // 
            this.classDataSet1.DataSetName = "ClassDataSet";
            this.classDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classTableAdapter1
            // 
            this.classTableAdapter1.ClearBeforeFill = true;
            // 
            // memberTotalBtn
            // 
            this.memberTotalBtn.Location = new System.Drawing.Point(560, 181);
            this.memberTotalBtn.Name = "memberTotalBtn";
            this.memberTotalBtn.Size = new System.Drawing.Size(131, 73);
            this.memberTotalBtn.TabIndex = 6;
            this.memberTotalBtn.Text = "Total Members";
            this.memberTotalBtn.UseVisualStyleBackColor = true;
            this.memberTotalBtn.Visible = false;
            this.memberTotalBtn.Click += new System.EventHandler(this.memberTotalBtn_Click);
            // 
            // memberDataSet1
            // 
            this.memberDataSet1.DataSetName = "MemberDataSet";
            this.memberDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // noiBtn
            // 
            this.noiBtn.Location = new System.Drawing.Point(560, 181);
            this.noiBtn.Name = "noiBtn";
            this.noiBtn.Size = new System.Drawing.Size(131, 73);
            this.noiBtn.TabIndex = 7;
            this.noiBtn.Text = "Net Operating Income";
            this.noiBtn.UseVisualStyleBackColor = true;
            this.noiBtn.Visible = false;
            this.noiBtn.Click += new System.EventHandler(this.noiBtn_Click);
            // 
            // GymQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.noiBtn);
            this.Controls.Add(this.memberTotalBtn);
            this.Controls.Add(this.classRevBtn);
            this.Controls.Add(this.employeeCostBtn);
            this.Controls.Add(this.membershipCostBtn);
            this.Controls.Add(this.tablesComboBox);
            this.Controls.Add(this.clubExpBtn);
            this.Name = "GymQueries";
            this.Text = "GymQueries";
            ((System.ComponentModel.ISupportInitialize)(this.clubDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clubExpBtn;
        private ClubDataSet clubDataSet1;
        private ClubDataSetTableAdapters.CLUBTableAdapter clubTableAdapter1;
        private ClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox tablesComboBox;
        private System.Windows.Forms.Button membershipCostBtn;
        private MembershipDataSetTableAdapters.MEMBERSHIPTableAdapter membershipTableAdapter1;
        private MembershipDataSet membershipDataSet1;
        private EmployeeDataSetTableAdapters.EMPLOYEETableAdapter employeeTableAdapter1;
        private EmployeeDataSet employeeDataSet1;
        private System.Windows.Forms.Button employeeCostBtn;
        private System.Windows.Forms.Button classRevBtn;
        private ClassDataSet classDataSet1;
        private ClassDataSetTableAdapters.CLASSTableAdapter classTableAdapter1;
        private MemberDataSet memberDataSet1;
        private MemberDataSetTableAdapters.MEMBERTableAdapter memberTableAdapter1;
        private System.Windows.Forms.Button memberTotalBtn;
        private System.Windows.Forms.Button noiBtn;
    }
}