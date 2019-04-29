using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymInfo
{
    public partial class GymData_Membership : Form
    {
        public GymData_Membership()
        {
            InitializeComponent();
        }

        private void mEMBERSHIPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mEMBERSHIPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.membershipDataSet);

        }

        private void GymDate_Membership_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'membershipDataSet.MEMBERSHIP' table. You can move, or remove it, as needed.
            this.mEMBERSHIPTableAdapter.Fill(this.membershipDataSet.MEMBERSHIP);

        }
    }
}
