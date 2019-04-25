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
    public partial class GymData_Club : Form
    {
        public GymData_Club()
        {
            InitializeComponent();
        }

        private void cLUBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLUBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clubDataSet);

        }

        private void GymData_Club_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clubDataSet.CLUB' table. You can move, or remove it, as needed.
            this.cLUBTableAdapter.Fill(this.clubDataSet.CLUB);

        }
    }
}
