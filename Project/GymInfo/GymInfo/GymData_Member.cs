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

        private void mEMBERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mEMBERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.memberDataSet);

        }

        private void GymData_Member_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'memberDataSet.MEMBER' table. You can move, or remove it, as needed.
            this.mEMBERTableAdapter.Fill(this.memberDataSet.MEMBER);

        }
    }
}
