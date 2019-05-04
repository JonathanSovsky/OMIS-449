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

            if (tablesComboBox.SelectedItem.Equals("Employee"))
            {
                employeeCostBtn.Visible = true;
            }

            else
            {
                employeeCostBtn.Visible = false;
            }

            if (tablesComboBox.SelectedItem.Equals("Class"))
            {
                classRevBtn.Visible = true;
            }

            else
            {
                classRevBtn.Visible = false;
            }

            if (tablesComboBox.SelectedItem.Equals("Member"))
            {
                memberTotalBtn.Visible = true;
            }

            else
            {
                memberTotalBtn.Visible = false;
            }

            if (tablesComboBox.SelectedItem.Equals("Gym"))
            {
                noiBtn.Visible = true;
            }

            else
            {
                noiBtn.Visible = false;
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

        private void employeeCostBtn_Click(object sender, EventArgs e)
        {
            decimal cost;

            cost = (decimal)this.employeeTableAdapter1.EmployeeSalaryQuery();

            MessageBox.Show("The gym's total employee salary cost is " + cost.ToString("c"));
        }

        private void classRevBtn_Click(object sender, EventArgs e)
        {
            decimal cost;

            cost = (decimal)this.classTableAdapter1.ClassCostQuery();

            MessageBox.Show("The gym's total class cost is " + cost.ToString("c"));
        }

        private void memberTotalBtn_Click(object sender, EventArgs e)
        {
            decimal total;

            total = (decimal)this.memberTableAdapter1.MemberCountQuery();

            MessageBox.Show("The gym has" + total.ToString() + " total members");
        }

        private void noiBtn_Click(object sender, EventArgs e)
        {
            decimal employee;
            decimal club;
            decimal membership;
            decimal classm;
            decimal noi;
            decimal cost;
            decimal revenue;

            employee = (decimal)this.employeeTableAdapter1.EmployeeSalaryQuery();
            club = (decimal)this.clubTableAdapter1.ClubExpenseQuery();
            membership = (decimal)this.membershipTableAdapter1.MembershipCostQuery();
            classm = (decimal)this.classTableAdapter1.ClassCostQuery();

            cost = employee + club;
            revenue = classm + membership;

            noi = revenue - cost;

            MessageBox.Show("Your Net Operating Income is " + noi.ToString("c"));
        }
    }
}
