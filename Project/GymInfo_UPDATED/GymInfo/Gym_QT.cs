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
    public partial class Gym_QT : Form
    {
        public Gym_QT()
        {
            InitializeComponent();
        }

        private void tableBtn_Click(object sender, EventArgs e)
        {
            GymTables x = new GymTables();

            x.Show();
        }

        private void queriesBtn_Click(object sender, EventArgs e)
        {
            GymQueries x = new GymQueries();

            x.Show();
        }
    }
}
