using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ModifyPartScreen : Form
    {
        public ModifyPartScreen()
        {
            InitializeComponent();
        }

        public ModifyPartScreen(InHouse inhouse)
        {
            InitializeComponent();

            modifyPartID.Text = Convert.ToString(inhouse.PartID);
            modifyPartName.Text = inhouse.Name;
            modifyPartInventory.Text = Convert.ToString(inhouse.InStock);
            modifyPartPrice.Text = Convert.ToString(inhouse.Price);
            modifyPartMin.Text = Convert.ToString(inhouse.Min);
            modifyPartMax.Text = Convert.ToString(inhouse.Max);
            modifyPartMachineID.Text = Convert.ToString(inhouse.MachineID);
            label8.Text = "Machine ID";
            modifyPartInHouse.Checked = true;

        }

            private void modifyPartCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
