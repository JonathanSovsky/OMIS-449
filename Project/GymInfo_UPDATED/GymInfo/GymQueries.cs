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
            // make certain buttons show up when it is at a specific combo box item

            if (tablesComboBox.SelectedItem.Equals("Club"))
            {
                clubExpBtn.Visible = true;
                eachClubBtn.Visible = true;
            }

            // makes buttons invisible again

            else
            {
                clubExpBtn.Visible = false;
                eachClubBtn.Visible = false;
            }

            // make certain buttons show up when it is at a specific combo box item

            if (tablesComboBox.SelectedItem.Equals("Membership"))
            {
                membershipCostBtn.Visible = true;
                
            }

            // makes buttons invisible again

            else
            {
                membershipCostBtn.Visible = false;
                
            }

            // make certain buttons show up when it is at a specific combo box item

            if (tablesComboBox.SelectedItem.Equals("Employee"))
            {
                employeeCostBtn.Visible = true;
                employeeNumBtn.Visible = true;
            }

            // makes buttons invisible again

            else
            {
                employeeCostBtn.Visible = false;
                employeeNumBtn.Visible = false;
            }

            // make certain buttons show up when it is at a specific combo box item

            if (tablesComboBox.SelectedItem.Equals("Class"))
            {
                classRevBtn.Visible = true;
            }

            // makes buttons invisible again

            else
            {
                classRevBtn.Visible = false;
            }

            // make certain buttons show up when it is at a specific combo box item

            if (tablesComboBox.SelectedItem.Equals("Member"))
            {
                memberTotalBtn.Visible = true;
                percentBtn.Visible = true;
                clubMembersBtn.Visible = true;
            }

            // makes buttons invisible again

            else
            {
                memberTotalBtn.Visible = false;
                percentBtn.Visible = false;
                clubMembersBtn.Visible = false;
            }

            // make certain buttons show up when it is at a specific combo box item

            if (tablesComboBox.SelectedItem.Equals("Gym"))
            {
                noiBtn.Visible = true;
            }

            // makes buttons invisible again

            else
            {
                noiBtn.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Query gives the gym total expenses

            decimal cost;

            cost = (decimal) this.clubTableAdapter1.ClubExpenseQuery();

            MessageBox.Show("The gym's total club expenses are " + cost.ToString("c"));
        }

        private void membershipCostBtn_Click(object sender, EventArgs e)
        {
            // Query gives them the total membership cost

            decimal cost;

            cost = (decimal)this.membershipTableAdapter1.MembershipCostQuery();

            MessageBox.Show("The gym's total membership revenue is " + cost.ToString("c"));
        }

        private void employeeCostBtn_Click(object sender, EventArgs e)
        {
            // Query gives the total salary

            decimal cost;

            cost = (decimal)this.employeeTableAdapter1.EmployeeSalaryQuery();

            MessageBox.Show("The gym's total employee salary cost is " + cost.ToString("c"));
        }

        private void classRevBtn_Click(object sender, EventArgs e)
        {
            // Query gives the total class payments

            decimal cost;

            cost = (decimal)this.classTableAdapter1.ClassCostQuery();

            MessageBox.Show("The gym's total class cost is " + cost.ToString("c"));
        }

        private void memberTotalBtn_Click(object sender, EventArgs e)
        {
            // Query shows total number of members

            decimal total;

            total = (decimal)this.memberTableAdapter1.MemberCountQuery();

            MessageBox.Show("The gym has" + total.ToString() + " total members");
        }

        private void noiBtn_Click(object sender, EventArgs e)
        {
            // Gives the Net Operating Income

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

        private void clubMembersBtn_Click(object sender, EventArgs e)
        {
            // Query gives the number of members in each club

            int club1;
            int club2;
            int club3;
            int club4;
            int club5;

            club1 = (int)this.membershipTableAdapter1.MemberCountClub1Query();
            club2 = (int)this.membershipTableAdapter1.MemberCountClub2Query();
            club3 = (int)this.membershipTableAdapter1.MemberCountClub3Query();
            club4 = (int)this.membershipTableAdapter1.MemberCountClub4Query();
            club5 = (int)this.membershipTableAdapter1.MemberCountClub5Query();

            MessageBox.Show("Club 1 has " + club1.ToString() + " members. " +
                "Club 2 has " + club2.ToString() + " members. " +
                "Club 3 has " + club3.ToString() + " members. " +
                "Club 4 has " + club4.ToString() + " members. " +
                "Club 5 has " + club5.ToString() + " members.");
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            // Query gives percent of members that are taking classes

            decimal number;

            number = (decimal)this.membershipTableAdapter1.MembershipClassesQuery();

            MessageBox.Show(number.ToString("p") + " of members are currently taking classes.");
        }

        private void eachClubBtn_Click(object sender, EventArgs e)
        {
            // Query gives the expense of each club

            decimal club1;
            decimal club2;
            decimal club3;
            decimal club4;
            decimal club5;

            club1 = (decimal)this.clubTableAdapter1.Club1ExpensesQueries();
            club2 = (decimal)this.clubTableAdapter1.Club2ExpensesQueries();
            club3 = (decimal)this.clubTableAdapter1.Club3ExpensesQueries();
            club4 = (decimal)this.clubTableAdapter1.Club4ExpensesQueries();
            club5 = (decimal)this.clubTableAdapter1.Club5ExpensesQueries();

            MessageBox.Show("Club 1 spends " + club1.ToString("c") + ". " +
                "Club 2 spends " + club2.ToString("c") + ". " +
                "Club 3 spends " + club3.ToString("c") + ". " +
                "Club 4 spends " + club4.ToString("c") + ". " +
                "Club 5 spends " + club5.ToString("c") + ".");
        }

        private void employeeNumBtn_Click(object sender, EventArgs e)
        {
            // Query gives the amount of employees in each club

            int club1;
            int club2;
            int club3;
            int club4;
            int club5;

            club1 = (int)this.employeeTableAdapter1.EmployeeClub1Query();
            club2 = (int)this.employeeTableAdapter1.EmployeeClub2Query();
            club3 = (int)this.employeeTableAdapter1.EmployeeClub3Query();
            club4 = (int)this.employeeTableAdapter1.EmployeeClub4Query();
            club5 = (int)this.employeeTableAdapter1.EmployeeClub5Query();

            MessageBox.Show("Club 1 has " + club1.ToString() + " employees. " +
                "Club 2 has " + club2.ToString() + " employees. " +
                "Club 3 has " + club3.ToString() + " employees. " +
                "Club 4 has " + club4.ToString() + " employees. " +
                "Club 5 has " + club5.ToString() + " employees.");
        }
    }
}
