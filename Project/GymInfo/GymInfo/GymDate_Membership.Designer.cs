namespace GymInfo
{
    partial class GymData_Membership
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GymData_Membership));
            this.membershipDataSet = new GymInfo.MembershipDataSet();
            this.mEMBERSHIPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEMBERSHIPTableAdapter = new GymInfo.MembershipDataSetTableAdapters.MEMBERSHIPTableAdapter();
            this.tableAdapterManager = new GymInfo.MembershipDataSetTableAdapters.TableAdapterManager();
            this.mEMBERSHIPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.mEMBERSHIPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mEMBERSHIPDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.membershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERSHIPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERSHIPBindingNavigator)).BeginInit();
            this.mEMBERSHIPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERSHIPDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // membershipDataSet
            // 
            this.membershipDataSet.DataSetName = "MembershipDataSet";
            this.membershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEMBERSHIPBindingSource
            // 
            this.mEMBERSHIPBindingSource.DataMember = "MEMBERSHIP";
            this.mEMBERSHIPBindingSource.DataSource = this.membershipDataSet;
            // 
            // mEMBERSHIPTableAdapter
            // 
            this.mEMBERSHIPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MEMBERSHIPTableAdapter = this.mEMBERSHIPTableAdapter;
            this.tableAdapterManager.UpdateOrder = GymInfo.MembershipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mEMBERSHIPBindingNavigator
            // 
            this.mEMBERSHIPBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mEMBERSHIPBindingNavigator.BindingSource = this.mEMBERSHIPBindingSource;
            this.mEMBERSHIPBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mEMBERSHIPBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mEMBERSHIPBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mEMBERSHIPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mEMBERSHIPBindingNavigatorSaveItem});
            this.mEMBERSHIPBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mEMBERSHIPBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mEMBERSHIPBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mEMBERSHIPBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mEMBERSHIPBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mEMBERSHIPBindingNavigator.Name = "mEMBERSHIPBindingNavigator";
            this.mEMBERSHIPBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mEMBERSHIPBindingNavigator.Size = new System.Drawing.Size(895, 31);
            this.mEMBERSHIPBindingNavigator.TabIndex = 0;
            this.mEMBERSHIPBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // mEMBERSHIPBindingNavigatorSaveItem
            // 
            this.mEMBERSHIPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mEMBERSHIPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mEMBERSHIPBindingNavigatorSaveItem.Image")));
            this.mEMBERSHIPBindingNavigatorSaveItem.Name = "mEMBERSHIPBindingNavigatorSaveItem";
            this.mEMBERSHIPBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.mEMBERSHIPBindingNavigatorSaveItem.Text = "Save Data";
            this.mEMBERSHIPBindingNavigatorSaveItem.Click += new System.EventHandler(this.mEMBERSHIPBindingNavigatorSaveItem_Click);
            // 
            // mEMBERSHIPDataGridView
            // 
            this.mEMBERSHIPDataGridView.AutoGenerateColumns = false;
            this.mEMBERSHIPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mEMBERSHIPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.mEMBERSHIPDataGridView.DataSource = this.mEMBERSHIPBindingSource;
            this.mEMBERSHIPDataGridView.Location = new System.Drawing.Point(12, 36);
            this.mEMBERSHIPDataGridView.Name = "mEMBERSHIPDataGridView";
            this.mEMBERSHIPDataGridView.RowTemplate.Height = 28;
            this.mEMBERSHIPDataGridView.Size = new System.Drawing.Size(873, 402);
            this.mEMBERSHIPDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "membershipId";
            this.dataGridViewTextBoxColumn1.HeaderText = "membershipId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "memberId";
            this.dataGridViewTextBoxColumn2.HeaderText = "memberId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "clubId";
            this.dataGridViewTextBoxColumn3.HeaderText = "clubId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "classId";
            this.dataGridViewTextBoxColumn4.HeaderText = "classId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "membershipCost";
            this.dataGridViewTextBoxColumn5.HeaderText = "membershipCost";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // GymData_Membership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.mEMBERSHIPDataGridView);
            this.Controls.Add(this.mEMBERSHIPBindingNavigator);
            this.Name = "GymData_Membership";
            this.Text = "Membership";
            this.Load += new System.EventHandler(this.GymDate_Membership_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERSHIPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERSHIPBindingNavigator)).EndInit();
            this.mEMBERSHIPBindingNavigator.ResumeLayout(false);
            this.mEMBERSHIPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERSHIPDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MembershipDataSet membershipDataSet;
        private System.Windows.Forms.BindingSource mEMBERSHIPBindingSource;
        private MembershipDataSetTableAdapters.MEMBERSHIPTableAdapter mEMBERSHIPTableAdapter;
        private MembershipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mEMBERSHIPBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mEMBERSHIPBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView mEMBERSHIPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}