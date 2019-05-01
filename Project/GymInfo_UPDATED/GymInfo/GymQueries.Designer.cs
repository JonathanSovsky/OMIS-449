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
            this.components = new System.ComponentModel.Container();
            this.clubExpBtn = new System.Windows.Forms.Button();
            this.clubDataSet1 = new GymInfo.ClubDataSet();
            this.clubTableAdapter1 = new GymInfo.ClubDataSetTableAdapters.CLUBTableAdapter();
            this.cLUBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new GymInfo.ClubDataSetTableAdapters.TableAdapterManager();
            this.tablesComboBox = new System.Windows.Forms.ComboBox();
            this.membershipCostBtn = new System.Windows.Forms.Button();
            this.membershipTableAdapter1 = new GymInfo.MembershipDataSetTableAdapters.MEMBERSHIPTableAdapter();
            this.membershipDataSet1 = new GymInfo.MembershipDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.clubDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipDataSet1)).BeginInit();
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
            // cLUBBindingSource
            // 
            this.cLUBBindingSource.DataMember = "CLUB";
            this.cLUBBindingSource.DataSource = this.clubDataSet1;
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
            "Membership"});
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
            // GymQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.membershipCostBtn);
            this.Controls.Add(this.tablesComboBox);
            this.Controls.Add(this.clubExpBtn);
            this.Name = "GymQueries";
            this.Text = "GymQueries";
            ((System.ComponentModel.ISupportInitialize)(this.clubDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clubExpBtn;
        private ClubDataSet clubDataSet1;
        private ClubDataSetTableAdapters.CLUBTableAdapter clubTableAdapter1;
        private System.Windows.Forms.BindingSource cLUBBindingSource;
        private ClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox tablesComboBox;
        private System.Windows.Forms.Button membershipCostBtn;
        private MembershipDataSetTableAdapters.MEMBERSHIPTableAdapter membershipTableAdapter1;
        private MembershipDataSet membershipDataSet1;
    }
}