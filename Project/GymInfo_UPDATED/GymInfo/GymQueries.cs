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
    public partial class GymQueries : Form
    {
        public GymQueries()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tablesComboBox.SelectedItem.Equals("Club"))
            {
                clubExpBtn.Visible = true;
            }

            else
            {
                clubExpBtn.Visible = false;
            }

            if (tablesComboBox.SelectedItem.Equals("Membership"))
            {
                membershipCostBtn.Visible = true;
            }

            else
            {
                membershipCostBtn.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal cost;

            cost = (decimal) this.clubTableAdapter1.ClubExpenseQuery();

            MessageBox.Show("The gym's total club expenses are " + cost.ToString("c"));
        }

        private void membershipCostBtn_Click(object sender, EventArgs e)
        {
            decimal cost;

            cost = (decimal)this.membershipTableAdapter1.MembershipCostQuery();

            MessageBox.Show("The gym's total membership revenue is " + cost.ToString("c"));
        }

        private void cLUBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLUBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clubDataSet1);

        }
    }
}
