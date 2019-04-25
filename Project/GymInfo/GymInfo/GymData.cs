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
    public partial class GymData_Member : Form
    {
        public GymData_Member()
        {
            InitializeComponent();
        }

        private void GymData_Load(object sender, EventArgs e)
        {
            GymTables x = new GymTables();
            x.Close();
        }

        private void mEMBERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mEMBERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gymDatabaseDataSet);

        }

        private void GymData_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDatabaseDataSet.MEMBER' table. You can move, or remove it, as needed.
            this.mEMBERTableAdapter.Fill(this.gymDatabaseDataSet.MEMBER);

        }
    }
}
