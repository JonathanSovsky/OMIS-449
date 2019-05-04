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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void checkPasswordBtn_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admincode")
            {
                MessageBox.Show("Password is correct");

                Gym_QT x = new Gym_QT();

                x.Show();
            }
            else
            {
                MessageBox.Show("Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
