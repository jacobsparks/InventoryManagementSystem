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
    public partial class AddPartScreen : Form
    {
        public AddPartScreen()
        {
            InitializeComponent();
        }

        
        private void addPartCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addPartSave_Click(object sender, EventArgs e)
        {
            int partID = Int32.Parse(addPartID.Text);
            int inStock = Int32.Parse(addPartInventory.Text);
            decimal price = decimal.Parse(addPartPrice.Text);
            int min = Int32.Parse(addPartMin.Text);
            int max = Int32.Parse(addPartMax.Text);

            if (addPartInHouse.Checked)
            {
                int machineID = Int32.Parse(addPartMachineID.Text);
                InHouse savePart = new InHouse(partID, addPartName.Text, price, inStock, min, max, machineID);
                Inventory.addPart(savePart);
            }
            else
            {
                string companyName = addPartMachineID.Text;
                Outsourced savePart = new Outsourced(partID, addPartName.Text, price, inStock, min, max, companyName);
                Inventory.addPart(savePart);
            }
            Close();
                
        }

        private void addPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            machineIDLabel.Text = "Machine ID";
        }

        private void addPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            machineIDLabel.Text = "Company Name";
        }
    }
}
