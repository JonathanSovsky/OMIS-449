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
    public partial class GymData_Class : Form
    {
        public GymData_Class()
        {
            InitializeComponent();
        }

        private void cLASSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLASSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.classDataSet);

        }

        private void GymData_Class_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classDataSet.CLASS' table. You can move, or remove it, as needed.
            this.cLASSTableAdapter.Fill(this.classDataSet.CLASS);

        }
    }
}
