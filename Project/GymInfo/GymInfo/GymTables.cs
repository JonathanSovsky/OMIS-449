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
    public partial class GymTables : Form
    {
        public GymTables()
        {
            InitializeComponent();
        }

        private void GymTables_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GymData_Member x = new GymData_Member();
            x.Show();
        }

        private void membershipBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void classBtn_Click(object sender, EventArgs e)
        {

        }

        private void clubBtn_Click(object sender, EventArgs e)
        {

        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
